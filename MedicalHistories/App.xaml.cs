using AutoMapper;
using MedicalHistories.Profile;
using MedicalHistories.DataModels;
using MedicalHistories.DataViewModels;
using MedicalHistories.Models;
using System;
using System.Windows;

namespace MedicalHistories
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected MainWindow _mainWindow;
        protected DataModel _dataModel;
        protected DataViewModel _dataViewModel;
        protected IMapper _mapper; 
        public App()
        {
            var configuration = new MapperConfiguration(cfg => {
                cfg.AddProfile<DataModelProfile>();
                cfg.AddProfile<MedicalHistoryProfile>();
            });
            _mapper = new Mapper(configuration); 
            _dataModel = DataModel.Load();
            _dataViewModel = _mapper.Map<DataModel ,DataViewModel>(_dataModel);
            var _mainWindow = new MainWindow() { DataContext = _dataViewModel } ;    
            _mainWindow.Show();
        }

        protected override void OnExit(ExitEventArgs args) 
        {
            try
            {
                _dataModel = _mapper.Map<DataViewModel, DataModel>(_dataViewModel);
                DataModel.Save(_dataModel);
            }
            catch (Exception) 
            {
                base.OnExit(args);
                throw;
            }
        }
    }
}
