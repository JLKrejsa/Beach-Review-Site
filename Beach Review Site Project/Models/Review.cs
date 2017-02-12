﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Beach_Review_Site_Project.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Beach { get; set; }
        public string Comments { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        
    }
}