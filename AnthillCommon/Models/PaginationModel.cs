using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthillCommon.Models
{
    public class PaginationModel
    {
        public PaginationSettingsModel PrevPage { get; set; }
        public PaginationSettingsModel NextPage { get; set; }
        public int UsersCount { get; set; }
        public int PagesCount { get; set; }
        public List<User> Users { get; set; } = new List<User>();
    }
}
