using System.Runtime.Serialization;

namespace MedicalHistories.Models
{
    [DataContract]
    public class MedicalHistory
    {
        [DataMember]
        public string? PatientFullName { get; set; }

        [DataMember]
        public string? PatientContacts { get; set; }

        [DataMember]
        public string? Birthdate { get; set; }

        [DataMember]
        public string? Diagnosis { get; set; }

        [DataMember]
        public string? Department { get; set; }

        [DataMember]
        public string? DoctorFullName { get; set; }

        [DataMember]
        public string? DoctorPosition { get; set; }

        [DataMember]
        public string? Treatment { get; set; }

        [DataMember]
        public PatientStatus Status { get; set; } 
    }

    [DataContract]
    public enum PatientStatus
    {
        [EnumMember]
        ForTreatment,
        [EnumMember]
        Discharged
    }
}
