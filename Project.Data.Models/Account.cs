using AnthillCommon.Models;
using AnthillComon.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Models
{
    public class Account : IEntity
    {
        public Account(string login, string nickName, string password, Role role)
        {
            Login = login;
            NickName = nickName;
            Password = password;
            Role = role;
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateTime { get; set; }
        public Role Role { get; set; }
    }
}
