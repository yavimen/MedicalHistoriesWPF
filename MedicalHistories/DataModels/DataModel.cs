using MedicalHistories.Models;
using MedicalHistories.Serializer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

namespace MedicalHistories.DataModels
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
                       DoctorFullName = "Doc Name",
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
