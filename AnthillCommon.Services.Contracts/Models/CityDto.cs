using AnthillCommon.Common.Contracts;
using AnthillCommon.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Services.Contracts.Models
{
    //osipenkom: зачем тут используется интерфейс IEntityDto, в чем суть?
    public class CityDto : IEntityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
