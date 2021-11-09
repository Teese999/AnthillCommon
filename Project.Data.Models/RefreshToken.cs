
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AnthillCommon.Models
{
    public class RefreshToken
    {
        public int id { get; set; }
        public int AccountId { get; set; }
        public string Token { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        [ForeignKey(nameof(AccountId))]
        public virtual Account Account { get; set; }
    }
}
