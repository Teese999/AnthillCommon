using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Services.Contracts.Models
{
    public class PaginationSettingsDto
    {

        public int CountPerPage { get; set; }
        public int PageNumber { get; set; }
        public bool OrderByOffice { get; set; }
        public bool OrderByCity { get; set; }
        public int SelectedOffice { get; set; }
        //osipenkom: опечатка
        public int SelctedCity { get; set; }

        public PaginationSettingsDto Clone()
        {
            return new PaginationSettingsDto()
            {
                CountPerPage = CountPerPage,
                PageNumber = PageNumber,
                OrderByOffice = OrderByOffice,
                OrderByCity = OrderByCity,
                SelectedOffice = SelectedOffice,
                SelctedCity = SelctedCity,
            };
        }
    }
}
