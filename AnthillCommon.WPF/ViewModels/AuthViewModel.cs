using AnthillCommon.WPF.Helpers;
using AnthillCommon.WPF.Models;
using AnthillCommon.WPF.Views;
using AnthillComon.Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace AnthillCommon.WPF.ViewModels
{
    public class AuthViewModel : BaseViewModel
    {
        public AuthViewModel()
        {
            CommandActivate();
            Login = "Login";

        }

        public RelayCommand SignIn { get; set; }
        public RelayCommand SignUp { get; set; }
        public RelayCommand PasswordChanged { get; set; }
        public string Login
        {
            get { return _login; }
            set
            {
                _login = value; OnPropertyChanged("Login");
            }
        }
        public string Nickname
        {
            get { return _nickName; }
            set
            {
                _nickName = value; OnPropertyChanged("NickName");
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value; OnPropertyChanged("Password");
            }
        }
        private string _nickName;
        private string _login;
        private string _password;
        private void CommandActivate()
        {
            SignUp = new RelayCommand
               (async x =>
               {
                   await TrySignUp(x as SignUpModel);
               }, o => { return true; });
            SignIn = new RelayCommand
              (async x =>
              {
                  await TrySignIn(x as Window);
              }, o => { return true; });
            PasswordChanged = new RelayCommand
               (x =>
               {
                   if (x != null)
                       Password = (x as PasswordBox).Password;
               }, o => { return true; });
        }
        private async Task TrySignUp(SignUpModel signUpModel)
        {
            var request = new RestRequest("api/auth/signup", Method.POST);
            request.RequestFormat = RestSharp.DataFormat.Json;
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(new
            {
                Login = _login,
                NickName = _login,
                Password = _password,
                Role = (int)signUpModel.Role,
                OrganisationId = 1
            });

            var responce = await Client.ExecuteAsync(request);
            if (responce.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var result = JsonConvert.DeserializeObject<dynamic>(responce.Content);
                Token = result.access_token;
                Rolename = result.role;
                signUpModel.Window.Close();
            }
            else
            {
                MessageBox.Show($"{responce.StatusCode} \n {responce.Content}");
            }
        }
        private async Task TrySignIn(Window window)
        {
            var request = new RestRequest("api/auth/signin", Method.POST);
            request.RequestFormat = RestSharp.DataFormat.Json;
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(new
            {
                Login = _login,
                Password = _password,
            });

            var responce = await Client.ExecuteAsync(request);
            if (responce.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var result = JsonConvert.DeserializeObject<dynamic>(responce.Content);
                Token = result.access_token;
                Rolename = result.role;
                window.Close();
            }
            else
            {
                MessageBox.Show($"{responce.StatusCode} \n {responce.Content}");
            }
        }
    }
}
