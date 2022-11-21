using MedicalHistories.DataModels;
using MedicalHistories.DataViewModels;

namespace MedicalHistories.Profile
{
    public class DataModelProfile: AutoMapper.Profile
    {
        public DataModelProfile()
        {
            CreateMap<DataModel, DataViewModel>()
                .ReverseMap();
        }
    }
}
