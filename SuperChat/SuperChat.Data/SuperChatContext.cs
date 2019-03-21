using Microsoft.EntityFrameworkCore;
using SuperChat.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperChat.Data
{
    class SuperChatContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = SuperChatAppData; Trusted_Connection = True; ");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
