using Microsoft.Data.Entity;
using System.Collections.Generic;
using System.IO;
using System;

namespace EF7ProjectLemon
{
    public class LemonContext : DbContext
    {
        public DbSet<Auth> AuthPeople { get; set; }
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {           
            string databaseFilePath = Environment.CurrentDirectory + "/database/lemon.db";

            optionsBuilder.UseSqlite($"Data source={databaseFilePath}");
         
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // делаем в таблице Auth поле login not null
            /*modelBuilder.Entity<Auth>()
                .Property(b => b.Login)
                .Required();*/
        }
    }

    public class Auth
    {
        public int AuthId { get; set; }
        public string Login { get; set; }

       // public int PersonId { get; set; }
       // public Person Person { get; set; }
    }

    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }

       // public List<Auth> AuthPeople { get; set; }

       

     
    }
}
