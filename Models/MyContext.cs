using System;
using Microsoft.EntityFrameworkCore;

namespace ActivityCenter.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options){}
        
        public DbSet<Activ> Activities {get; set;} 
        public DbSet<User> Users {get; set;} 
        public DbSet<Association> Associations {get; set;} 
    
    }
}