using MedicalHistories.DataViewModels;
using MedicalHistories.Models;

namespace MedicalHistories.Profile
{
    public class MedicalHistoryProfile: AutoMapper.Profile
    {
        public MedicalHistoryProfile()
        {
            CreateMap<MedicalHistory, MedicalHistoryViewModel>()
                .ReverseMap();
        }
    }
}
