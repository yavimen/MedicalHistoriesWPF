using PatientsDataSerializer.Models;
using PatientsDataSerializer.Serializer;
using System.Runtime.Serialization;

namespace PatientsDataSerializer.DataModels
{
    [DataContract]
    public class DataModel
    {
        static public string filePath = "medicinehist.dat";

        [DataMember]
        public IEnumerable<MedicalHistory> MedicalHistories { get; set; }

        public DataModel()
        {
            MedicalHistories = new List<MedicalHistory>()
                {
                    new MedicalHistory
                    {
                       Birthdate = DateOnly.FromDateTime(DateTime.Now).ToString(),
                       PatientContacts = "sdad@fact.com",
                       PatientFullName = "Goofy Head",
                       Department = "Gym",
                       DoctorFullName = "Heavy Arms",
                       DoctorPosition = "Boss of the gym",
                       Diagnosis = "Cold",
                       Treatment = "Drink tea",
                       Status = PatientStatus.ForTreatment
                    }
                };
        }

        static public DataModel Load()
        {
            if (File.Exists(filePath))
            {
                return MedicalHistoryDataSerializer.DeserializeItem(filePath);
            }
            return new DataModel();
        }

        static public void Save(DataModel dataModel)
        {
            MedicalHistoryDataSerializer.Serialize(filePath, dataModel);
        }
    }
}
