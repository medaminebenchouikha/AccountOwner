using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Account
    {

        public Guid AccountId { get; set; }

        public DateTime DateCreated { get; set; }

        public string AccountType { get; set; }

        [ForeignKey(nameof(Owner))]
        public Guid OwnerId { get; set; }

        public Owner Owner { get; set; }
    }
}
