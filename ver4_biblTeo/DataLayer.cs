using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using ver4_biblTeo.DataStuff;

namespace ver4_biblTeo
{
    public class DataContext : DbContext
    {
        // aicia se lucreaza cu baza de date si outputu in fisiere
        // e suficient sa fie singleton

        public DbSet<Book> Books { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // var connString = 
               // ConfigurationManager.ConnectionStrings["DATABASE"].ConnectionString;
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB; Database=BibliotecaDb; Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<BookClient>()
                .HasKey(bc => new { bc.BookID, bc.ClientID });

        }
    }
}
