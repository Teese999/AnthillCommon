using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Services.Contracts.Models
{
    public class PaginationSettingsDto
    {

        public int CountPerPage { get; set; }
        public int PageNumber { get; set; }
        public int? SelectedOffice { get; set; }
        public int? SelectedCity { get; set; }

        public PaginationSettingsDto Clone()
        {
            return new PaginationSettingsDto()
            {
                CountPerPage = CountPerPage,
                PageNumber = PageNumber,
                SelectedOffice = SelectedOffice,
                SelectedCity = SelectedCity,
            };
        }
    }
}
