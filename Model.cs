using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace CrudForm.SQLite
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./crud.db");
        }
    }

    public class User
    {
        public int UserId {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Phone {get; set;}
        public string Address {get; set;}
    }
}