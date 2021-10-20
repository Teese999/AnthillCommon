using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnthillCommon.Models
{
    public class SignupModel
    {
        [Required]
        [MinLength(1)]
        public string Login { get; set; }

        [Required]
        [MinLength(1)]
        public string NickName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(4)]
        public string Password { get; set; }
    }
}
