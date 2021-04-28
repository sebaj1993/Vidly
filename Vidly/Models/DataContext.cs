using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Vidly.Models;
using MySql.Data.Entity;

namespace Vidly.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DataContext : DbContext
    {
        public DataContext()
            : base("DefaultConnection") //This 'DefaultConnection' should be equal to the connection string name on Web.config.
        {
            this.Configuration.ValidateOnSaveEnabled = false;
        }

        //Your model classes should be added as DbSets
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public DbSet<Rental> Rentals { get; set; }
    }
}