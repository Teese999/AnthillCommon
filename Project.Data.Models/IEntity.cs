using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthillCommon.Models
{
    public interface IEntity
    {
        
        int Id { get; set; }
        DateTime CreateDate { get; set; }
        DateTime UpdateTime { get; set; }
    }
}
