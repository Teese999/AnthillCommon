using AnthillCommon.Common.Contracts;
using AnthillCommon.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Services.Contracts.Models
{
    //osipenkom: те же комментарии, что и для CityDto
    public class OrganisationDto : IEntityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
