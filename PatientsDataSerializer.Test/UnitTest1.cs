using PatientsDataSerializer.Models;
using PatientsDataSerializer.Serializer;
using PatientsDataSerializer.DataModels;
namespace PatientsDataSerializer.Test
{
    [TestClass]
    public class SerializerFunctionalityTests
    {
        [TestMethod]
        public void TestSerialize()
        {
            var model = new DataModel()
            {
                MedicalHistories = new List<MedicalHistory>()
                {
                    new MedicalHistory
                    {
                       Birthdate = DateOnly.FromDateTime(DateTime.Now),
                       PatientContacts = "sdad@fact.com",
                       PatientFullName = "Goofy Head",
                       Department = "Gym",
                       DoctorFullName = "Heavy Arms",
                       DoctorPosition = "Boss of the gym",
                       Diagnosis = "Cold",
                       Treatment = "Drink tea"
                    } 
                }
            };
        
            MedicalHistoryDataSerializer.Serialize(@"D:\Polytechnic\SoftwareDesign\organizer.dat", model);
        }

        [TestMethod]
        public void TestDeserialize() 
        {
            var model = MedicalHistoryDataSerializer.DeserializeItem(@"D:\Polytechnic\SoftwareDesign\organizer.dat");
        }
    }
}