using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Stucore.Models
{
    public class Students
    {

        [Key]
        [Required]

        public int sid { get; set; }
        public string studentname { get; set; }
        public string studentage { get; set; }
        public string deptname { get; set; }
        
    }
}
