using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthillCommon.Models
{
    public class OfficeModel
    {
        public OfficeModel()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateTime { get; set; }
        public int CityId { get; set; }
        public int OrganisationId { get; set; }

    }
}
