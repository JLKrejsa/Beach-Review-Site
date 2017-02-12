using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Beach_Review_Site_Project.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Region { get; set; }
        public virtual ICollection<Review>Review { get; set; }
      
    }
}
