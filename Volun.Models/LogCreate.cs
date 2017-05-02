using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volun.Models
{
    public class LogCreate
    {
        [Required]
        [MinLength(1, ErrorMessage = "Please enter at least 1 character")]
        [MaxLength(128)]
        public string Title { get; set; }

        [Required]
        [MaxLength(8000)]
        public string Content { get; set; }

        public override string ToString() => Title;
       
    }
}
