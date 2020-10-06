using FleInitialInspectionManagement.Property;

namespace FleInitialInspectionManagement.SQLFactory
{
    public class FleInitialInspectionSettingSQLFactory
    {

        string tableName = TableName.DB_FLE_INITIAL_INSPECTION_SETTING;

        public string Delete(FleInitialInspectionSettingProperty dataItem)
        {
            string sql = @"UPDATE tableName SET INUSE = 0 
                             where ID = 'dataItem.ID'";

            sql = sql.Replace("tableName", tableName);
            sql = sql.Replace("dataItem.ID", dataItem.ID);
            return sql;

        }

        public string Insert(FleInitialInspectionSettingProperty dataItem)
        {
            string sql = @"INSERT INTO tableName
                                        (
                                        ID
                                        , PURCHASE_NO
                                        , OPM_FLOW_MIN
                                        , OPM_FLOW_MAX
                                        , FL_FLOW_MIN
                                        , FL_FLOW_MAX
                                        , TS_TEMP_FWPUMP_MIN
                                        , TS_TEMP_FWPUMP_MAX
                                        , TS_TEMP_BWPUMP_MIN
                                        , TS_TEMP_BWPUMP_MAX
                                        , TS_TEMP_FWTFB_MIN
                                        , TS_TEMP_FWTFB_MAX
                                        , TS_TEMP_BWTFB_MIN
                                        , TS_TEMP_BWTFB_MAX
                                        , TS_TEMP_FWSPLICE_MIN
                                        , TS_TEMP_FWSPLICE_MAX
                                        , TS_TEMP_BWSPLICE_MIN
                                        , TS_TEMP_BWSPLICE_MAX
                                        , TS_TEMP_ATTN_MIN
                                        , TS_TEMP_ATTN_MAX
                                        , TS_TEMP_REFSPICE_MIN
                                        , TS_TEMP_REFSPICE_MAX
                                        , TS_TEMP_OUTPUTFIBER_MIN
                                        , TS_TEMP_OUTPUTFIBER_MAX
                                        , TS_TEMP_FLEREARFIBER_MIN
                                        , TS_TEMP_FLEREARFIBER_MAX
                                        , INUSE
                                        , IP_ADDRESS
                                        , NAME_ADDRESS
                                        , CREATE_DATE
                                        , LAST_DATE
                                        , CREATE_USER
                                        , LAST_USER
                                        , DESCRIPTION
                                        , ALARM_REF_FUSE_NEED
                                        , ALARM_REF_TEMP_NEED
                                        , ALARM_FET_TEMP_NEED
                                        , ALARM_HS_TEMP_NEED
                                        , ALARM_LDI_MAX_NEED
                                        , ALARM_CAV_TEMP_NEED
                                        , ALARM_ACC_TEMP_NEED
                                        , TEMP_CRITERIA_OUTPUT_SPLICE_POINT_MIN
                                        , TEMP_OUTPUT_SPLICE_QBH_POINT_MIN
                                        , TEMP_CRITERIA_OUTPUT_SPLICE_POINT_MAX
                                        , TEMP_OUTPUT_SPLICE_QBH_POINT_MAX
                                        , MONITOR_CAV_OUT_SPEC_NEED
                                        , MONITOR_CAV_OUT_MIN
                                        , MONITOR_CAV_OUT_MAX
                                        , MONITOR_REF_FUSE_SPEC_NEED
                                        , MONITOR_REF_FUSE_MIN
                                        , MONITOR_REF_FUSE_MAX
                                        , MONITOR_LDI_SPEC_NEED
                                        , MONITOR_LDI_MIN
                                        , MONITOR_LDI_MAX
                                        , MONITOR_REF_TEMP_SPEC_NEED
                                        , MONITOR_REF_TEMP_MIN
                                        , MONITOR_REF_TEMP_MAX
                                        , MONITOR_FET_TEMP_SPEC_NEED
                                        , MONITOR_FET_TEMP_MIN
                                        , MONITOR_FET_TEMP_MAX
                                        , MONITOR_HS_TEMP_SPEC_NEED
                                        , MONITOR_HS_TEMP_MIN
                                        , MONITOR_HS_TEMP_MAX
                                        , MONITOR_CAV_TEMP1_SPEC_NEED
                                        , MONITOR_CAV_TEMP1_MIN
                                        , MONITOR_CAV_TEMP1_MAX
                                        , MONITOR_CAV_TEMP2_SPEC_NEED
                                        , MONITOR_CAV_TEMP2_MIN
                                        , MONITOR_CAV_TEMP2_MAX
                                        , MONITOR_CAV_TEMP3_SPEC_NEED
                                        , MONITOR_CAV_TEMP3_MIN
                                        , MONITOR_CAV_TEMP3_MAX
                                        , MONITOR_ACC_TEMP_SPEC_NEED
                                        , MONITOR_ACC_TEMP_MIN
                                        , MONITOR_ACC_TEMP_MAX
                                        )
                                        (
                                          SELECT 1 + coalesce((SELECT max(Id) FROM tableName), 0) 
                                        , 'dataItem.PURCHASE_NO'
                                        , 'dataItem.OPM_FLOW_MIN'
                                        , 'dataItem.OPM_FLOW_MAX'
                                        , 'dataItem.FL_FLOW_MIN'
                                        , 'dataItem.FL_FLOW_MAX'
                                        , 'dataItem.TS_TEMP_FWPUMP_MIN'
                                        , 'dataItem.TS_TEMP_FWPUMP_MAX'
                                        , 'dataItem.TS_TEMP_BWPUMP_MIN'
                                        , 'dataItem.TS_TEMP_BWPUMP_MAX'
                                        , 'dataItem.TS_TEMP_FWTFB_MIN'
                                        , 'dataItem.TS_TEMP_FWTFB_MAX'
                                        , 'dataItem.TS_TEMP_BWTFB_MIN'
                                        , 'dataItem.TS_TEMP_BWTFB_MAX'
                                        , 'dataItem.TS_TEMP_FWSPLICE_MIN'
                                        , 'dataItem.TS_TEMP_FWSPLICE_MAX'
                                        , 'dataItem.TS_TEMP_BWSPLICE_MIN'
                                        , 'dataItem.TS_TEMP_BWSPLICE_MAX'
                                        , 'dataItem.TS_TEMP_ATTN_MIN'
                                        , 'dataItem.TS_TEMP_ATTN_MAX'
                                        , 'dataItem.TS_TEMP_REFSPICE_MIN'
                                        , 'dataItem.TS_TEMP_REFSPICE_MAX'
                                        , 'dataItem.TS_TEMP_OUTPUTFIBER_MIN'
                                        , 'dataItem.TS_TEMP_OUTPUTFIBER_MAX'
                                        , 'dataItem.TS_TEMP_FLEREARFIBER_MIN'
                                        , 'dataItem.TS_TEMP_FLEREARFIBER_MAX'
                                        , 1
                                        , 'dataItem.IP_ADDRESS'
                                        , 'dataItem.NAME_ADDRESS'
                                        , NOW()
                                        , 'dataItem.CREATE_USER'
                                        , 'dataItem.DESCRIPTION'
                                        , 'dataItem.ALARM_REF_FUSE_NEED'
                                        , 'dataItem.ALARM_REF_TEMP_NEED'
                                        , 'dataItem.ALARM_FET_TEMP_NEED'
                                        , 'dataItem.ALARM_HS_TEMP_NEED'
                                        , 'dataItem.ALARM_LDI_MAX_NEED'
                                        , 'dataItem.ALARM_CAV_TEMP_NEED'
                                        , 'dataItem.ALARM_ACC_TEMP_NEED'
                                        , 'dataItem.TEMP_CRITERIA_OUTPUT_SPLICE_POINT_MIN'
                                        , 'dataItem.TEMP_OUTPUT_SPLICE_QBH_POINT_MIN'
                                        , 'dataItem.TEMP_CRITERIA_OUTPUT_SPLICE_POINT_MAX'
                                        , 'dataItem.TEMP_OUTPUT_SPLICE_QBH_POINT_MAX'
                                        , 'dataItem.MONITOR_CAV_OUT_SPEC_NEED'
                                        , 'dataItem.MONITOR_CAV_OUT_MIN'
                                        , 'dataItem.MONITOR_CAV_OUT_MAX'
                                        , 'dataItem.MONITOR_REF_FUSE_SPEC_NEED'
                                        , 'dataItem.MONITOR_REF_FUSE_MIN'
                                        , 'dataItem.MONITOR_REF_FUSE_MAX'
                                        , 'dataItem.MONITOR_LDI_SPEC_NEED'
                                        , 'dataItem.MONITOR_LDI_MIN'
                                        , 'dataItem.MONITOR_LDI_MAX'
                                        , 'dataItem.MONITOR_REF_TEMP_SPEC_NEED'
                                        , 'dataItem.MONITOR_REF_TEMP_MIN'
                                        , 'dataItem.MONITOR_REF_TEMP_MAX'
                                        , 'dataItem.MONITOR_FET_TEMP_SPEC_NEED'
                                        , 'dataItem.MONITOR_FET_TEMP_MIN'
                                        , 'dataItem.MONITOR_FET_TEMP_MAX'
                                        , 'dataItem.MONITOR_HS_TEMP_SPEC_NEED'
                                        , 'dataItem.MONITOR_HS_TEMP_MIN'
                                        , 'dataItem.MONITOR_HS_TEMP_MAX'
                                        , 'dataItem.MONITOR_CAV_TEMP1_SPEC_NEED'
                                        , 'dataItem.MONITOR_CAV_TEMP1_MIN'
                                        , 'dataItem.MONITOR_CAV_TEMP1_MAX'
                                        , 'dataItem.MONITOR_CAV_TEMP2_SPEC_NEED'
                                        , 'dataItem.MONITOR_CAV_TEMP2_MIN'
                                        , 'dataItem.MONITOR_CAV_TEMP2_MAX'
                                        , 'dataItem.MONITOR_CAV_TEMP3_SPEC_NEED'
                                        , 'dataItem.MONITOR_CAV_TEMP3_MIN'
                                        , 'dataItem.MONITOR_CAV_TEMP3_MAX'
                                        , 'dataItem.MONITOR_ACC_TEMP_SPEC_NEED'
                                        , 'dataItem.MONITOR_ACC_TEMP_MIN'
                                        , 'dataItem.MONITOR_ACC_TEMP_MAX'
                                        )";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.PURCHASE_NO", dataItem.PURCHASE_NO);
            sql = sql.Replace("dataItem.OPM_FLOW_MIN", dataItem.OPM_FLOW_MIN);
            sql = sql.Replace("dataItem.OPM_FLOW_MAX", dataItem.OPM_FLOW_MAX);
            sql = sql.Replace("dataItem.FL_FLOW_MIN", dataItem.FL_FLOW_MIN);
            sql = sql.Replace("dataItem.FL_FLOW_MAX", dataItem.FL_FLOW_MAX);
            sql = sql.Replace("dataItem.TS_TEMP_FWPUMP_MIN", dataItem.TS_TEMP_FWPUMP_MIN);
            sql = sql.Replace("dataItem.TS_TEMP_FWPUMP_MAX", dataItem.TS_TEMP_FWPUMP_MAX);
            sql = sql.Replace("dataItem.TS_TEMP_BWPUMP_MIN", dataItem.TS_TEMP_BWPUMP_MIN);
            sql = sql.Replace("dataItem.TS_TEMP_BWPUMP_MAX", dataItem.TS_TEMP_BWPUMP_MAX);
            sql = sql.Replace("dataItem.TS_TEMP_FWTFB_MIN", dataItem.TS_TEMP_FWTFB_MIN);
            sql = sql.Replace("dataItem.TS_TEMP_FWTFB_MAX", dataItem.TS_TEMP_FWTFB_MAX);
            sql = sql.Replace("dataItem.TS_TEMP_BWTFB_MIN", dataItem.TS_TEMP_BWTFB_MIN);
            sql = sql.Replace("dataItem.TS_TEMP_BWTFB_MAX", dataItem.TS_TEMP_BWTFB_MAX);
            sql = sql.Replace("dataItem.TS_TEMP_FWSPLICE_MIN", dataItem.TS_TEMP_FWSPLICE_MIN);
            sql = sql.Replace("dataItem.TS_TEMP_FWSPLICE_MAX", dataItem.TS_TEMP_FWSPLICE_MAX);
            sql = sql.Replace("dataItem.TS_TEMP_BWSPLICE_MIN", dataItem.TS_TEMP_BWSPLICE_MIN);
            sql = sql.Replace("dataItem.TS_TEMP_BWSPLICE_MAX", dataItem.TS_TEMP_BWSPLICE_MAX);
            sql = sql.Replace("dataItem.TS_TEMP_ATTN_MIN", dataItem.TS_TEMP_ATTN_MIN);
            sql = sql.Replace("dataItem.TS_TEMP_ATTN_MAX", dataItem.TS_TEMP_ATTN_MAX);
            sql = sql.Replace("dataItem.TS_TEMP_REFSPICE_MIN", dataItem.TS_TEMP_REFSPICE_MIN);
            sql = sql.Replace("dataItem.TS_TEMP_REFSPICE_MAX", dataItem.TS_TEMP_REFSPICE_MAX);
            sql = sql.Replace("dataItem.TS_TEMP_OUTPUTFIBER_MIN", dataItem.TS_TEMP_OUTPUTFIBER_MIN);
            sql = sql.Replace("dataItem.TS_TEMP_OUTPUTFIBER_MAX", dataItem.TS_TEMP_OUTPUTFIBER_MAX);
            sql = sql.Replace("dataItem.TS_TEMP_FLEREARFIBER_MIN", dataItem.TS_TEMP_FLEREARFIBER_MIN);
            sql = sql.Replace("dataItem.TS_TEMP_FLEREARFIBER_MAX", dataItem.TS_TEMP_FLEREARFIBER_MAX);
            sql = sql.Replace("dataItem.INUSE", dataItem.INUSE);
            sql = sql.Replace("dataItem.IP_ADDRESS", dataItem.IP_ADDRESS);
            sql = sql.Replace("dataItem.NAME_ADDRESS", dataItem.NAME_ADDRESS);
            sql = sql.Replace("dataItem.CREATE_DATE", dataItem.CREATE_DATE);
            sql = sql.Replace("dataItem.LAST_DATE", dataItem.LAST_DATE);
            sql = sql.Replace("dataItem.CREATE_USER", dataItem.CREATE_USER);
            sql = sql.Replace("dataItem.LAST_USER", dataItem.LAST_USER);
            sql = sql.Replace("dataItem.DESCRIPTION", dataItem.DESCRIPTION);
            sql = sql.Replace("dataItem.ALARM_REF_FUSE_NEED", dataItem.ALARM_REF_FUSE_NEED);
            sql = sql.Replace("dataItem.ALARM_REF_TEMP_NEED", dataItem.ALARM_REF_TEMP_NEED);
            sql = sql.Replace("dataItem.ALARM_FET_TEMP_NEED", dataItem.ALARM_FET_TEMP_NEED);
            sql = sql.Replace("dataItem.ALARM_HS_TEMP_NEED", dataItem.ALARM_HS_TEMP_NEED);
            sql = sql.Replace("dataItem.ALARM_LDI_MAX_NEED", dataItem.ALARM_LDI_MAX_NEED);
            sql = sql.Replace("dataItem.ALARM_CAV_TEMP_NEED", dataItem.ALARM_CAV_TEMP_NEED);
            sql = sql.Replace("dataItem.ALARM_ACC_TEMP_NEED", dataItem.ALARM_ACC_TEMP_NEED);
            sql = sql.Replace("dataItem.TEMP_CRITERIA_OUTPUT_SPLICE_POINT_MIN", dataItem.TEMP_CRITERIA_OUTPUT_SPLICE_POINT_MIN);
            sql = sql.Replace("dataItem.TEMP_OUTPUT_SPLICE_QBH_POINT_MIN", dataItem.TEMP_OUTPUT_SPLICE_QBH_POINT_MIN);
            sql = sql.Replace("dataItem.TEMP_CRITERIA_OUTPUT_SPLICE_POINT_MAX", dataItem.TEMP_CRITERIA_OUTPUT_SPLICE_POINT_MAX);
            sql = sql.Replace("dataItem.TEMP_OUTPUT_SPLICE_QBH_POINT_MAX", dataItem.TEMP_OUTPUT_SPLICE_QBH_POINT_MAX);
            sql = sql.Replace("dataItem.MONITOR_CAV_OUT_SPEC_NEED", dataItem.MONITOR_CAV_OUT_SPEC_NEED);
            sql = sql.Replace("dataItem.MONITOR_CAV_OUT_MIN", dataItem.MONITOR_CAV_OUT_MIN);
            sql = sql.Replace("dataItem.MONITOR_CAV_OUT_MAX", dataItem.MONITOR_CAV_OUT_MAX);
            sql = sql.Replace("dataItem.MONITOR_REF_FUSE_SPEC_NEED", dataItem.MONITOR_REF_FUSE_SPEC_NEED);
            sql = sql.Replace("dataItem.MONITOR_REF_FUSE_MIN", dataItem.MONITOR_REF_FUSE_MIN);
            sql = sql.Replace("dataItem.MONITOR_REF_FUSE_MAX", dataItem.MONITOR_REF_FUSE_MAX);
            sql = sql.Replace("dataItem.MONITOR_LDI_SPEC_NEED", dataItem.MONITOR_LDI_SPEC_NEED);
            sql = sql.Replace("dataItem.MONITOR_LDI_MIN", dataItem.MONITOR_LDI_MIN);
            sql = sql.Replace("dataItem.MONITOR_LDI_MAX", dataItem.MONITOR_LDI_MAX);
            sql = sql.Replace("dataItem.MONITOR_REF_TEMP_SPEC_NEED", dataItem.MONITOR_REF_TEMP_SPEC_NEED);
            sql = sql.Replace("dataItem.MONITOR_REF_TEMP_MIN", dataItem.MONITOR_REF_TEMP_MIN);
            sql = sql.Replace("dataItem.MONITOR_REF_TEMP_MAX", dataItem.MONITOR_REF_TEMP_MAX);
            sql = sql.Replace("dataItem.MONITOR_FET_TEMP_SPEC_NEED", dataItem.MONITOR_FET_TEMP_SPEC_NEED);
            sql = sql.Replace("dataItem.MONITOR_FET_TEMP_MIN", dataItem.MONITOR_FET_TEMP_MIN);
            sql = sql.Replace("dataItem.MONITOR_FET_TEMP_MAX", dataItem.MONITOR_FET_TEMP_MAX);
            sql = sql.Replace("dataItem.MONITOR_HS_TEMP_SPEC_NEED", dataItem.MONITOR_HS_TEMP_SPEC_NEED);
            sql = sql.Replace("dataItem.MONITOR_HS_TEMP_MIN", dataItem.MONITOR_HS_TEMP_MIN);
            sql = sql.Replace("dataItem.MONITOR_HS_TEMP_MAX", dataItem.MONITOR_HS_TEMP_MAX);
            sql = sql.Replace("dataItem.MONITOR_CAV_TEMP1_SPEC_NEED", dataItem.MONITOR_CAV_TEMP1_SPEC_NEED);
            sql = sql.Replace("dataItem.MONITOR_CAV_TEMP1_MIN", dataItem.MONITOR_CAV_TEMP1_MIN);
            sql = sql.Replace("dataItem.MONITOR_CAV_TEMP1_MAX", dataItem.MONITOR_CAV_TEMP1_MAX);
            sql = sql.Replace("dataItem.MONITOR_CAV_TEMP2_SPEC_NEED", dataItem.MONITOR_CAV_TEMP2_SPEC_NEED);
            sql = sql.Replace("dataItem.MONITOR_CAV_TEMP2_MIN", dataItem.MONITOR_CAV_TEMP2_MIN);
            sql = sql.Replace("dataItem.MONITOR_CAV_TEMP2_MAX", dataItem.MONITOR_CAV_TEMP2_MAX);
            sql = sql.Replace("dataItem.MONITOR_CAV_TEMP3_SPEC_NEED", dataItem.MONITOR_CAV_TEMP3_SPEC_NEED);
            sql = sql.Replace("dataItem.MONITOR_CAV_TEMP3_MIN", dataItem.MONITOR_CAV_TEMP3_MIN);
            sql = sql.Replace("dataItem.MONITOR_CAV_TEMP3_MAX", dataItem.MONITOR_CAV_TEMP3_MAX);
            sql = sql.Replace("dataItem.MONITOR_ACC_TEMP_SPEC_NEED", dataItem.MONITOR_ACC_TEMP_SPEC_NEED);
            sql = sql.Replace("dataItem.MONITOR_ACC_TEMP_MIN", dataItem.MONITOR_ACC_TEMP_MIN);
            sql = sql.Replace("dataItem.MONITOR_ACC_TEMP_MAX", dataItem.MONITOR_ACC_TEMP_MAX);

            return sql;

        }

        public string Search(FleInitialInspectionSettingProperty dataItem)
        {
            string sql = @"SELECT * FROM tableName 
                             where 
                             AND ID = 'dataItem.ID'";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.ID", dataItem.ID);
            return sql;
        }

        public string Search()
        {
            string sql = @"SELECT * FROM tableName";

            sql = sql.Replace("tableName", tableName);

            return sql;
        }

        public string Update(FleInitialInspectionSettingProperty dataItem)
        {
            string sql = @"";
            return sql;
        }


    }
}