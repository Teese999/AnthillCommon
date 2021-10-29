using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthillCommon.Models
{
    public class PaginationSettingsModel
    {
        public int CountPerPage { get; set; }
        public int PageNumber { get; set; }
        public int? SelectedOffice { get; set; }
        public int? SelectedCity { get; set; }
    }
}
