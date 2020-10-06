using BusinessData.Property;
using FleInitialInspectionManagement.Models;
using FleInitialInspectionManagement.Property;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace FleInitialInspectionManagement.Controller
{
    public class FleInitialInspectionSettingDetailController
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        FleInitialInspectionSettingDetailModels _model = new FleInitialInspectionSettingDetailModels();

        public bool Insert(FleInitialInspectionSettingDetailProperty dataItem)
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



        public FleInitialInspectionSettingDetailProperty SearchMaxStep(FleInitialInspectionSettingDetailProperty dataItem)
        {
            FleInitialInspectionSettingDetailProperty _property = null;
            try
            {
                _resultData = _model.SearchMaxStep(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        _property = new FleInitialInspectionSettingDetailProperty
                        {
                            STEP_NUMBER = _resultData.ResultOnDb.Rows[0]["STEP_NUMBER"].ToString(),
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
        public List<FleInitialInspectionSettingDetailProperty> SearchByPurchase(FleInitialInspectionSettingDetailProperty dataItem)
        {
            List<FleInitialInspectionSettingDetailProperty> listItem = new List<FleInitialInspectionSettingDetailProperty>();
            try
            {
                _resultData = _model.SearchByPurchase(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    foreach (DataRow row in _resultData.ResultOnDb.Rows)
                    {
                        FleInitialInspectionSettingDetailProperty productProperty = new FleInitialInspectionSettingDetailProperty
                        {
                            ID = row["ID"].ToString(),
                            PURCHASE_NO = row["PURCHASE_NO"].ToString(),
                            STEP_NUMBER = row["STEP_NUMBER"].ToString(),
                            TARGET_NAME = row["TARGET_NAME"].ToString(),
                            TARGET_VALUE = row["TARGET_VALUE"].ToString(),
                            SRS_NEED = row["SRS_NEED"].ToString(),
                            SRS_NONE_SPEC = row["SRS_NONE_SPEC"].ToString(),
                            SRS_MIN = row["SRS_MIN"].ToString(),
                            SRS_MAX = row["SRS_MAX"].ToString(),
                            TEMP_FW_PUMP_NEED = row["TEMP_FW_PUMP_NEED"].ToString(),
                            TEMP_FW_PUMP_NONE_SPEC = row["TEMP_FW_PUMP_NONE_SPEC"].ToString(),
                            TEMP_FW_PUMP_MIN = row["TEMP_FW_PUMP_MIN"].ToString(),
                            TEMP_FW_PUMP_MAX = row["TEMP_FW_PUMP_MAX"].ToString(),
                            TEMP_BW_PUMP_NEED = row["TEMP_BW_PUMP_NEED"].ToString(),
                            TEMP_BW_PUMP_NONE_SPEC = row["TEMP_BW_PUMP_NONE_SPEC"].ToString(),
                            TEMP_BW_PUMP_MIN = row["TEMP_BW_PUMP_MIN"].ToString(),
                            TEMP_BW_PUMP_MAX = row["TEMP_BW_PUMP_MAX"].ToString(),
                            TEMP_FW_TFB_NEED = row["TEMP_FW_TFB_NEED"].ToString(),
                            TEMP_FW_TFB_NONE_SPEC = row["TEMP_FW_TFB_NONE_SPEC"].ToString(),
                            TEMP_FW_TFB_MIN = row["TEMP_FW_TFB_MIN"].ToString(),
                            TEMP_FW_TFB_MAX = row["TEMP_FW_TFB_MAX"].ToString(),
                            TEMP_BW_TFB_NEED = row["TEMP_BW_TFB_NEED"].ToString(),
                            TEMP_BW_TFB_NONE_SPEC = row["TEMP_BW_TFB_NONE_SPEC"].ToString(),
                            TEMP_BW_TFB_MIN = row["TEMP_BW_TFB_MIN"].ToString(),
                            TEMP_BW_TFB_MAX = row["TEMP_BW_TFB_MAX"].ToString(),
                            TEMP_FW_SPLICE_NEED = row["TEMP_FW_SPLICE_NEED"].ToString(),
                            TEMP_FW_SPLICE_NONE_SPEC = row["TEMP_FW_SPLICE_NONE_SPEC"].ToString(),
                            TEMP_FW_SPLICE_MIN = row["TEMP_FW_SPLICE_MIN"].ToString(),
                            TEMP_FW_SPLICE_MAX = row["TEMP_FW_SPLICE_MAX"].ToString(),
                            TEMP_BW_SPLICE_NEED = row["TEMP_BW_SPLICE_NEED"].ToString(),
                            TEMP_BW_SPLICE_NONE_SPEC = row["TEMP_BW_SPLICE_NONE_SPEC"].ToString(),
                            TEMP_BW_SPLICE_MIN = row["TEMP_BW_SPLICE_MIN"].ToString(),
                            TEMP_BW_SPLICE_MAX = row["TEMP_BW_SPLICE_MAX"].ToString(),
                            TEMP_ATTN_NEED = row["TEMP_ATTN_NEED"].ToString(),
                            TEMP_ATTN_NONE_SPEC = row["TEMP_ATTN_NONE_SPEC"].ToString(),
                            TEMP_ATTN_MIN = row["TEMP_ATTN_MIN"].ToString(),
                            TEMP_ATTN_MAX = row["TEMP_ATTN_MAX"].ToString(),
                            TEMP_REF_SPICE_NEED = row["TEMP_REF_SPICE_NEED"].ToString(),
                            TEMP_REF_SPICE_NONE_SPEC = row["TEMP_REF_SPICE_NONE_SPEC"].ToString(),
                            TEMP_REF_SPICE_MIN = row["TEMP_REF_SPICE_MIN"].ToString(),
                            TEMP_REF_SPICE_MAX = row["TEMP_REF_SPICE_MAX"].ToString(),
                            TEMP_OUTPUT_FIBER_NEED = row["TEMP_OUTPUT_FIBER_NEED"].ToString(),
                            TEMP_OUTPUT_FIBER_NONE_SPEC = row["TEMP_OUTPUT_FIBER_NONE_SPEC"].ToString(),
                            TEMP_OUTPUT_FIBER_MIN = row["TEMP_OUTPUT_FIBER_MIN"].ToString(),
                            TEMP_OUTPUT_FIBER_MAX = row["TEMP_OUTPUT_FIBER_MAX"].ToString(),
                            TEMP_FLE_REAR_FIBER_NEED = row["TEMP_FLE_REAR_FIBER_NEED"].ToString(),
                            TEMP_FLE_REAR_FIBER_NONE_SPEC = row["TEMP_FLE_REAR_FIBER_NONE_SPEC"].ToString(),
                            TEMP_FLE_REAR_FIBER_MIN = row["TEMP_FLE_REAR_FIBER_MIN"].ToString(),
                            TEMP_FLE_REAR_FIBER_MAX = row["TEMP_FLE_REAR_FIBER_MAX"].ToString(),
                            TEMP_OUTPUT_SPLICE_POINT_NEED = row["TEMP_OUTPUT_SPLICE_POINT_NEED"].ToString(),
                            TEMP_OUTPUT_SPLICE_POINT_NONE_SPEC = row["TEMP_OUTPUT_SPLICE_POINT_NONE_SPEC"].ToString(),
                            TEMP_OUTPUT_SPLICE_POINT_MIN = row["TEMP_OUTPUT_SPLICE_POINT_MIN"].ToString(),
                            TEMP_OUTPUT_SPLICE_POINT_MAX = row["TEMP_OUTPUT_SPLICE_POINT_MAX"].ToString(),
                            TEMP_OUTPUT_SPLICE_QBH_POINT_NEED = row["TEMP_OUTPUT_SPLICE_QBH_POINT_NEED"].ToString(),
                            TEMP_OUTPUT_SPLICE_QBH_POINT_NONE_SPEC = row["TEMP_OUTPUT_SPLICE_QBH_POINT_NONE_SPEC"].ToString(),
                            TEMP_OUTPUT_SPLICE_QBH_POINT_MIN = row["TEMP_OUTPUT_SPLICE_QBH_POINT_MIN"].ToString(),
                            TEMP_OUTPUT_SPLICE_QBH_POINT_MAX = row["TEMP_OUTPUT_SPLICE_QBH_POINT_MAX"].ToString(),
                            ALARM_REF_FUSE_NEED = row["ALARM_REF_FUSE_NEED"].ToString(),
                            ALARM_REF_FUSE_NONE_SPEC = row["ALARM_REF_FUSE_NONE_SPEC"].ToString(),
                            ALARM_REF_TEMP_NEED = row["ALARM_REF_TEMP_NEED"].ToString(),
                            ALARM_REF_TEMP_NONE_SPEC = row["ALARM_REF_TEMP_NONE_SPEC"].ToString(),
                            ALARM_FET_TEMP_NEED = row["ALARM_FET_TEMP_NEED"].ToString(),
                            ALARM_FET_TEMP_NONE_SPEC = row["ALARM_FET_TEMP_NONE_SPEC"].ToString(),
                            ALARM_HS_TEMP_NEED = row["ALARM_HS_TEMP_NEED"].ToString(),
                            ALARM_HS_TEMP_NONE_SPEC = row["ALARM_HS_TEMP_NONE_SPEC"].ToString(),
                            ALARM_LDI_MAX_NEED = row["ALARM_LDI_MAX_NEED"].ToString(),
                            ALARM_LDI_MAX_NONE_SPEC = row["ALARM_LDI_MAX_NONE_SPEC"].ToString(),
                            ALARM_CAV_TEMP_NEED = row["ALARM_CAV_TEMP_NEED"].ToString(),
                            ALARM_CAV_TEMP_NONE_SPEC = row["ALARM_CAV_TEMP_NONE_SPEC"].ToString(),
                            ALARM_ACC_TEMP_NEED = row["ALARM_ACC_TEMP_NEED"].ToString(),
                            ALARM_ACC_TEMP_NONE_SPEC = row["ALARM_ACC_TEMP_NONE_SPEC"].ToString(),
                            MONITOR_CAV_OUT_NEED = row["MONITOR_CAV_OUT_NEED"].ToString(),
                            MONITOR_CAV_OUT_NONE_SPEC = row["MONITOR_CAV_OUT_NONE_SPEC"].ToString(),
                            MONITOR_CAV_OUT_MIN = row["MONITOR_CAV_OUT_MIN"].ToString(),
                            MONITOR_CAV_OUT_MAX = row["MONITOR_CAV_OUT_MAX"].ToString(),
                            MONITOR_REF_FUSE_NEED = row["MONITOR_REF_FUSE_NEED"].ToString(),
                            MONITOR_REF_FUSE_NONE_SPEC = row["MONITOR_REF_FUSE_NONE_SPEC"].ToString(),
                            MONITOR_REF_FUSE_MIN = row["MONITOR_REF_FUSE_MIN"].ToString(),
                            MONITOR_REF_FUSE_MAX = row["MONITOR_REF_FUSE_MAX"].ToString(),
                            MONITOR_LDI_NEED = row["MONITOR_LDI_NEED"].ToString(),
                            MONITOR_LDI_NONE_SPEC = row["MONITOR_LDI_NONE_SPEC"].ToString(),
                            MONITOR_LDI_MIN = row["MONITOR_LDI_MIN"].ToString(),
                            MONITOR_LDI_MAX = row["MONITOR_LDI_MAX"].ToString(),
                            MONITOR_REF_TEMP_NEED = row["MONITOR_REF_TEMP_NEED"].ToString(),
                            MONITOR_REF_TEMP_NONE_SPEC = row["MONITOR_REF_TEMP_NONE_SPEC"].ToString(),
                            MONITOR_REF_TEMP_MIN = row["MONITOR_REF_TEMP_MIN"].ToString(),
                            MONITOR_REF_TEMP_MAX = row["MONITOR_REF_TEMP_MAX"].ToString(),
                            MONITOR_FET_TEMP_NEED = row["MONITOR_FET_TEMP_NEED"].ToString(),
                            MONITOR_FET_TEMP_NONE_SPEC = row["MONITOR_FET_TEMP_NONE_SPEC"].ToString(),
                            MONITOR_FET_TEMP_MIN = row["MONITOR_FET_TEMP_MIN"].ToString(),
                            MONITOR_FET_TEMP_MAX = row["MONITOR_FET_TEMP_MAX"].ToString(),
                            MONITOR_HS_TEMP_NEED = row["MONITOR_HS_TEMP_NEED"].ToString(),
                            MONITOR_HS_TEMP_NONE_SPEC = row["MONITOR_HS_TEMP_NONE_SPEC"].ToString(),
                            MONITOR_HS_TEMP_MIN = row["MONITOR_HS_TEMP_MIN"].ToString(),
                            MONITOR_HS_TEMP_MAX = row["MONITOR_HS_TEMP_MAX"].ToString(),
                            MONITOR_CAV1_TEMP_NEED = row["MONITOR_CAV1_TEMP_NEED"].ToString(),
                            MONITOR_CAV1_TEMP_NONE_SPEC = row["MONITOR_CAV1_TEMP_NONE_SPEC"].ToString(),
                            MONITOR_CAV1_TEMP_MIN = row["MONITOR_CAV1_TEMP_MIN"].ToString(),
                            MONITOR_CAV1_TEMP_MAX = row["MONITOR_CAV1_TEMP_MAX"].ToString(),
                            MONITOR_CAV2_TEMP_NEED = row["MONITOR_CAV2_TEMP_NEED"].ToString(),
                            MONITOR_CAV2_TEMP_NONE_SPEC = row["MONITOR_CAV2_TEMP_NONE_SPEC"].ToString(),
                            MONITOR_CAV2_TEMP_MIN = row["MONITOR_CAV2_TEMP_MIN"].ToString(),
                            MONITOR_CAV2_TEMP_MAX = row["MONITOR_CAV2_TEMP_MAX"].ToString(),
                            MONITOR_CAV3_TEMP_NEED = row["MONITOR_CAV3_TEMP_NEED"].ToString(),
                            MONITOR_CAV3_TEMP_NONE_SPEC = row["MONITOR_CAV3_TEMP_NONE_SPEC"].ToString(),
                            MONITOR_CAV3_TEMP_MIN = row["MONITOR_CAV3_TEMP_MIN"].ToString(),
                            MONITOR_CAV3_TEMP_MAX = row["MONITOR_CAV3_TEMP_MAX"].ToString(),
                            MONITOR_ACC_TEMP_NEED = row["MONITOR_ACC_TEMP_NEED"].ToString(),
                            MONITOR_ACC_TEMP_NONE_SPEC = row["MONITOR_ACC_TEMP_NONE_SPEC"].ToString(),
                            MONITOR_ACC_TEMP_MIN = row["MONITOR_ACC_TEMP_MIN"].ToString(),
                            MONITOR_ACC_TEMP_MAX = row["MONITOR_ACC_TEMP_MAX"].ToString(),
                            INUSE = row["INUSE"].ToString(),
                            IP_ADDRESS = row["IP_ADDRESS"].ToString(),
                            NAME_ADDRESS = row["NAME_ADDRESS"].ToString(),
                            CREATE_USER = row["CREATE_USER"].ToString(),
                            CREATE_DATE = row["CREATE_DATE"].ToString(),
                            LAST_USER = row["LAST_USER"].ToString(),
                            LAST_DATE = row["LAST_DATE"].ToString(),
                            DESCRIPTION = row["DESCRIPTION"].ToString(),
                            LD_CURRENT_NEED = row["LD_CURRENT_NEED"].ToString(),
                            LD_CURRENT_NONE_SPEC = row["LD_CURRENT_NONE_SPEC"].ToString(),
                            LD_CURRENT_MIN = row["LD_CURRENT_MIN"].ToString(),
                            LD_CURRENT_MAX = row["LD_CURRENT_MAX"].ToString(),


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

        public bool DeleteById(FleInitialInspectionSettingDetailProperty dataItem)
        {
            bool result = true;
            try
            {
                _resultData = _model.DeleteById(dataItem);
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