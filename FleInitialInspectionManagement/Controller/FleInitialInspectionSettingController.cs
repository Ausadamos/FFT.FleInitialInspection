using BusinessData.Property;
using FleInitialInspectionManagement.Models;
using FleInitialInspectionManagement.Property;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace FleInitialInspectionManagement.Controller
{
    public class FleInitialInspectionSettingController
    {

        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        FleInitialInspectionSettingModels _model = new FleInitialInspectionSettingModels();

        public bool Delete(FleInitialInspectionSettingProperty dataItem)
        {
            bool result = true;
            try
            {
                _resultData = _model.Delete(dataItem);
                if (_resultData.StatusOnDb == false)
                {
                    MessageBox.Show(_resultData.MessageOnDb, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            return result;
        }

        public bool Insert(FleInitialInspectionSettingProperty dataItem)
        {
            bool result = true;
            try
            {
                _resultData = _model.Insert(dataItem);
                if (_resultData.StatusOnDb == false)
                {
                    MessageBox.Show(_resultData.MessageOnDb, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            return result;
        }

        public FleInitialInspectionSettingProperty Search(FleInitialInspectionSettingProperty dataItem)
        {
            FleInitialInspectionSettingProperty _property = null;
            try
            {
                _resultData = _model.Search(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        _property = new FleInitialInspectionSettingProperty
                        {
                            ID = _resultData.ResultOnDb.Rows[0]["ID"].ToString(),
                            PURCHASE_NO = _resultData.ResultOnDb.Rows[0]["PURCHASE_NO"].ToString(),
                            OPM_FLOW_MIN = _resultData.ResultOnDb.Rows[0]["OPM_FLOW_MIN"].ToString(),
                            OPM_FLOW_MAX = _resultData.ResultOnDb.Rows[0]["OPM_FLOW_MAX"].ToString(),
                            FL_FLOW_MIN = _resultData.ResultOnDb.Rows[0]["FL_FLOW_MIN"].ToString(),
                            FL_FLOW_MAX = _resultData.ResultOnDb.Rows[0]["FL_FLOW_MAX"].ToString(),
                            TS_TEMP_FWPUMP_MIN = _resultData.ResultOnDb.Rows[0]["TS_TEMP_FWPUMP_MIN"].ToString(),
                            TS_TEMP_FWPUMP_MAX = _resultData.ResultOnDb.Rows[0]["TS_TEMP_FWPUMP_MAX"].ToString(),
                            TS_TEMP_BWPUMP_MIN = _resultData.ResultOnDb.Rows[0]["TS_TEMP_BWPUMP_MIN"].ToString(),
                            TS_TEMP_BWPUMP_MAX = _resultData.ResultOnDb.Rows[0]["TS_TEMP_BWPUMP_MAX"].ToString(),
                            TS_TEMP_FWTFB_MIN = _resultData.ResultOnDb.Rows[0]["TS_TEMP_FWTFB_MIN"].ToString(),
                            TS_TEMP_FWTFB_MAX = _resultData.ResultOnDb.Rows[0]["TS_TEMP_FWTFB_MAX"].ToString(),
                            TS_TEMP_BWTFB_MIN = _resultData.ResultOnDb.Rows[0]["TS_TEMP_BWTFB_MIN"].ToString(),
                            TS_TEMP_BWTFB_MAX = _resultData.ResultOnDb.Rows[0]["TS_TEMP_BWTFB_MAX"].ToString(),
                            TS_TEMP_FWSPLICE_MIN = _resultData.ResultOnDb.Rows[0]["TS_TEMP_FWSPLICE_MIN"].ToString(),
                            TS_TEMP_FWSPLICE_MAX = _resultData.ResultOnDb.Rows[0]["TS_TEMP_FWSPLICE_MAX"].ToString(),
                            TS_TEMP_BWSPLICE_MIN = _resultData.ResultOnDb.Rows[0]["TS_TEMP_BWSPLICE_MIN"].ToString(),
                            TS_TEMP_BWSPLICE_MAX = _resultData.ResultOnDb.Rows[0]["TS_TEMP_BWSPLICE_MAX"].ToString(),
                            TS_TEMP_ATTN_MIN = _resultData.ResultOnDb.Rows[0]["TS_TEMP_ATTN_MIN"].ToString(),
                            TS_TEMP_ATTN_MAX = _resultData.ResultOnDb.Rows[0]["TS_TEMP_ATTN_MAX"].ToString(),
                            TS_TEMP_REFSPICE_MIN = _resultData.ResultOnDb.Rows[0]["TS_TEMP_REFSPICE_MIN"].ToString(),
                            TS_TEMP_REFSPICE_MAX = _resultData.ResultOnDb.Rows[0]["TS_TEMP_REFSPICE_MAX"].ToString(),
                            TS_TEMP_OUTPUTFIBER_MIN = _resultData.ResultOnDb.Rows[0]["TS_TEMP_OUTPUTFIBER_MIN"].ToString(),
                            TS_TEMP_OUTPUTFIBER_MAX = _resultData.ResultOnDb.Rows[0]["TS_TEMP_OUTPUTFIBER_MAX"].ToString(),
                            TS_TEMP_FLEREARFIBER_MIN = _resultData.ResultOnDb.Rows[0]["TS_TEMP_FLEREARFIBER_MIN"].ToString(),
                            TS_TEMP_FLEREARFIBER_MAX = _resultData.ResultOnDb.Rows[0]["TS_TEMP_FLEREARFIBER_MAX"].ToString(),
                            INUSE = _resultData.ResultOnDb.Rows[0]["INUSE"].ToString(),
                            IP_ADDRESS = _resultData.ResultOnDb.Rows[0]["IP_ADDRESS"].ToString(),
                            NAME_ADDRESS = _resultData.ResultOnDb.Rows[0]["NAME_ADDRESS"].ToString(),
                            CREATE_DATE = _resultData.ResultOnDb.Rows[0]["CREATE_DATE"].ToString(),
                            LAST_DATE = _resultData.ResultOnDb.Rows[0]["LAST_DATE"].ToString(),
                            CREATE_USER = _resultData.ResultOnDb.Rows[0]["CREATE_USER"].ToString(),
                            LAST_USER = _resultData.ResultOnDb.Rows[0]["LAST_USER"].ToString(),
                            DESCRIPTION = _resultData.ResultOnDb.Rows[0]["DESCRIPTION"].ToString(),
                            ALARM_REF_FUSE_NEED = _resultData.ResultOnDb.Rows[0]["ALARM_REF_FUSE_NEED"].ToString(),
                            ALARM_REF_TEMP_NEED = _resultData.ResultOnDb.Rows[0]["ALARM_REF_TEMP_NEED"].ToString(),
                            ALARM_FET_TEMP_NEED = _resultData.ResultOnDb.Rows[0]["ALARM_FET_TEMP_NEED"].ToString(),
                            ALARM_HS_TEMP_NEED = _resultData.ResultOnDb.Rows[0]["ALARM_HS_TEMP_NEED"].ToString(),
                            ALARM_LDI_MAX_NEED = _resultData.ResultOnDb.Rows[0]["ALARM_LDI_MAX_NEED"].ToString(),
                            ALARM_CAV_TEMP_NEED = _resultData.ResultOnDb.Rows[0]["ALARM_CAV_TEMP_NEED"].ToString(),
                            ALARM_ACC_TEMP_NEED = _resultData.ResultOnDb.Rows[0]["ALARM_ACC_TEMP_NEED"].ToString(),
                            TEMP_CRITERIA_OUTPUT_SPLICE_POINT_MIN = _resultData.ResultOnDb.Rows[0]["TEMP_CRITERIA_OUTPUT_SPLICE_POINT_MIN"].ToString(),
                            TEMP_OUTPUT_SPLICE_QBH_POINT_MIN = _resultData.ResultOnDb.Rows[0]["TEMP_OUTPUT_SPLICE_QBH_POINT_MIN"].ToString(),
                            TEMP_CRITERIA_OUTPUT_SPLICE_POINT_MAX = _resultData.ResultOnDb.Rows[0]["TEMP_CRITERIA_OUTPUT_SPLICE_POINT_MAX"].ToString(),
                            TEMP_OUTPUT_SPLICE_QBH_POINT_MAX = _resultData.ResultOnDb.Rows[0]["TEMP_OUTPUT_SPLICE_QBH_POINT_MAX"].ToString(),
                            MONITOR_CAV_OUT_SPEC_NEED = _resultData.ResultOnDb.Rows[0]["MONITOR_CAV_OUT_SPEC_NEED"].ToString(),
                            MONITOR_CAV_OUT_MIN = _resultData.ResultOnDb.Rows[0]["MONITOR_CAV_OUT_MIN"].ToString(),
                            MONITOR_CAV_OUT_MAX = _resultData.ResultOnDb.Rows[0]["MONITOR_CAV_OUT_MAX"].ToString(),
                            MONITOR_REF_FUSE_SPEC_NEED = _resultData.ResultOnDb.Rows[0]["MONITOR_REF_FUSE_SPEC_NEED"].ToString(),
                            MONITOR_REF_FUSE_MIN = _resultData.ResultOnDb.Rows[0]["MONITOR_REF_FUSE_MIN"].ToString(),
                            MONITOR_REF_FUSE_MAX = _resultData.ResultOnDb.Rows[0]["MONITOR_REF_FUSE_MAX"].ToString(),
                            MONITOR_LDI_SPEC_NEED = _resultData.ResultOnDb.Rows[0]["MONITOR_LDI_SPEC_NEED"].ToString(),
                            MONITOR_LDI_MIN = _resultData.ResultOnDb.Rows[0]["MONITOR_LDI_MIN"].ToString(),
                            MONITOR_LDI_MAX = _resultData.ResultOnDb.Rows[0]["MONITOR_LDI_MAX"].ToString(),
                            MONITOR_REF_TEMP_SPEC_NEED = _resultData.ResultOnDb.Rows[0]["MONITOR_REF_TEMP_SPEC_NEED"].ToString(),
                            MONITOR_REF_TEMP_MIN = _resultData.ResultOnDb.Rows[0]["MONITOR_REF_TEMP_MIN"].ToString(),
                            MONITOR_REF_TEMP_MAX = _resultData.ResultOnDb.Rows[0]["MONITOR_REF_TEMP_MAX"].ToString(),
                            MONITOR_FET_TEMP_SPEC_NEED = _resultData.ResultOnDb.Rows[0]["MONITOR_FET_TEMP_SPEC_NEED"].ToString(),
                            MONITOR_FET_TEMP_MIN = _resultData.ResultOnDb.Rows[0]["MONITOR_FET_TEMP_MIN"].ToString(),
                            MONITOR_FET_TEMP_MAX = _resultData.ResultOnDb.Rows[0]["MONITOR_FET_TEMP_MAX"].ToString(),
                            MONITOR_HS_TEMP_SPEC_NEED = _resultData.ResultOnDb.Rows[0]["MONITOR_HS_TEMP_SPEC_NEED"].ToString(),
                            MONITOR_HS_TEMP_MIN = _resultData.ResultOnDb.Rows[0]["MONITOR_HS_TEMP_MIN"].ToString(),
                            MONITOR_HS_TEMP_MAX = _resultData.ResultOnDb.Rows[0]["MONITOR_HS_TEMP_MAX"].ToString(),
                            MONITOR_CAV_TEMP1_SPEC_NEED = _resultData.ResultOnDb.Rows[0]["MONITOR_CAV_TEMP1_SPEC_NEED"].ToString(),
                            MONITOR_CAV_TEMP1_MIN = _resultData.ResultOnDb.Rows[0]["MONITOR_CAV_TEMP1_MIN"].ToString(),
                            MONITOR_CAV_TEMP1_MAX = _resultData.ResultOnDb.Rows[0]["MONITOR_CAV_TEMP1_MAX"].ToString(),
                            MONITOR_CAV_TEMP2_SPEC_NEED = _resultData.ResultOnDb.Rows[0]["MONITOR_CAV_TEMP2_SPEC_NEED"].ToString(),
                            MONITOR_CAV_TEMP2_MIN = _resultData.ResultOnDb.Rows[0]["MONITOR_CAV_TEMP2_MIN"].ToString(),
                            MONITOR_CAV_TEMP2_MAX = _resultData.ResultOnDb.Rows[0]["MONITOR_CAV_TEMP2_MAX"].ToString(),
                            MONITOR_CAV_TEMP3_SPEC_NEED = _resultData.ResultOnDb.Rows[0]["MONITOR_CAV_TEMP3_SPEC_NEED"].ToString(),
                            MONITOR_CAV_TEMP3_MIN = _resultData.ResultOnDb.Rows[0]["MONITOR_CAV_TEMP3_MIN"].ToString(),
                            MONITOR_CAV_TEMP3_MAX = _resultData.ResultOnDb.Rows[0]["MONITOR_CAV_TEMP3_MAX"].ToString(),
                            MONITOR_ACC_TEMP_SPEC_NEED = _resultData.ResultOnDb.Rows[0]["MONITOR_ACC_TEMP_SPEC_NEED"].ToString(),
                            MONITOR_ACC_TEMP_MIN = _resultData.ResultOnDb.Rows[0]["MONITOR_ACC_TEMP_MIN"].ToString(),
                            MONITOR_ACC_TEMP_MAX = _resultData.ResultOnDb.Rows[0]["MONITOR_ACC_TEMP_MAX"].ToString(),

                        };
                    }
                }
                else
                {
                    MessageBox.Show(_resultData.MessageOnDb, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return _property;
        }

        public List<FleInitialInspectionSettingProperty> Search()
        {
            List<FleInitialInspectionSettingProperty> listItem = new List<FleInitialInspectionSettingProperty>();
            try
            {
                _resultData = _model.Search();
                if (_resultData.StatusOnDb == true)
                {
                    foreach (DataRow row in _resultData.ResultOnDb.Rows)
                    {
                        FleInitialInspectionSettingProperty productProperty = new FleInitialInspectionSettingProperty
                        {
                            ID = row["ID"].ToString(),
                            PURCHASE_NO = row["PURCHASE_NO"].ToString(),
                            OPM_FLOW_MIN = row["OPM_FLOW_MIN"].ToString(),
                            OPM_FLOW_MAX = row["OPM_FLOW_MAX"].ToString(),
                            FL_FLOW_MIN = row["FL_FLOW_MIN"].ToString(),
                            FL_FLOW_MAX = row["FL_FLOW_MAX"].ToString(),
                            TS_TEMP_FWPUMP_MIN = row["TS_TEMP_FWPUMP_MIN"].ToString(),
                            TS_TEMP_FWPUMP_MAX = row["TS_TEMP_FWPUMP_MAX"].ToString(),
                            TS_TEMP_BWPUMP_MIN = row["TS_TEMP_BWPUMP_MIN"].ToString(),
                            TS_TEMP_BWPUMP_MAX = row["TS_TEMP_BWPUMP_MAX"].ToString(),
                            TS_TEMP_FWTFB_MIN = row["TS_TEMP_FWTFB_MIN"].ToString(),
                            TS_TEMP_FWTFB_MAX = row["TS_TEMP_FWTFB_MAX"].ToString(),
                            TS_TEMP_BWTFB_MIN = row["TS_TEMP_BWTFB_MIN"].ToString(),
                            TS_TEMP_BWTFB_MAX = row["TS_TEMP_BWTFB_MAX"].ToString(),
                            TS_TEMP_FWSPLICE_MIN = row["TS_TEMP_FWSPLICE_MIN"].ToString(),
                            TS_TEMP_FWSPLICE_MAX = row["TS_TEMP_FWSPLICE_MAX"].ToString(),
                            TS_TEMP_BWSPLICE_MIN = row["TS_TEMP_BWSPLICE_MIN"].ToString(),
                            TS_TEMP_BWSPLICE_MAX = row["TS_TEMP_BWSPLICE_MAX"].ToString(),
                            TS_TEMP_ATTN_MIN = row["TS_TEMP_ATTN_MIN"].ToString(),
                            TS_TEMP_ATTN_MAX = row["TS_TEMP_ATTN_MAX"].ToString(),
                            TS_TEMP_REFSPICE_MIN = row["TS_TEMP_REFSPICE_MIN"].ToString(),
                            TS_TEMP_REFSPICE_MAX = row["TS_TEMP_REFSPICE_MAX"].ToString(),
                            TS_TEMP_OUTPUTFIBER_MIN = row["TS_TEMP_OUTPUTFIBER_MIN"].ToString(),
                            TS_TEMP_OUTPUTFIBER_MAX = row["TS_TEMP_OUTPUTFIBER_MAX"].ToString(),
                            TS_TEMP_FLEREARFIBER_MIN = row["TS_TEMP_FLEREARFIBER_MIN"].ToString(),
                            TS_TEMP_FLEREARFIBER_MAX = row["TS_TEMP_FLEREARFIBER_MAX"].ToString(),
                            INUSE = row["INUSE"].ToString(),
                            IP_ADDRESS = row["IP_ADDRESS"].ToString(),
                            NAME_ADDRESS = row["NAME_ADDRESS"].ToString(),
                            CREATE_DATE = row["CREATE_DATE"].ToString(),
                            LAST_DATE = row["LAST_DATE"].ToString(),
                            CREATE_USER = row["CREATE_USER"].ToString(),
                            LAST_USER = row["LAST_USER"].ToString(),
                            DESCRIPTION = row["DESCRIPTION"].ToString(),
                            ALARM_REF_FUSE_NEED = row["ALARM_REF_FUSE_NEED"].ToString(),
                            ALARM_REF_TEMP_NEED = row["ALARM_REF_TEMP_NEED"].ToString(),
                            ALARM_FET_TEMP_NEED = row["ALARM_FET_TEMP_NEED"].ToString(),
                            ALARM_HS_TEMP_NEED = row["ALARM_HS_TEMP_NEED"].ToString(),
                            ALARM_LDI_MAX_NEED = row["ALARM_LDI_MAX_NEED"].ToString(),
                            ALARM_CAV_TEMP_NEED = row["ALARM_CAV_TEMP_NEED"].ToString(),
                            ALARM_ACC_TEMP_NEED = row["ALARM_ACC_TEMP_NEED"].ToString(),
                            TEMP_CRITERIA_OUTPUT_SPLICE_POINT_MIN = row["TEMP_CRITERIA_OUTPUT_SPLICE_POINT_MIN"].ToString(),
                            TEMP_OUTPUT_SPLICE_QBH_POINT_MIN = row["TEMP_OUTPUT_SPLICE_QBH_POINT_MIN"].ToString(),
                            TEMP_CRITERIA_OUTPUT_SPLICE_POINT_MAX = row["TEMP_CRITERIA_OUTPUT_SPLICE_POINT_MAX"].ToString(),
                            TEMP_OUTPUT_SPLICE_QBH_POINT_MAX = row["TEMP_OUTPUT_SPLICE_QBH_POINT_MAX"].ToString(),
                            MONITOR_CAV_OUT_SPEC_NEED = row["MONITOR_CAV_OUT_SPEC_NEED"].ToString(),
                            MONITOR_CAV_OUT_MIN = row["MONITOR_CAV_OUT_MIN"].ToString(),
                            MONITOR_CAV_OUT_MAX = row["MONITOR_CAV_OUT_MAX"].ToString(),
                            MONITOR_REF_FUSE_SPEC_NEED = row["MONITOR_REF_FUSE_SPEC_NEED"].ToString(),
                            MONITOR_REF_FUSE_MIN = row["MONITOR_REF_FUSE_MIN"].ToString(),
                            MONITOR_REF_FUSE_MAX = row["MONITOR_REF_FUSE_MAX"].ToString(),
                            MONITOR_LDI_SPEC_NEED = row["MONITOR_LDI_SPEC_NEED"].ToString(),
                            MONITOR_LDI_MIN = row["MONITOR_LDI_MIN"].ToString(),
                            MONITOR_LDI_MAX = row["MONITOR_LDI_MAX"].ToString(),
                            MONITOR_REF_TEMP_SPEC_NEED = row["MONITOR_REF_TEMP_SPEC_NEED"].ToString(),
                            MONITOR_REF_TEMP_MIN = row["MONITOR_REF_TEMP_MIN"].ToString(),
                            MONITOR_REF_TEMP_MAX = row["MONITOR_REF_TEMP_MAX"].ToString(),
                            MONITOR_FET_TEMP_SPEC_NEED = row["MONITOR_FET_TEMP_SPEC_NEED"].ToString(),
                            MONITOR_FET_TEMP_MIN = row["MONITOR_FET_TEMP_MIN"].ToString(),
                            MONITOR_FET_TEMP_MAX = row["MONITOR_FET_TEMP_MAX"].ToString(),
                            MONITOR_HS_TEMP_SPEC_NEED = row["MONITOR_HS_TEMP_SPEC_NEED"].ToString(),
                            MONITOR_HS_TEMP_MIN = row["MONITOR_HS_TEMP_MIN"].ToString(),
                            MONITOR_HS_TEMP_MAX = row["MONITOR_HS_TEMP_MAX"].ToString(),
                            MONITOR_CAV_TEMP1_SPEC_NEED = row["MONITOR_CAV_TEMP1_SPEC_NEED"].ToString(),
                            MONITOR_CAV_TEMP1_MIN = row["MONITOR_CAV_TEMP1_MIN"].ToString(),
                            MONITOR_CAV_TEMP1_MAX = row["MONITOR_CAV_TEMP1_MAX"].ToString(),
                            MONITOR_CAV_TEMP2_SPEC_NEED = row["MONITOR_CAV_TEMP2_SPEC_NEED"].ToString(),
                            MONITOR_CAV_TEMP2_MIN = row["MONITOR_CAV_TEMP2_MIN"].ToString(),
                            MONITOR_CAV_TEMP2_MAX = row["MONITOR_CAV_TEMP2_MAX"].ToString(),
                            MONITOR_CAV_TEMP3_SPEC_NEED = row["MONITOR_CAV_TEMP3_SPEC_NEED"].ToString(),
                            MONITOR_CAV_TEMP3_MIN = row["MONITOR_CAV_TEMP3_MIN"].ToString(),
                            MONITOR_CAV_TEMP3_MAX = row["MONITOR_CAV_TEMP3_MAX"].ToString(),
                            MONITOR_ACC_TEMP_SPEC_NEED = row["MONITOR_ACC_TEMP_SPEC_NEED"].ToString(),
                            MONITOR_ACC_TEMP_MIN = row["MONITOR_ACC_TEMP_MIN"].ToString(),
                            MONITOR_ACC_TEMP_MAX = row["MONITOR_ACC_TEMP_MAX"].ToString(),

                        };

                        listItem.Add(productProperty);
                    }
                }
                else
                {
                    MessageBox.Show(_resultData.MessageOnDb, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listItem;
        }

        public bool Update(FleInitialInspectionSettingProperty dataItem)
        {
            bool result = true;
            try
            {
                _resultData = _model.Update(dataItem);
                if (_resultData.StatusOnDb == false)
                {
                    MessageBox.Show(_resultData.MessageOnDb, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            return result;
        }

    }
}