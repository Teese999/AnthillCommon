using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthillCommon.Models
{
    public class OrganisationModel
    {
        //osipenkom: зачем тут конструктор без параметров, который нигде не импользуется?
        public OrganisationModel()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
