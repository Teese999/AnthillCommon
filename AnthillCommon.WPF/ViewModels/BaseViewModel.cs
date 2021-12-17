using AnthillCommon.WPF.Helpers;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AnthillCommon.WPF.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public static event PropertyChangedEventHandler StaticPropertyChanged;
        public static string Token { get; set; }
        public static RestClient Client { get; set; } = new RestClient("https://localhost:5001/");
        public static string Rolename
        {
            get { return _roleName; }
            set
            {
                _roleName = value; NotifyStaticPropertyChanged("Rolename");
            }

        }
        private static string _roleName;

        public static void NotifyStaticPropertyChanged([CallerMemberName] string name = null)
        {
            StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(name));
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public RelayCommand WindowClose { get; set; } = new RelayCommand(o => { (o as Window).Close(); }, o => { return o != null && o is Window; });

    }
}
