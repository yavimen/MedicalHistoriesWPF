using System.Collections.ObjectModel;
using System.Windows.Input;
using MedicalHistories.Models;
using MedicalHistories.ViewModels;

namespace MedicalHistories.DataViewModels
{
    public class DataViewModel:ViewModelBase
    {
        public DataViewModel()
        {
            DischargePatientCommand = new Command(DischargePatient);
            DeletePatientCommand = new Command(DeletePatient);
            AddNewPatientCommand = new Command(AddNewPatient);
            _newPatient = new MedicalHistoryViewModel
            {
                PatientFullName = null,
                PatientContacts = null,
                Birthdate = null,
                Department = null,
                DoctorFullName = null,
                DoctorPosition = null,
                Status = PatientStatus.ForTreatment,
                Diagnosis = null,
                Treatment = null
            };
        }

        public ICommand DischargePatientCommand { get; set; }
        public void DischargePatient(object args)
        {
            SelectedPatient.Status = PatientStatus.Discharged;
        }

        public ICommand AddNewPatientCommand { get; set; }
        public void AddNewPatient(object args)
        {
            if (_newPatient.Treatment != null &&
                _newPatient.PatientContacts != null &&
                _newPatient.PatientFullName != null &&
                _newPatient.Diagnosis != null &&
                _newPatient.DoctorFullName != null &&
                _newPatient.DoctorPosition != null &&
                _newPatient.Department != null)
            {
                MedicalHistories?.Add(new MedicalHistoryViewModel(_newPatient));

                NewPatient.PatientFullName = null;
                NewPatient.PatientContacts = null;
                NewPatient.Birthdate = null;
                NewPatient.Department = null;
                NewPatient.DoctorFullName = null;
                NewPatient.DoctorPosition = null;
                NewPatient.Status = PatientStatus.ForTreatment;
                NewPatient.Diagnosis = null;
                NewPatient.Treatment = null;
                
            }
        }
        public ICommand DeletePatientCommand { get; set; }
        public void DeletePatient(object args)
        {
            MedicalHistories?.Remove(SelectedPatient);
        }

        protected ObservableCollection<MedicalHistoryViewModel>? _medicalHistories;
        public ObservableCollection<MedicalHistoryViewModel>? MedicalHistories 
        { 
            get { return _medicalHistories; }
            set {
                _medicalHistories = value;
                OnPropertyChanged("MedicalHistories");
            } 
        }

        private MedicalHistoryViewModel _selectedPatient;

        public MedicalHistoryViewModel SelectedPatient
        {
            get { return _selectedPatient; }
            set
            {
                _selectedPatient = value;
                OnPropertyChanged("SelectedPatient");
            }
        }

        private MedicalHistoryViewModel _newPatient;

        public MedicalHistoryViewModel NewPatient
        {
            get { return _newPatient; }
            set
            {
                _newPatient = value;
                OnPropertyChanged("NewPatient");
            }
        }
    }
}
