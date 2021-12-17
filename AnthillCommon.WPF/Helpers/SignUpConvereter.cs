using AnthillCommon.WPF.Models;
using AnthillComon.Common.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace AnthillCommon.WPF.Helpers
{
    public class SignUpConvereter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var roleName = (values[1] as ComboBoxItem).Content.ToString();
            Role role = (Role)Enum.Parse(typeof(Role), roleName, true);
            return new Models.SignUpModel()
            {
                Window = values[0] as Window,
                Role = role
            };
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
