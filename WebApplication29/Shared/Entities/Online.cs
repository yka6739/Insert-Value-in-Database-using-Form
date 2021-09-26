using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication29.Shared.Entities
{
     public class Online
    {
        public int Id { get; set; }
        [Required]
        public string  Name { get; set; }
        [Required]
        public string City { get; set; }
    }
}
