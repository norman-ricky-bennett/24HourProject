﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFour_Hour.Data
{
   
    public class Post
    {
        [Key]
       public int ID { get; set; }
        [Required]
       public string Title { get; set; }
        [Required]
      public string Text { get; set; }
        [Required]
       public Guid Author { get; set; }

    }
}
