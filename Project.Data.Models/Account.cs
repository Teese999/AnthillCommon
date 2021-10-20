using AnthillCommon.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Models
{
    public class Account : IEntity
    {
        public Account(string login, string nickName, string password)
        {
            Login = login;
            NickName = nickName;
            Password = password;
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
