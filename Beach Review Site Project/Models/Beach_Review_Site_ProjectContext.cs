using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Beach_Review_Site_Project.Models
{
    public class Beach_Review_Site_ProjectContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Beach_Review_Site_ProjectContext() : base("name=Beach_Review_Site_ProjectContext")
        {
        }

        public System.Data.Entity.DbSet<Beach_Review_Site_Project.Models.Review> Reviews { get; set; }

        public System.Data.Entity.DbSet<Beach_Review_Site_Project.Models.Category> Categories { get; set; }
    }
}
