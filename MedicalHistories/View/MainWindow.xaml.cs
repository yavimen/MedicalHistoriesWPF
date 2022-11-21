using MedicalHistories.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MedicalHistories
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AddingHistoryWindow _addingWindow;
        public MainWindow()
        {
            InitializeComponent();
            _addingWindow = new AddingHistoryWindow();
        }
        public new object DataContext
        {
            get { return base.DataContext; }
            set
            {
                base.DataContext = value;
                _addingWindow.DataContext = value;
            }
        }

        private void AddNewPatient_Click(object sender, RoutedEventArgs e)
        {
            _addingWindow.Show();
        }
    }
}
