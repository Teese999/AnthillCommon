using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AnthillCommon.Models
{
    public class PaginationSettingsModel
    {
        [Required]
        public int CountPerPage { get; set; }
        [Required]
        public int PageNumber { get; set; }
        public int? SelectedOffice { get; set; }
        public int? SelectedCity { get; set; }
    }
}
