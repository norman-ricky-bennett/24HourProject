using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Hour.Models
{
    public class PostListItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        [Display(Name="Posted")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
