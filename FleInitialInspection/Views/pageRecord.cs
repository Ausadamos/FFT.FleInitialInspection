using CommonClassLibrary;
using CommonClassLibrary.Controllers;
using FleInitialInspectionManagement.Controller;
using FleInitialInspectionManagement.Property;
using MachineLibrary;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace FleInitialInspection.Views
{
    public partial class pageRecord : UserControl
    {
        public pageRecord()
        {
            InitializeComponent();
        }

        //----- KIKUSUI -----------------
        KIKUSUI_PAS _kikusui = null;

        //----- Ophire -----------------
        Ophir ophir_power = null;

        //============ Contec ============
        aioConnection aio_ADI12_8_Monitor = new aioConnection();
        dioConnection dio_16_Alarm = new dioConnection();
        dioConnection dio_RRY_relay = new dioConnection();

        int statusRRY_SDIN = 1;
        int statusRRY_PSON = 1;
        string resultMsg = "";

        //-- For SRS
        double srs_data = 0;
        double snr_data = 0;
        string srs_judge = "";
        public static double srs_min = 0;
        public static double srs_max = 0;


        //For check power output at start measurement
        Stopwatch stw = new Stopwatch();

        string[] txtAlarmArr = { "txtAlarmRefFuse", "txtAlarmRefTemp", "txtAlarmFetTemp", "txtAlarmHsTemp", "txtAlarmLdiMax", "txtAlarmCavTemp", "txtAlarmAccTemp" };
        string[] txtMonitorArr = { "txtMorCavOut", "txtMorRefFuse", "txtMorLDI", "txtMorRefTemp", "txtMorFetTemp", "txtMorHsTemp", "txtMorCavTemp1", "txtMorCavTemp2", "txtMorCavTemp3", "txtMorAcc" };
        string[] txtTempArr = { "txtTempFwPump", "txtTempBwPump", "txtTempFwTfb", "txtTempBwTfb", "txtTempFwSpice", "txtTempBwSpice", "txtTempAttn", "txtTempRefSpice", "txtTempOutputFiber", "txtTempFleRearFiber", "txtTempOutputSpicePoint", "txtTempOutputSpiceQbhPoint" };

        int maxRoundInspection = 0;

        CommonController _commonController = new CommonController();
        FleInitialInspectionSettingController _fleInitialInspectionSettingController = new FleInitialInspectionSettingController();
        FleInitialInspectionSettingDetailController _fleInitialInspectionSettingDetailController = new FleInitialInspectionSettingDetailController();

        private void pageRecord_Load(object sender, EventArgs e)
        {
            if (inititailMachine() == false)
            {
                Application.Exit();
                return;
            }

            lblStatusAlert.BackColor = Color.White;
            lblStatusAlert.Text = "";
            this.Text = Properties.Settings.Default.PROGRAM_NAME + " " + Properties.Settings.Default.PROGRAM_VERSION;

            txtTypeName.Text = FleInitialInspectionGlobal.typeName;
            txtSerial.Text = FleInitialInspectionGlobal.serial;
            txtOperator.Text = CommonClassLibraryGlobal.OPERATOR_ID;
            txtThreshold.Text = Properties.Settings.Default.SAFETY_SHUT_DOWN_THRESHOLD_SAFETY.ToString();
            txtOffset.Text = Properties.Settings.Default.SAFETY_SHUT_DOWN_OFFSET.ToString();
            lblStatusAlert.BackColor = Color.White;
            lblStatusAlert.Text = "";
            txtStepNo.Text = "0";

            FleInitialInspectionSettingProperty = _fleInitialInspectionSettingController.Search(ClassCommon.specNo);

            if (initialInspectionSetting_model == null)
            {
                CommonClassLibraryGlobal.showError("ไม่พบข้อมูลการตั้งค่าข้อมูลสเปกตัวงาน");
                this.Dispose();
                return;
            }

            initialInspectionDetailSetting_listModel = initialInspectionDetailSettingSQLFactory.SelectAll(ClassCommon.specNo);
            if (initialInspectionDetailSetting_listModel.Count == 0)
            {
                CommonClassLibraryGlobal.showError("ไม่พบข้อมูลการตั้งค่าข้อมูลสเปกตัวงาน");
                this.Dispose();
                return;
            }

            maxRoundInspection = initialInspectionSQLFactory.getMaxRound(ClassCommon.typeName, ClassCommon.serial);

        }

        private bool inititailMachine()
        {
            try
            {
                bool result = false;
                string resultCheck = "";


                //2.Machine Connect
                //2.1 Relay

                try
                {
                    serialDIO_Relay.PortName = Properties.Settings.Default.SYSTEM_DIO_RELAY_COM_NAME;
                    serialDIO_Relay.BaudRate = 115200;
                    serialDIO_Relay.Open();
                }

                catch (Exception ex)
                {
                    CommonClassLibraryGlobal.showError("ไม่สามารถเชื่อมต่อกับ Relay ได้ \nกรุณาตรวจสอบ การตั้งค่า ComName [ ComName ในปัจจุบันคือ '" + Properties.Settings.Default.SYSTEM_DIO_RELAY_COM_NAME + "' ] \nหรือ การเชื่อมต่อของอุปกรณ์ว่าเชื่อมต่ออยู่หรือไม่");
                    return result;
                }

                //Open all Relay while loading
                for (int i = 1; i <= 4; i++)
                {
                    serialDIO_Relay.Write("@relay" + i + " OFF" + Environment.NewLine);
                }

                //2.3 Kikusui
                try
                {
                    _kikusui = new KIKUSUI_PAS(Properties.Settings.Default.SYSTEM_KIKUSUI_USB_NAME, Properties.Settings.Default.SYSTEM_KIKUSUI_ADDRESS, KIKUSUI_PAS.MODE.VOLTAGE, Properties.Settings.Default.SYSTEM_KIKUSUI_MAX_CURRENT, Properties.Settings.Default.SYSTEM_KIKUSUI_WAITTIME);
                }
                catch (Exception ex)
                {
                    CommonClassLibraryGlobal.showError("Kikusui : " + ex.Message);
                    return result;
                }

                //2.4 Ophir
                ophir_power = new Ophir();
                resultCheck = ophir_power.OpenUSBDevice(Properties.Settings.Default.SYSTEM_OPHIR_POWER_SERIAL);
                if (resultCheck != "success")
                {
                    if (resultCheck == "Invalid Argument")
                    {
                        CommonClassLibraryGlobal.showError("Serial Number ของ Ophir Power ไม่ถูกต้อง กรุณาตรวจสอบการตั้งค่าข้อมูล" + Properties.Settings.Default.SYSTEM_OPHIR_POWER_SERIAL);
                        return result;
                    }
                    else
                    {
                        CommonClassLibraryGlobal.showError("Ophir Power : " + resultCheck);
                        return result;
                    }
                }

                resultCheck = ophir_power.StartStream();

                if (resultCheck != "success")
                {
                    CommonClassLibraryGlobal.showError("Ophir Power : " + resultCheck);
                    return result;
                }

                //2.5 aio_ADI12_8 

                resultMsg = aio_ADI12_8_Monitor.Init("ADI12-8 (get Mornitor)", Properties.Settings.Default.MACHINE_ADI12_8);

                if (resultMsg != "success")
                {
                    CommonClassLibraryGlobal.showError(resultMsg);
                    return result;
                }

                //2.6 dio_16
                resultMsg = dio_16_Alarm.Init("DIO-16 (get Alarm)", Properties.Settings.Default.MACHINE_DI_16);

                if (resultMsg != "success")
                {
                    CommonClassLibraryGlobal.showError(resultMsg);
                    return result;
                }

                //2.7 dio_RRY
                resultMsg = dio_RRY_relay.Init("DIO-RRY (Relay)", Properties.Settings.Default.MACHINE_RRY);

                if (resultMsg != "success")
                {
                    CommonClassLibraryGlobal.showError(resultMsg);
                    return result;
                }

                //set SD_IN => OFF
                setRelay(Properties.Settings.Default.MACHINE_RRY_SD_IN_CHANNEL, "0");

                _kikusui.set_voltage(0);
                _kikusui.ps_off();
                _kikusui.set_voltage(0);

                return true;

            }
            catch (Exception ex)
            {
                CommonClassLibraryGlobal.showError(ex.Message);
                if (ophir_power.hDevice != 0) ophir_power.StopStreamAndClose();
                if (_kikusui != null) _kikusui.close_kikusui();
                if (aio_ADI12_8_Monitor.m_Id != 0) aio_ADI12_8_Monitor.exit();
                if (dio_16_Alarm.m_Id != 0) dio_16_Alarm.exit();
                Thread.Sleep(1000);
                return false;
            }

        }

        private void setRelay(int channel, string value)
        {
            resultMsg = dio_RRY_relay.setSigleBitChannel(channel, value);

            if (resultMsg != "success")
            {
                CommonClassLibraryGlobal.showError(resultMsg);
            }
        }

        private int getRelay(int channel, string value)
        {
            return dio_RRY_relay.getSigleBitChannel(channel);
        }

        private void txtTypeName_Click(object sender, EventArgs e)
        {

        }

        private void btnSD_IN_Click(object sender, EventArgs e)
        {
            btnSD_IN.Enabled = false;

            lblStatusAlert.BackColor = Color.White;
            lblStatusAlert.Text = "";

            setRelay(Properties.Settings.Default.MACHINE_RRY_SD_IN_CHANNEL, statusRRY_SDIN.ToString());
            Thread.Sleep(200);
            statusRRY_SDIN = getRelay(Properties.Settings.Default.MACHINE_RRY_SD_IN_CHANNEL, statusRRY_SDIN.ToString());

            if (statusRRY_SDIN == 1)
            {
                statusRRY_SDIN = 0;
                btnSD_IN.BackColor = Color.Green;
                btnPS_ON.Enabled = true;
            }
            else
            {
                statusRRY_SDIN = 1;
                btnSD_IN.BackColor = Color.Gray;
            }


            btnSD_IN.Enabled = true;
        }

        private void btnPS_ON_Click(object sender, EventArgs e)
        {
            if (btnSD_IN.BackColor != Color.Green)
            {
                CommonClassLibraryGlobal.showError("SD IN ยังไม่ Active");
                return;
            }

            // setRelay(0, "1");

            btnPS_ON.Enabled = false;
            btnSD_IN.Enabled = false;

            //  btnSD_IN.Enabled = false;
            setRelay(Properties.Settings.Default.MACHINE_RRY_DIGITAL_CHANNEL, statusRRY_PSON.ToString());
            Thread.Sleep(500);
            statusRRY_PSON = getRelay(Properties.Settings.Default.MACHINE_RRY_DIGITAL_CHANNEL, statusRRY_PSON.ToString());

            if (statusRRY_PSON == -1)
            {
                CommonClassLibraryGlobal.showError("ไม่สามารถติดต่อกับ Relay-RRY ได้ กรุณาลองใหม่อีกครั้ง");
                btnFL_ON.Enabled = false;
                return;
            }

            Thread.Sleep(200);

            //Trick Clear Alarm
            setRelay(Properties.Settings.Default.MACHINE_RRY_CLS_ALARM_CHANNEL, "1");
            Thread.Sleep(200);
            setRelay(Properties.Settings.Default.MACHINE_RRY_CLS_ALARM_CHANNEL, "0");


            if (statusRRY_PSON == 1)
            {
                statusRRY_PSON = 0;
                btnPS_ON.BackColor = Color.Green;
            }
            else
            {
                statusRRY_PSON = 1;
                btnPS_ON.BackColor = Color.Gray;
            }

            if (_kikusui.ps_on())
            {
                if (!bgwSafety.IsBusy) bgwSafety.RunWorkerAsync();
            }
            else
            {
                return;
            }

            btnPS_ON.Enabled = true;
            btnFL_ON.Enabled = true;
        }

        private void btnFL_ON_Click(object sender, EventArgs e)
        {

            if (btnPS_ON.BackColor != Color.Green)
            {
                CommonClassLibraryGlobal.showError("Power Supply ยังไม่ Active");
                return;
            }

            txtOpmFlow.Enabled = true;
            txtFlFlow.Enabled = true;
            txtLdCurrent.Enabled = true;

            if (lblOpmFlow_Judge.Text != "OK")
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก OPM Flow ให้มีค่า judge เป็น OK เท่านั้น");
                return;
            }

            if (lblFlFlow_Judge.Text != "OK")
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก FL Flow ให้มีค่า judge เป็น OK เท่านั้น");
                return;
            }

            btnBack.Enabled = false;
            txtOpmFlow.Enabled = false;
            txtFlFlow.Enabled = false;

            btnFL_ON.Enabled = false;
            btnStop.Enabled = true;

            bgwOphir.RunWorkerAsync();
            bgwADI12_8.RunWorkerAsync();
            bgwdio16.RunWorkerAsync();

            //------------- start datetime -------------
            txtStartDate.Text = _commonController.getDateTimeNow();

            if (!bgwSafety.IsBusy) bgwSafety.RunWorkerAsync();

            Thread.Sleep(1000);

            _kikusui.ps_on();


            bool result;

            if (int.Parse(txtStepNo.Text) == 0)
            {
                result = doWorkKikusui(true);
            }
            else
            {
                result = doWorkKikusui(false);
            }

            if (result)
            {
                btnSaveToDB.Enabled = true;
                btnGetData_Mornitor.Enabled = true;
            }

        }



        private bool doWorkKikusui(bool step_add)
        {
            bool result = true;

            if (step_add)
            {
                txtStepNo.Text = (int.Parse(txtStepNo.Text) + 1).ToString();
            }

            //-- Set default

            txtLdCurrent.Text = "";

            for (int i = 0; i < txtTempArr.Length; i++)
            {
                groupBoxTemp.Controls[txtTempArr[i]].Text = "";
                groupBoxTemp.Controls[txtTempArr[i]].Enabled = true;
            }

            for (int i = 0; i < txtMonitorArr.Length; i++)
            {
                groupBoxMonitor.Controls[txtMonitorArr[i]].Text = "";
            }

            for (int i = 0; i < txtAlarmArr.Length; i++)
            {
                groupBoxAlarm.Controls[txtAlarmArr[i]].BackColor = Color.White;
            }

            txtTargetValueStep.Text = initialInspectionDetailSetting_listModel[int.Parse(txtStepNo.Text)].target_value;
            lblTarget.Text = "Target " + initialInspectionDetailSetting_listModel[int.Parse(txtStepNo.Text)].target_name + " :";

            if (initialInspectionDetailSetting_listModel[int.Parse(txtStepNo.Text)].target_name == "Power")
            {
                lblTargetUnit.Text = "W";

                while (double.Parse(txtOutputPower.Text) < double.Parse(txtTargetValueStep.Text))
                {

                    _kikusui.set_voltage(double.Parse(txtReadVoltage.Text) + 0.1);
                    txtReadVoltage.Text = _kikusui.get_voltage().ToString("F2");

                    Thread.Sleep(200);
                    Application.DoEvents();
                    if (bgwSafety.IsBusy == false)
                    {
                        result = false;
                        goto end_sub_doWorkKikusui;
                    }
                }

            }
            else
            {
                lblTargetUnit.Text = "V";
                while (double.Parse(txtReadVoltage.Text) < double.Parse(txtTargetValueStep.Text))
                {

                    _kikusui.set_voltage(double.Parse(txtReadVoltage.Text) + 0.1);
                    txtReadVoltage.Text = _kikusui.get_voltage().ToString("F2");

                    Thread.Sleep(200);
                    Application.DoEvents();
                    if (bgwSafety.IsBusy == false)
                    {
                        result = false;
                        goto end_sub_doWorkKikusui;
                    }

                }

            }

            if (initialInspectionDetailSetting_listModel[int.Parse(txtStepNo.Text)].srs_need == "1")
            {
                btnSRS.Enabled = true;
            }
            else
            {
                btnSRS.Enabled = false;
            }

        end_sub_doWorkKikusui:

            FleInitialInspectionGlobal.WL = null;
            FleInitialInspectionGlobal.PW = null;
            FleInitialInspectionGlobal.CTRWL = "";
            FleInitialInspectionGlobal.SPAN = "";
            FleInitialInspectionGlobal.START_WL = "";
            FleInitialInspectionGlobal.STOP_WL = "";
            FleInitialInspectionGlobal.WLFREQ = "";
            FleInitialInspectionGlobal.REFL = "";
            FleInitialInspectionGlobal.LSCL = "";
            FleInitialInspectionGlobal.RESLN = "";
            FleInitialInspectionGlobal.AVG = "";
            FleInitialInspectionGlobal.SMPLAUTO = "";
            FleInitialInspectionGlobal.SMPL = "";
            FleInitialInspectionGlobal.HIGH = "";
            FleInitialInspectionGlobal.LBL = "";
            FleInitialInspectionGlobal.ME = "";
            FleInitialInspectionGlobal.LSUNT = "";
            FleInitialInspectionGlobal.NMSKV = "";
            FleInitialInspectionGlobal.RESCOR = "";
            FleInitialInspectionGlobal.PeakPower = "";
            FleInitialInspectionGlobal.PeakWL = "";
            FleInitialInspectionGlobal.RamanPeak = "";
            FleInitialInspectionGlobal.RamanWL = "";
            FleInitialInspectionGlobal.Value = "";

            return result;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            bgwSafety.CancelAsync();
        }

        private void bgwSafety_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void bgwSafety_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

        }

        private void bgwSafety_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

        }
    }
}
