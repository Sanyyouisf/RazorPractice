﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RazorPractice.Models
{
    public class RazorPracticeContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public RazorPracticeContext() : base("name=RazorPracticeContext")
        {
        }

        public System.Data.Entity.DbSet<RazorPractice.Models.Order> Orders { get; set; }

        public System.Data.Entity.DbSet<RazorPractice.Models.Person> People { get; set; }

        public System.Data.Entity.DbSet<RazorPractice.Models.Song> Songs { get; set; }

        public System.Data.Entity.DbSet<RazorPractice.Models.Album> Albums { get; set; }
    }
}
