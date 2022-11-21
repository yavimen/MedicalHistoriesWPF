
using MedicalHistories.Models;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace MedicalHistories
{
    public class ImagePathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (PatientStatus)value;
            var uri = new Uri(String.Format(@"D:\Polytechnic\SoftwareDesign\Lab2\PatientsDataSerializer\MedicalHistories\icons\Status_{0}.png", status),UriKind.Absolute);
            return new BitmapImage(uri);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
