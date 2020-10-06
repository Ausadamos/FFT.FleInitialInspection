using BusinessData.Interface;
using BusinessData.Property;
using FleInitialInspectionManagement.Property;
using FleInitialInspectionManagement.SQLFactory;

namespace FleInitialInspectionManagement.Services
{
    public class FleInitialInspectionSettingServices : DatabaseAction<FleInitialInspectionSettingProperty>
    {
        FleInitialInspectionSettingSQLFactory _sqlFactory = new FleInitialInspectionSettingSQLFactory();
        OutputOnDbProperty _resultData = new OutputOnDbProperty();

        public override OutputOnDbProperty Delete(FleInitialInspectionSettingProperty dataItem)
        {
            string sql = _sqlFactory.Delete(dataItem);
            _resultData = base.DeleteBySql(sql);
            return _resultData;
        }

        public override OutputOnDbProperty Insert(FleInitialInspectionSettingProperty dataItem)
        {
            string sql = _sqlFactory.Insert(dataItem);
            _resultData = base.InsertBySql(sql);
            return _resultData;
        }

        public override OutputOnDbProperty Search(FleInitialInspectionSettingProperty dataItem)
        {
            string sql = _sqlFactory.Search(dataItem);
            _resultData = base.SearchBySql(sql);
            return _resultData;
        }

        public override OutputOnDbProperty Search()
        {
            string sql = _sqlFactory.Search();
            _resultData = base.SearchBySql(sql);
            return _resultData;
        }

        public override OutputOnDbProperty Update(FleInitialInspectionSettingProperty dataItem)
        {
            string sql = _sqlFactory.Update(dataItem);
            _resultData = base.UpdateBySql(sql);
            return _resultData;
        }
    }
}