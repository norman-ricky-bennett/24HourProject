using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Hour.Models
{
    public class ReplyCreate
    { 
      [Required]
      public string Text { get; set; }
        [Required]
        public Guid Author { get; set; }
        
    }
}
