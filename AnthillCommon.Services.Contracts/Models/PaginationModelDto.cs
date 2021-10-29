﻿using AnthillCommon.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Services.Contracts.Models
{
    public class PaginationModelDto : ICloneable
    {
        public PaginationSettingsDto PrevPage { get; set; }
        public PaginationSettingsDto NextPage { get; set; }
        public int UsersCount { get; set; }
        public int PagesCount { get; set; }
        public List<User> Users { get; set; } = new List<User>();

        public object Clone()
        {
            return new PaginationModelDto()
            {
                UsersCount = UsersCount,
                PagesCount = PagesCount,
                PrevPage = PrevPage,
                NextPage = NextPage,
                Users = Users
            };
        }
    }

}
