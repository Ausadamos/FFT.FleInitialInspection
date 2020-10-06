using BusinessData.Interface;
using BusinessData.Property;
using FleInitialInspectionManagement.Property;
using FleInitialInspectionManagement.SQLFactory;
using System;

namespace FleInitialInspectionManagement.Services
{
    public class FleInitialInspectionSettingDetailServices : DatabaseAction<FleInitialInspectionSettingDetailProperty>
    {
        FleInitialInspectionSettingDetailSQLFactory _sqlFactory = new FleInitialInspectionSettingDetailSQLFactory();
        OutputOnDbProperty _resultData = new OutputOnDbProperty();

        public override OutputOnDbProperty Delete(FleInitialInspectionSettingDetailProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public OutputOnDbProperty DeleteById(FleInitialInspectionSettingDetailProperty dataItem)
        {
            string sql = _sqlFactory.DeleteById(dataItem);
            _resultData = base.DeleteBySql(sql);
            return _resultData;
        }




        public override OutputOnDbProperty Insert(FleInitialInspectionSettingDetailProperty dataItem)
        {
            string sql = _sqlFactory.Insert(dataItem);
            _resultData = base.InsertBySql(sql);
            return _resultData;
        }

        public override OutputOnDbProperty Search(FleInitialInspectionSettingDetailProperty dataItem)
        {
            throw new NotImplementedException();
        }



        public OutputOnDbProperty SearchMaxStep(FleInitialInspectionSettingDetailProperty dataItem)
        {
            string sql = _sqlFactory.SearchMaxStep(dataItem);
            _resultData = base.SearchBySql(sql);
            return _resultData;
        }


        public OutputOnDbProperty SearchByPurchase(FleInitialInspectionSettingDetailProperty dataItem)
        {
            string sql = _sqlFactory.SearchByPurchase(dataItem);
            _resultData = base.SearchBySql(sql);
            return _resultData;
        }


        public override OutputOnDbProperty Search()
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Update(FleInitialInspectionSettingDetailProperty dataItem)
        {
            throw new NotImplementedException();
        }
    }
}