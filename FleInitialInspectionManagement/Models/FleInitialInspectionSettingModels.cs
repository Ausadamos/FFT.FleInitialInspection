using BusinessData.Property;
using FleInitialInspectionManagement.Property;
using FleInitialInspectionManagement.Services;

namespace FleInitialInspectionManagement.Models
{
    public class FleInitialInspectionSettingModels
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        FleInitialInspectionSettingServices _service = new FleInitialInspectionSettingServices();

        public OutputOnDbProperty Delete(FleInitialInspectionSettingProperty dataItem)
        {
            _resultData = _service.Delete(dataItem);
            return _resultData;
        }

        public OutputOnDbProperty Insert(FleInitialInspectionSettingProperty dataItem)
        {
            _resultData = _service.Insert(dataItem);
            return _resultData;
        }

        public OutputOnDbProperty Search()
        {
            _resultData = _service.Search();
            return _resultData;
        }

        public OutputOnDbProperty Search(FleInitialInspectionSettingProperty dataItem)
        {
            _resultData = _service.Search(dataItem);
            return _resultData;
        }

        public OutputOnDbProperty insert(FleInitialInspectionSettingProperty dataItem)
        {
            _resultData = _service.Search();
            return _resultData;
        }

        public OutputOnDbProperty Update(FleInitialInspectionSettingProperty dataItem)
        {
            _resultData = _service.Update(dataItem);
            return _resultData;
        }

    }
}