using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("owner")]
    public class Owner
    {
        public Guid OwnerId { get; set; }

        [Required(ErrorMessage= "Name is required")]
        [StringLength(60, ErrorMessage ="Name can't be longer than 60 chara")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateBirth   { get; set; }

        public string Address { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}
