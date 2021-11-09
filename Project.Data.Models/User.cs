using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnthillCommon.Models
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateTime { get; set; }
        public int OfficeId { get; set; }
        public Boolean IsFired { get; set; }
        public virtual Office Office{ get; set; }

    }
}
