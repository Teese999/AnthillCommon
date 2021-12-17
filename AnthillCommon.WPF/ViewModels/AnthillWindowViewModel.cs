using AnthillCommon.Models;
using AnthillCommon.WPF.Helpers;
using AnthillCommon.WPF.Models;
using AnthillCommon.WPF.Views;
using AutoMapper;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AnthillCommon.WPF.ViewModels
{
    public class AnthillWindowViewModel : BaseViewModel
    {
        public RelayCommand SignIn { get; set; }
        public RelayCommand SignUp { get; set; }
        public RelayCommand Create { get; set; }
        public RelayCommand Read { get; set; }
        public RelayCommand Delete { get; set; }
        public RelayCommand NextPage { get; set; }
        public RelayCommand PrevPage { get; set; }
        public ObservableCollection<User> UserList { get; set; } = new ObservableCollection<User>();
        private int _pageNumber;
        public int PageNumber
        {
            get { return _pageNumber; }
            set
            {
                _pageNumber = value; OnPropertyChanged("Pagenumber");
            }
        }
        public AnthillWindowViewModel()
        {
            Rolename = "Non autorized";
            PageNumber = 0;
            CommandsActivate();
            _ = DownloadUsers();
        }
        private void CommandsActivate()
        {
            SignIn = new RelayCommand
               (x =>
               {
                   new SignInWindow().Show();
               }, o => { return true; });

            SignUp = new RelayCommand
               (x =>
               {
                   new SignUpWindow().Show();
               }, o => { return true; });

            NextPage = new RelayCommand
             (async x =>
             {
                 PageNumber++;
                 await DownloadUsers();

             }, o => { return true; });
            PrevPage = new RelayCommand
             (async x =>
             {
                 PageNumber--;
                 await DownloadUsers();

             }, o => { return PageNumber > 0; });

        }
        private async Task DownloadUsers()
            {
            Client = new RestClient("https://localhost:5001");
            var request = new RestRequest("api/user/getlist", Method.GET);
            request.RequestFormat = RestSharp.DataFormat.Json;
            request.AddParameter("countPerPage", "20");
            request.AddParameter("pageNumber", PageNumber);
            Client.AddDefaultHeader("Content-type", "application/json");
            var responce = await Client.ExecuteAsync(request);
            if (responce.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var result = JsonConvert.DeserializeObject<PaginationModel>(responce.Content);
                UserList.Clear();
                foreach (var item in result.Users) { UserList.Add(item); }
            }
            
        }
    }
}
