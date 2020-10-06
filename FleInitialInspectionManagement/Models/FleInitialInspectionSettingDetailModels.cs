using BusinessData.Property;
using FleInitialInspectionManagement.Property;
using FleInitialInspectionManagement.Services;

namespace FleInitialInspectionManagement.Models
{
    public class FleInitialInspectionSettingDetailModels
    {

        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        FleInitialInspectionSettingDetailServices _service = new FleInitialInspectionSettingDetailServices();

        public OutputOnDbProperty SearchByPurchase(FleInitialInspectionSettingDetailProperty dataItem)
        {
            _resultData = _service.SearchByPurchase(dataItem);
            return _resultData;
        }

        public OutputOnDbProperty SearchMaxStep(FleInitialInspectionSettingDetailProperty dataItem)
        {
            _resultData = _service.SearchMaxStep(dataItem);
            return _resultData;
        }

        public OutputOnDbProperty DeleteById(FleInitialInspectionSettingDetailProperty dataItem)
        {
            _resultData = _service.DeleteById(dataItem);
            return _resultData;
        }
        public OutputOnDbProperty Insert(FleInitialInspectionSettingDetailProperty dataItem)
        {
            _resultData = _service.Insert(dataItem);
            return _resultData;
        }


    }
}