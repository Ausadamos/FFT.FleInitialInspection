using FleInitialInspectionManagement.Property;

namespace FleInitialInspectionManagement.SQLFactory
{
    public class FleInitialInspectionSettingDetailSQLFactory
    {

        string tableName = TableName.DB_FLE_INITIAL_INSPECTION_SETTING_DETAIL;

        public string Delete(FleInitialInspectionSettingDetailProperty dataItem)
        {
            string sql = @" UPDATE tableName SET INUSE = 0 
                            , LAST_USER = 'dataItem.LAST_USER' 
                            , LAST_DATE = NOW()
                             where PURCHASE_NO = 'dataItem.PURCHASE_NO'";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.PURCHASE_NO", dataItem.PURCHASE_NO);
            sql = sql.Replace("dataItem.LAST_USER", dataItem.LAST_USER);
            return sql;

        }

        public string DeleteById(FleInitialInspectionSettingDetailProperty dataItem)
        {
            string sql = @" UPDATE tableName SET INUSE = 0 
                            , LAST_USER = 'dataItem.LAST_USER' 
                            , LAST_DATE = NOW()
                             where ID = 'dataItem.ID'";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.ID", dataItem.ID);
            sql = sql.Replace("dataItem.LAST_USER", dataItem.LAST_USER);
            return sql;

        }



        public string Insert(FleInitialInspectionSettingDetailProperty dataItem)
        {
            string sql = @"INSERT INTO tableName
                                        (
                                              ID
                                            , PURCHASE_NO
                                            , STEP_NUMBER
                                            , TARGET_NAME
                                            , TARGET_VALUE
                                            , SRS_NEED
                                            , SRS_NONE_SPEC
                                            , SRS_MIN
                                            , SRS_MAX
                                            , TEMP_FW_PUMP_NEED
                                            , TEMP_FW_PUMP_NONE_SPEC
                                            , TEMP_FW_PUMP_MIN
                                            , TEMP_FW_PUMP_MAX
                                            , TEMP_BW_PUMP_NEED
                                            , TEMP_BW_PUMP_NONE_SPEC
                                            , TEMP_BW_PUMP_MIN
                                            , TEMP_BW_PUMP_MAX
                                            , TEMP_FW_TFB_NEED
                                            , TEMP_FW_TFB_NONE_SPEC
                                            , TEMP_FW_TFB_MIN
                                            , TEMP_FW_TFB_MAX
                                            , TEMP_BW_TFB_NEED
                                            , TEMP_BW_TFB_NONE_SPEC
                                            , TEMP_BW_TFB_MIN
                                            , TEMP_BW_TFB_MAX
                                            , TEMP_FW_SPLICE_NEED
                                            , TEMP_FW_SPLICE_NONE_SPEC
                                            , TEMP_FW_SPLICE_MIN
                                            , TEMP_FW_SPLICE_MAX
                                            , TEMP_BW_SPLICE_NEED
                                            , TEMP_BW_SPLICE_NONE_SPEC
                                            , TEMP_BW_SPLICE_MIN
                                            , TEMP_BW_SPLICE_MAX
                                            , TEMP_ATTN_NEED
                                            , TEMP_ATTN_NONE_SPEC
                                            , TEMP_ATTN_MIN
                                            , TEMP_ATTN_MAX
                                            , TEMP_REF_SPICE_NEED
                                            , TEMP_REF_SPICE_NONE_SPEC
                                            , TEMP_REF_SPICE_MIN
                                            , TEMP_REF_SPICE_MAX
                                            , TEMP_OUTPUT_FIBER_NEED
                                            , TEMP_OUTPUT_FIBER_NONE_SPEC
                                            , TEMP_OUTPUT_FIBER_MIN
                                            , TEMP_OUTPUT_FIBER_MAX
                                            , TEMP_FLE_REAR_FIBER_NEED
                                            , TEMP_FLE_REAR_FIBER_NONE_SPEC
                                            , TEMP_FLE_REAR_FIBER_MIN
                                            , TEMP_FLE_REAR_FIBER_MAX
                                            , TEMP_OUTPUT_SPLICE_POINT_NEED
                                            , TEMP_OUTPUT_SPLICE_POINT_NONE_SPEC
                                            , TEMP_OUTPUT_SPLICE_POINT_MIN
                                            , TEMP_OUTPUT_SPLICE_POINT_MAX
                                            , TEMP_OUTPUT_SPLICE_QBH_POINT_NEED
                                            , TEMP_OUTPUT_SPLICE_QBH_POINT_NONE_SPEC
                                            , TEMP_OUTPUT_SPLICE_QBH_POINT_MIN
                                            , TEMP_OUTPUT_SPLICE_QBH_POINT_MAX
                                            , ALARM_REF_FUSE_NEED
                                            , ALARM_REF_FUSE_NONE_SPEC
                                            , ALARM_REF_TEMP_NEED
                                            , ALARM_REF_TEMP_NONE_SPEC
                                            , ALARM_FET_TEMP_NEED
                                            , ALARM_FET_TEMP_NONE_SPEC
                                            , ALARM_HS_TEMP_NEED
                                            , ALARM_HS_TEMP_NONE_SPEC
                                            , ALARM_LDI_MAX_NEED
                                            , ALARM_LDI_MAX_NONE_SPEC
                                            , ALARM_CAV_TEMP_NEED
                                            , ALARM_CAV_TEMP_NONE_SPEC
                                            , ALARM_ACC_TEMP_NEED
                                            , ALARM_ACC_TEMP_NONE_SPEC
                                            , MONITOR_CAV_OUT_NEED
                                            , MONITOR_CAV_OUT_NONE_SPEC
                                            , MONITOR_CAV_OUT_MIN
                                            , MONITOR_CAV_OUT_MAX
                                            , MONITOR_REF_FUSE_NEED
                                            , MONITOR_REF_FUSE_NONE_SPEC
                                            , MONITOR_REF_FUSE_MIN
                                            , MONITOR_REF_FUSE_MAX
                                            , MONITOR_LDI_NEED
                                            , MONITOR_LDI_NONE_SPEC
                                            , MONITOR_LDI_MIN
                                            , MONITOR_LDI_MAX
                                            , MONITOR_REF_TEMP_NEED
                                            , MONITOR_REF_TEMP_NONE_SPEC
                                            , MONITOR_REF_TEMP_MIN
                                            , MONITOR_REF_TEMP_MAX
                                            , MONITOR_FET_TEMP_NEED
                                            , MONITOR_FET_TEMP_NONE_SPEC
                                            , MONITOR_FET_TEMP_MIN
                                            , MONITOR_FET_TEMP_MAX
                                            , MONITOR_HS_TEMP_NEED
                                            , MONITOR_HS_TEMP_NONE_SPEC
                                            , MONITOR_HS_TEMP_MIN
                                            , MONITOR_HS_TEMP_MAX
                                            , MONITOR_CAV1_TEMP_NEED
                                            , MONITOR_CAV1_TEMP_NONE_SPEC
                                            , MONITOR_CAV1_TEMP_MIN
                                            , MONITOR_CAV1_TEMP_MAX
                                            , MONITOR_CAV2_TEMP_NEED
                                            , MONITOR_CAV2_TEMP_NONE_SPEC
                                            , MONITOR_CAV2_TEMP_MIN
                                            , MONITOR_CAV2_TEMP_MAX
                                            , MONITOR_CAV3_TEMP_NEED
                                            , MONITOR_CAV3_TEMP_NONE_SPEC
                                            , MONITOR_CAV3_TEMP_MIN
                                            , MONITOR_CAV3_TEMP_MAX
                                            , MONITOR_ACC_TEMP_NEED
                                            , MONITOR_ACC_TEMP_NONE_SPEC
                                            , MONITOR_ACC_TEMP_MIN
                                            , MONITOR_ACC_TEMP_MAX
                                            , INUSE
                                            , IP_ADDRESS
                                            , NAME_ADDRESS
                                            , CREATE_USER
                                            , DESCRIPTION
                                            , LD_CURRENT_NEED
                                            , LD_CURRENT_NONE_SPEC
                                            , LD_CURRENT_MIN
                                            , LD_CURRENT_MAX

                                        )
                                        (
                                          SELECT 1 + coalesce((SELECT max(Id) FROM tableName), 0) 
                                        , 'dataItem.PURCHASE_NO'
                                        , 'dataItem.STEP_NUMBER'
                                        , 'dataItem.TARGET_NAME'
                                        , 'dataItem.TARGET_VALUE'
                                        , 'dataItem.SRS_NEED'
                                        , 'dataItem.SRS_NONE_SPEC'
                                        , 'dataItem.SRS_MIN'
                                        , 'dataItem.SRS_MAX'
                                        , 'dataItem.TEMP_FW_PUMP_NEED'
                                        , 'dataItem.TEMP_FW_PUMP_NONE_SPEC'
                                        , 'dataItem.TEMP_FW_PUMP_MIN'
                                        , 'dataItem.TEMP_FW_PUMP_MAX'
                                        , 'dataItem.TEMP_BW_PUMP_NEED'
                                        , 'dataItem.TEMP_BW_PUMP_NONE_SPEC'
                                        , 'dataItem.TEMP_BW_PUMP_MIN'
                                        , 'dataItem.TEMP_BW_PUMP_MAX'
                                        , 'dataItem.TEMP_FW_TFB_NEED'
                                        , 'dataItem.TEMP_FW_TFB_NONE_SPEC'
                                        , 'dataItem.TEMP_FW_TFB_MIN'
                                        , 'dataItem.TEMP_FW_TFB_MAX'
                                        , 'dataItem.TEMP_BW_TFB_NEED'
                                        , 'dataItem.TEMP_BW_TFB_NONE_SPEC'
                                        , 'dataItem.TEMP_BW_TFB_MIN'
                                        , 'dataItem.TEMP_BW_TFB_MAX'
                                        , 'dataItem.TEMP_FW_SPLICE_NEED'
                                        , 'dataItem.TEMP_FW_SPLICE_NONE_SPEC'
                                        , 'dataItem.TEMP_FW_SPLICE_MIN'
                                        , 'dataItem.TEMP_FW_SPLICE_MAX'
                                        , 'dataItem.TEMP_BW_SPLICE_NEED'
                                        , 'dataItem.TEMP_BW_SPLICE_NONE_SPEC'
                                        , 'dataItem.TEMP_BW_SPLICE_MIN'
                                        , 'dataItem.TEMP_BW_SPLICE_MAX'
                                        , 'dataItem.TEMP_ATTN_NEED'
                                        , 'dataItem.TEMP_ATTN_NONE_SPEC'
                                        , 'dataItem.TEMP_ATTN_MIN'
                                        , 'dataItem.TEMP_ATTN_MAX'
                                        , 'dataItem.TEMP_REF_SPICE_NEED'
                                        , 'dataItem.TEMP_REF_SPICE_NONE_SPEC'
                                        , 'dataItem.TEMP_REF_SPICE_MIN'
                                        , 'dataItem.TEMP_REF_SPICE_MAX'
                                        , 'dataItem.TEMP_OUTPUT_FIBER_NEED'
                                        , 'dataItem.TEMP_OUTPUT_FIBER_NONE_SPEC'
                                        , 'dataItem.TEMP_OUTPUT_FIBER_MIN'
                                        , 'dataItem.TEMP_OUTPUT_FIBER_MAX'
                                        , 'dataItem.TEMP_FLE_REAR_FIBER_NEED'
                                        , 'dataItem.TEMP_FLE_REAR_FIBER_NONE_SPEC'
                                        , 'dataItem.TEMP_FLE_REAR_FIBER_MIN'
                                        , 'dataItem.TEMP_FLE_REAR_FIBER_MAX'
                                        , 'dataItem.TEMP_OUTPUT_SPLICE_POINT_NEED'
                                        , 'dataItem.TEMP_OUTPUT_SPLICE_POINT_NONE_SPEC'
                                        , 'dataItem.TEMP_OUTPUT_SPLICE_POINT_MIN'
                                        , 'dataItem.TEMP_OUTPUT_SPLICE_POINT_MAX'
                                        , 'dataItem.TEMP_OUTPUT_SPLICE_QBH_POINT_NEED'
                                        , 'dataItem.TEMP_OUTPUT_SPLICE_QBH_POINT_NONE_SPEC'
                                        , 'dataItem.TEMP_OUTPUT_SPLICE_QBH_POINT_MIN'
                                        , 'dataItem.TEMP_OUTPUT_SPLICE_QBH_POINT_MAX'
                                        , 'dataItem.ALARM_REF_FUSE_NEED'
                                        , 'dataItem.ALARM_REF_FUSE_NONE_SPEC'
                                        , 'dataItem.ALARM_REF_TEMP_NEED'
                                        , 'dataItem.ALARM_REF_TEMP_NONE_SPEC'
                                        , 'dataItem.ALARM_FET_TEMP_NEED'
                                        , 'dataItem.ALARM_FET_TEMP_NONE_SPEC'
                                        , 'dataItem.ALARM_HS_TEMP_NEED'
                                        , 'dataItem.ALARM_HS_TEMP_NONE_SPEC'
                                        , 'dataItem.ALARM_LDI_MAX_NEED'
                                        , 'dataItem.ALARM_LDI_MAX_NONE_SPEC'
                                        , 'dataItem.ALARM_CAV_TEMP_NEED'
                                        , 'dataItem.ALARM_CAV_TEMP_NONE_SPEC'
                                        , 'dataItem.ALARM_ACC_TEMP_NEED'
                                        , 'dataItem.ALARM_ACC_TEMP_NONE_SPEC'
                                        , 'dataItem.MONITOR_CAV_OUT_NEED'
                                        , 'dataItem.MONITOR_CAV_OUT_NONE_SPEC'
                                        , 'dataItem.MONITOR_CAV_OUT_MIN'
                                        , 'dataItem.MONITOR_CAV_OUT_MAX'
                                        , 'dataItem.MONITOR_REF_FUSE_NEED'
                                        , 'dataItem.MONITOR_REF_FUSE_NONE_SPEC'
                                        , 'dataItem.MONITOR_REF_FUSE_MIN'
                                        , 'dataItem.MONITOR_REF_FUSE_MAX'
                                        , 'dataItem.MONITOR_LDI_NEED'
                                        , 'dataItem.MONITOR_LDI_NONE_SPEC'
                                        , 'dataItem.MONITOR_LDI_MIN'
                                        , 'dataItem.MONITOR_LDI_MAX'
                                        , 'dataItem.MONITOR_REF_TEMP_NEED'
                                        , 'dataItem.MONITOR_REF_TEMP_NONE_SPEC'
                                        , 'dataItem.MONITOR_REF_TEMP_MIN'
                                        , 'dataItem.MONITOR_REF_TEMP_MAX'
                                        , 'dataItem.MONITOR_FET_TEMP_NEED'
                                        , 'dataItem.MONITOR_FET_TEMP_NONE_SPEC'
                                        , 'dataItem.MONITOR_FET_TEMP_MIN'
                                        , 'dataItem.MONITOR_FET_TEMP_MAX'
                                        , 'dataItem.MONITOR_HS_TEMP_NEED'
                                        , 'dataItem.MONITOR_HS_TEMP_NONE_SPEC'
                                        , 'dataItem.MONITOR_HS_TEMP_MIN'
                                        , 'dataItem.MONITOR_HS_TEMP_MAX'
                                        , 'dataItem.MONITOR_CAV1_TEMP_NEED'
                                        , 'dataItem.MONITOR_CAV1_TEMP_NONE_SPEC'
                                        , 'dataItem.MONITOR_CAV1_TEMP_MIN'
                                        , 'dataItem.MONITOR_CAV1_TEMP_MAX'
                                        , 'dataItem.MONITOR_CAV2_TEMP_NEED'
                                        , 'dataItem.MONITOR_CAV2_TEMP_NONE_SPEC'
                                        , 'dataItem.MONITOR_CAV2_TEMP_MIN'
                                        , 'dataItem.MONITOR_CAV2_TEMP_MAX'
                                        , 'dataItem.MONITOR_CAV3_TEMP_NEED'
                                        , 'dataItem.MONITOR_CAV3_TEMP_NONE_SPEC'
                                        , 'dataItem.MONITOR_CAV3_TEMP_MIN'
                                        , 'dataItem.MONITOR_CAV3_TEMP_MAX'
                                        , 'dataItem.MONITOR_ACC_TEMP_NEED'
                                        , 'dataItem.MONITOR_ACC_TEMP_NONE_SPEC'
                                        , 'dataItem.MONITOR_ACC_TEMP_MIN'
                                        , 'dataItem.MONITOR_ACC_TEMP_MAX'
                                        , 1
                                        , 'dataItem.IP_ADDRESS'
                                        , 'dataItem.NAME_ADDRESS'
                                        , 'dataItem.CREATE_USER'
                                        , 'dataItem.DESCRIPTION'
                                        , 'dataItem.LD_CURRENT_NEED'
                                        , 'dataItem.LD_CURRENT_NONE_SPEC'
                                        , 'dataItem.LD_CURRENT_MIN'
                                        , 'dataItem.LD_CURRENT_MAX'

                                        )";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.ID", dataItem.ID);
            sql = sql.Replace("dataItem.PURCHASE_NO", dataItem.PURCHASE_NO);
            sql = sql.Replace("dataItem.STEP_NUMBER", dataItem.STEP_NUMBER);
            sql = sql.Replace("dataItem.TARGET_NAME", dataItem.TARGET_NAME);
            sql = sql.Replace("dataItem.TARGET_VALUE", dataItem.TARGET_VALUE);
            sql = sql.Replace("dataItem.SRS_NEED", dataItem.SRS_NEED);
            sql = sql.Replace("dataItem.SRS_NONE_SPEC", dataItem.SRS_NONE_SPEC);
            sql = sql.Replace("dataItem.SRS_MIN", dataItem.SRS_MIN);
            sql = sql.Replace("dataItem.SRS_MAX", dataItem.SRS_MAX);
            sql = sql.Replace("dataItem.TEMP_FW_PUMP_NEED", dataItem.TEMP_FW_PUMP_NEED);
            sql = sql.Replace("dataItem.TEMP_FW_PUMP_NONE_SPEC", dataItem.TEMP_FW_PUMP_NONE_SPEC);
            sql = sql.Replace("dataItem.TEMP_FW_PUMP_MIN", dataItem.TEMP_FW_PUMP_MIN);
            sql = sql.Replace("dataItem.TEMP_FW_PUMP_MAX", dataItem.TEMP_FW_PUMP_MAX);
            sql = sql.Replace("dataItem.TEMP_BW_PUMP_NEED", dataItem.TEMP_BW_PUMP_NEED);
            sql = sql.Replace("dataItem.TEMP_BW_PUMP_NONE_SPEC", dataItem.TEMP_BW_PUMP_NONE_SPEC);
            sql = sql.Replace("dataItem.TEMP_BW_PUMP_MIN", dataItem.TEMP_BW_PUMP_MIN);
            sql = sql.Replace("dataItem.TEMP_BW_PUMP_MAX", dataItem.TEMP_BW_PUMP_MAX);
            sql = sql.Replace("dataItem.TEMP_FW_TFB_NEED", dataItem.TEMP_FW_TFB_NEED);
            sql = sql.Replace("dataItem.TEMP_FW_TFB_NONE_SPEC", dataItem.TEMP_FW_TFB_NONE_SPEC);
            sql = sql.Replace("dataItem.TEMP_FW_TFB_MIN", dataItem.TEMP_FW_TFB_MIN);
            sql = sql.Replace("dataItem.TEMP_FW_TFB_MAX", dataItem.TEMP_FW_TFB_MAX);
            sql = sql.Replace("dataItem.TEMP_BW_TFB_NEED", dataItem.TEMP_BW_TFB_NEED);
            sql = sql.Replace("dataItem.TEMP_BW_TFB_NONE_SPEC", dataItem.TEMP_BW_TFB_NONE_SPEC);
            sql = sql.Replace("dataItem.TEMP_BW_TFB_MIN", dataItem.TEMP_BW_TFB_MIN);
            sql = sql.Replace("dataItem.TEMP_BW_TFB_MAX", dataItem.TEMP_BW_TFB_MAX);
            sql = sql.Replace("dataItem.TEMP_FW_SPLICE_NEED", dataItem.TEMP_FW_SPLICE_NEED);
            sql = sql.Replace("dataItem.TEMP_FW_SPLICE_NONE_SPEC", dataItem.TEMP_FW_SPLICE_NONE_SPEC);
            sql = sql.Replace("dataItem.TEMP_FW_SPLICE_MIN", dataItem.TEMP_FW_SPLICE_MIN);
            sql = sql.Replace("dataItem.TEMP_FW_SPLICE_MAX", dataItem.TEMP_FW_SPLICE_MAX);
            sql = sql.Replace("dataItem.TEMP_BW_SPLICE_NEED", dataItem.TEMP_BW_SPLICE_NEED);
            sql = sql.Replace("dataItem.TEMP_BW_SPLICE_NONE_SPEC", dataItem.TEMP_BW_SPLICE_NONE_SPEC);
            sql = sql.Replace("dataItem.TEMP_BW_SPLICE_MIN", dataItem.TEMP_BW_SPLICE_MIN);
            sql = sql.Replace("dataItem.TEMP_BW_SPLICE_MAX", dataItem.TEMP_BW_SPLICE_MAX);
            sql = sql.Replace("dataItem.TEMP_ATTN_NEED", dataItem.TEMP_ATTN_NEED);
            sql = sql.Replace("dataItem.TEMP_ATTN_NONE_SPEC", dataItem.TEMP_ATTN_NONE_SPEC);
            sql = sql.Replace("dataItem.TEMP_ATTN_MIN", dataItem.TEMP_ATTN_MIN);
            sql = sql.Replace("dataItem.TEMP_ATTN_MAX", dataItem.TEMP_ATTN_MAX);
            sql = sql.Replace("dataItem.TEMP_REF_SPICE_NEED", dataItem.TEMP_REF_SPICE_NEED);
            sql = sql.Replace("dataItem.TEMP_REF_SPICE_NONE_SPEC", dataItem.TEMP_REF_SPICE_NONE_SPEC);
            sql = sql.Replace("dataItem.TEMP_REF_SPICE_MIN", dataItem.TEMP_REF_SPICE_MIN);
            sql = sql.Replace("dataItem.TEMP_REF_SPICE_MAX", dataItem.TEMP_REF_SPICE_MAX);
            sql = sql.Replace("dataItem.TEMP_OUTPUT_FIBER_NEED", dataItem.TEMP_OUTPUT_FIBER_NEED);
            sql = sql.Replace("dataItem.TEMP_OUTPUT_FIBER_NONE_SPEC", dataItem.TEMP_OUTPUT_FIBER_NONE_SPEC);
            sql = sql.Replace("dataItem.TEMP_OUTPUT_FIBER_MIN", dataItem.TEMP_OUTPUT_FIBER_MIN);
            sql = sql.Replace("dataItem.TEMP_OUTPUT_FIBER_MAX", dataItem.TEMP_OUTPUT_FIBER_MAX);
            sql = sql.Replace("dataItem.TEMP_FLE_REAR_FIBER_NEED", dataItem.TEMP_FLE_REAR_FIBER_NEED);
            sql = sql.Replace("dataItem.TEMP_FLE_REAR_FIBER_NONE_SPEC", dataItem.TEMP_FLE_REAR_FIBER_NONE_SPEC);
            sql = sql.Replace("dataItem.TEMP_FLE_REAR_FIBER_MIN", dataItem.TEMP_FLE_REAR_FIBER_MIN);
            sql = sql.Replace("dataItem.TEMP_FLE_REAR_FIBER_MAX", dataItem.TEMP_FLE_REAR_FIBER_MAX);
            sql = sql.Replace("dataItem.TEMP_OUTPUT_SPLICE_POINT_NEED", dataItem.TEMP_OUTPUT_SPLICE_POINT_NEED);
            sql = sql.Replace("dataItem.TEMP_OUTPUT_SPLICE_POINT_NONE_SPEC", dataItem.TEMP_OUTPUT_SPLICE_POINT_NONE_SPEC);
            sql = sql.Replace("dataItem.TEMP_OUTPUT_SPLICE_POINT_MIN", dataItem.TEMP_OUTPUT_SPLICE_POINT_MIN);
            sql = sql.Replace("dataItem.TEMP_OUTPUT_SPLICE_POINT_MAX", dataItem.TEMP_OUTPUT_SPLICE_POINT_MAX);
            sql = sql.Replace("dataItem.TEMP_OUTPUT_SPLICE_QBH_POINT_NEED", dataItem.TEMP_OUTPUT_SPLICE_QBH_POINT_NEED);
            sql = sql.Replace("dataItem.TEMP_OUTPUT_SPLICE_QBH_POINT_NONE_SPEC", dataItem.TEMP_OUTPUT_SPLICE_QBH_POINT_NONE_SPEC);
            sql = sql.Replace("dataItem.TEMP_OUTPUT_SPLICE_QBH_POINT_MIN", dataItem.TEMP_OUTPUT_SPLICE_QBH_POINT_MIN);
            sql = sql.Replace("dataItem.TEMP_OUTPUT_SPLICE_QBH_POINT_MAX", dataItem.TEMP_OUTPUT_SPLICE_QBH_POINT_MAX);
            sql = sql.Replace("dataItem.ALARM_REF_FUSE_NEED", dataItem.ALARM_REF_FUSE_NEED);
            sql = sql.Replace("dataItem.ALARM_REF_FUSE_NONE_SPEC", dataItem.ALARM_REF_FUSE_NONE_SPEC);
            sql = sql.Replace("dataItem.ALARM_REF_TEMP_NEED", dataItem.ALARM_REF_TEMP_NEED);
            sql = sql.Replace("dataItem.ALARM_REF_TEMP_NONE_SPEC", dataItem.ALARM_REF_TEMP_NONE_SPEC);
            sql = sql.Replace("dataItem.ALARM_FET_TEMP_NEED", dataItem.ALARM_FET_TEMP_NEED);
            sql = sql.Replace("dataItem.ALARM_FET_TEMP_NONE_SPEC", dataItem.ALARM_FET_TEMP_NONE_SPEC);
            sql = sql.Replace("dataItem.ALARM_HS_TEMP_NEED", dataItem.ALARM_HS_TEMP_NEED);
            sql = sql.Replace("dataItem.ALARM_HS_TEMP_NONE_SPEC", dataItem.ALARM_HS_TEMP_NONE_SPEC);
            sql = sql.Replace("dataItem.ALARM_LDI_MAX_NEED", dataItem.ALARM_LDI_MAX_NEED);
            sql = sql.Replace("dataItem.ALARM_LDI_MAX_NONE_SPEC", dataItem.ALARM_LDI_MAX_NONE_SPEC);
            sql = sql.Replace("dataItem.ALARM_CAV_TEMP_NEED", dataItem.ALARM_CAV_TEMP_NEED);
            sql = sql.Replace("dataItem.ALARM_CAV_TEMP_NONE_SPEC", dataItem.ALARM_CAV_TEMP_NONE_SPEC);
            sql = sql.Replace("dataItem.ALARM_ACC_TEMP_NEED", dataItem.ALARM_ACC_TEMP_NEED);
            sql = sql.Replace("dataItem.ALARM_ACC_TEMP_NONE_SPEC", dataItem.ALARM_ACC_TEMP_NONE_SPEC);
            sql = sql.Replace("dataItem.MONITOR_CAV_OUT_NEED", dataItem.MONITOR_CAV_OUT_NEED);
            sql = sql.Replace("dataItem.MONITOR_CAV_OUT_NONE_SPEC", dataItem.MONITOR_CAV_OUT_NONE_SPEC);
            sql = sql.Replace("dataItem.MONITOR_CAV_OUT_MIN", dataItem.MONITOR_CAV_OUT_MIN);
            sql = sql.Replace("dataItem.MONITOR_CAV_OUT_MAX", dataItem.MONITOR_CAV_OUT_MAX);
            sql = sql.Replace("dataItem.MONITOR_REF_FUSE_NEED", dataItem.MONITOR_REF_FUSE_NEED);
            sql = sql.Replace("dataItem.MONITOR_REF_FUSE_NONE_SPEC", dataItem.MONITOR_REF_FUSE_NONE_SPEC);
            sql = sql.Replace("dataItem.MONITOR_REF_FUSE_MIN", dataItem.MONITOR_REF_FUSE_MIN);
            sql = sql.Replace("dataItem.MONITOR_REF_FUSE_MAX", dataItem.MONITOR_REF_FUSE_MAX);
            sql = sql.Replace("dataItem.MONITOR_LDI_NEED", dataItem.MONITOR_LDI_NEED);
            sql = sql.Replace("dataItem.MONITOR_LDI_NONE_SPEC", dataItem.MONITOR_LDI_NONE_SPEC);
            sql = sql.Replace("dataItem.MONITOR_LDI_MIN", dataItem.MONITOR_LDI_MIN);
            sql = sql.Replace("dataItem.MONITOR_LDI_MAX", dataItem.MONITOR_LDI_MAX);
            sql = sql.Replace("dataItem.MONITOR_REF_TEMP_NEED", dataItem.MONITOR_REF_TEMP_NEED);
            sql = sql.Replace("dataItem.MONITOR_REF_TEMP_NONE_SPEC", dataItem.MONITOR_REF_TEMP_NONE_SPEC);
            sql = sql.Replace("dataItem.MONITOR_REF_TEMP_MIN", dataItem.MONITOR_REF_TEMP_MIN);
            sql = sql.Replace("dataItem.MONITOR_REF_TEMP_MAX", dataItem.MONITOR_REF_TEMP_MAX);
            sql = sql.Replace("dataItem.MONITOR_FET_TEMP_NEED", dataItem.MONITOR_FET_TEMP_NEED);
            sql = sql.Replace("dataItem.MONITOR_FET_TEMP_NONE_SPEC", dataItem.MONITOR_FET_TEMP_NONE_SPEC);
            sql = sql.Replace("dataItem.MONITOR_FET_TEMP_MIN", dataItem.MONITOR_FET_TEMP_MIN);
            sql = sql.Replace("dataItem.MONITOR_FET_TEMP_MAX", dataItem.MONITOR_FET_TEMP_MAX);
            sql = sql.Replace("dataItem.MONITOR_HS_TEMP_NEED", dataItem.MONITOR_HS_TEMP_NEED);
            sql = sql.Replace("dataItem.MONITOR_HS_TEMP_NONE_SPEC", dataItem.MONITOR_HS_TEMP_NONE_SPEC);
            sql = sql.Replace("dataItem.MONITOR_HS_TEMP_MIN", dataItem.MONITOR_HS_TEMP_MIN);
            sql = sql.Replace("dataItem.MONITOR_HS_TEMP_MAX", dataItem.MONITOR_HS_TEMP_MAX);
            sql = sql.Replace("dataItem.MONITOR_CAV1_TEMP_NEED", dataItem.MONITOR_CAV1_TEMP_NEED);
            sql = sql.Replace("dataItem.MONITOR_CAV1_TEMP_NONE_SPEC", dataItem.MONITOR_CAV1_TEMP_NONE_SPEC);
            sql = sql.Replace("dataItem.MONITOR_CAV1_TEMP_MIN", dataItem.MONITOR_CAV1_TEMP_MIN);
            sql = sql.Replace("dataItem.MONITOR_CAV1_TEMP_MAX", dataItem.MONITOR_CAV1_TEMP_MAX);
            sql = sql.Replace("dataItem.MONITOR_CAV2_TEMP_NEED", dataItem.MONITOR_CAV2_TEMP_NEED);
            sql = sql.Replace("dataItem.MONITOR_CAV2_TEMP_NONE_SPEC", dataItem.MONITOR_CAV2_TEMP_NONE_SPEC);
            sql = sql.Replace("dataItem.MONITOR_CAV2_TEMP_MIN", dataItem.MONITOR_CAV2_TEMP_MIN);
            sql = sql.Replace("dataItem.MONITOR_CAV2_TEMP_MAX", dataItem.MONITOR_CAV2_TEMP_MAX);
            sql = sql.Replace("dataItem.MONITOR_CAV3_TEMP_NEED", dataItem.MONITOR_CAV3_TEMP_NEED);
            sql = sql.Replace("dataItem.MONITOR_CAV3_TEMP_NONE_SPEC", dataItem.MONITOR_CAV3_TEMP_NONE_SPEC);
            sql = sql.Replace("dataItem.MONITOR_CAV3_TEMP_MIN", dataItem.MONITOR_CAV3_TEMP_MIN);
            sql = sql.Replace("dataItem.MONITOR_CAV3_TEMP_MAX", dataItem.MONITOR_CAV3_TEMP_MAX);
            sql = sql.Replace("dataItem.MONITOR_ACC_TEMP_NEED", dataItem.MONITOR_ACC_TEMP_NEED);
            sql = sql.Replace("dataItem.MONITOR_ACC_TEMP_NONE_SPEC", dataItem.MONITOR_ACC_TEMP_NONE_SPEC);
            sql = sql.Replace("dataItem.MONITOR_ACC_TEMP_MIN", dataItem.MONITOR_ACC_TEMP_MIN);
            sql = sql.Replace("dataItem.MONITOR_ACC_TEMP_MAX", dataItem.MONITOR_ACC_TEMP_MAX);
            sql = sql.Replace("dataItem.INUSE", dataItem.INUSE);
            sql = sql.Replace("dataItem.IP_ADDRESS", dataItem.IP_ADDRESS);
            sql = sql.Replace("dataItem.NAME_ADDRESS", dataItem.NAME_ADDRESS);
            sql = sql.Replace("dataItem.CREATE_USER", dataItem.CREATE_USER);
            sql = sql.Replace("dataItem.CREATE_DATE", dataItem.CREATE_DATE);
            sql = sql.Replace("dataItem.LAST_USER", dataItem.LAST_USER);
            sql = sql.Replace("dataItem.LAST_DATE", dataItem.LAST_DATE);
            sql = sql.Replace("dataItem.DESCRIPTION", dataItem.DESCRIPTION);
            sql = sql.Replace("dataItem.LD_CURRENT_NEED", dataItem.LD_CURRENT_NEED);
            sql = sql.Replace("dataItem.LD_CURRENT_NONE_SPEC", dataItem.LD_CURRENT_NONE_SPEC);
            sql = sql.Replace("dataItem.LD_CURRENT_MIN", dataItem.LD_CURRENT_MIN);
            sql = sql.Replace("dataItem.LD_CURRENT_MAX", dataItem.LD_CURRENT_MAX);




            return sql;

        }

        public string Search(FleInitialInspectionSettingDetailProperty dataItem)
        {
            string sql = @"SELECT * FROM tableName 
                             where 
                             AND ID = 'dataItem.ID'";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.ID", dataItem.ID);
            return sql;
        }

        public string SearchMaxStep(FleInitialInspectionSettingDetailProperty dataItem)
        {
            string sql = @"SELECT if(max(STEP_NUMBER) is NULL , 1,max(STEP_NUMBER) +1 ) AS STEP_NUMBER FROM tableName 
                             where 
                             PURCHASE_NO = 'dataItem.PURCHASE_NO' 
                             AND INUSE = 1";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.PURCHASE_NO", dataItem.PURCHASE_NO);
            return sql;
        }



        public string Search()
        {
            string sql = @"SELECT * FROM tableName";

            sql = sql.Replace("tableName", tableName);

            return sql;
        }

        public string SearchByPurchase(FleInitialInspectionSettingDetailProperty dataItem)
        {
            string sql = @" SELECT * FROM tableName 
                            WHERE PURCHASE_NO = 'dataItem.PURCHASE_NO' AND INUSE = 1";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.PURCHASE_NO", dataItem.PURCHASE_NO);
            return sql;
        }



        public string Update(FleInitialInspectionSettingDetailProperty dataItem)
        {
            string sql = @"";
            return sql;
        }






    }
}