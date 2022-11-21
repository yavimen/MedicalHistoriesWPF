using MedicalHistories.Models;
using MedicalHistories.ViewModels;
using System.Windows.Input;

namespace MedicalHistories.DataViewModels
{
    public class MedicalHistoryViewModel: ViewModelBase
    {
        public MedicalHistoryViewModel() { }
        public MedicalHistoryViewModel(MedicalHistoryViewModel medicalHistory)
        {
            _birthdate = medicalHistory.Birthdate;
            _department = medicalHistory.Department;
            _diagnosis = medicalHistory.Diagnosis;
            _doctorFullName = medicalHistory.DoctorFullName;
            _doctorPosition = medicalHistory.DoctorPosition;
            _patientContacts = medicalHistory.PatientContacts;
            _patientFullName = medicalHistory.PatientFullName;
            _status = medicalHistory.Status; 
            _treatment = medicalHistory.Treatment;
        }

        private string? _patientFullName;

        public string? PatientFullName
        {
            get { return _patientFullName; }
            set { 
                _patientFullName = value;
                OnPropertyChanged("PatientFullName");
            }
        }

        private string? _patientContacts;

        public string? PatientContacts
        {
            get { return _patientContacts; }
            set { 
                _patientContacts = value;
                OnPropertyChanged("PatientContacts"); 
            }
        }

        private string? _birthdate;

        public string? Birthdate
        {
            get { return _birthdate; }
            set { 
                _birthdate = value;
                OnPropertyChanged("Birthdate");
            }
        }

        private string? _diagnosis;

        public string? Diagnosis
        {
            get { return _diagnosis; }
            set { 
                _diagnosis = value;
                OnPropertyChanged("Diagnosis");
            }
        }

        private string? _department;

        public string? Department
        {
            get { return _department; }
            set { 
                _department = value;
                OnPropertyChanged("Department");
            }
        }

        private string? _doctorFullName;

        public string? DoctorFullName
        {
            get { return _doctorFullName; }
            set { 
                _doctorFullName = value;
                OnPropertyChanged("DoctorFullName");
            }
        }

        private string? _doctorPosition;

        public string? DoctorPosition
        {
            get { return _doctorPosition; }
            set
            {
                _doctorPosition = value;
                OnPropertyChanged("DoctorPosition");
            }
        }
        private string? _treatment;

        public string? Treatment
        {
            get { return _treatment; }
            set { 
                _treatment = value;
                OnPropertyChanged("Treatment");
            }
        }        
        
        private  PatientStatus _status;

        public PatientStatus Status
        {
            get { return _status; }
            set {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }
}
