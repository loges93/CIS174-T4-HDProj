using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team4_FinalProject.Models
{
    public class TicketManagerDbContext : DbContext
    {
        public TicketManagerDbContext(DbContextOptions<TicketManagerDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Note> Notes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<User>().Property(p => p.IsTechnician).HasDefaultValue(false);

            //Seed Users
            User user1 = new();
            user1.UserId = 1;
            user1.Username = "Chasidy";
            user1.Password = "password";
            user1.FirstName = "Chasidy";
            user1.LastName = "Spurgeon";
            user1.IsTechnician = true;
            modelBuilder.Entity<User>().HasData(user1);

            User user2 = new();
            user2.UserId = 2;
            user2.Username = "Wade";
            user2.Password = "password";
            user2.FirstName = "Wade";
            user2.LastName = "Shafer";
            user2.IsTechnician = true;
            modelBuilder.Entity<User>().HasData(user2);

            User user3 = new();
            user3.UserId = 3;
            user3.Username = "John";
            user3.Password = "password";
            user3.FirstName = "John";
            user3.LastName = "Ryan";
            user3.IsTechnician = true;
            modelBuilder.Entity<User>().HasData(user3);

            User user4 = new();
            user4.UserId = 4;
            user4.Username = "Logan";
            user4.Password = "password";
            user4.FirstName = "Logan";
            user4.LastName = "Riedell";
            user4.IsTechnician = true;
            modelBuilder.Entity<User>().HasData(user4);

            User reg_user = new();
            reg_user.UserId = 5;
            reg_user.Username = "GoodJoe12";
            reg_user.Password = "passWord1";
            reg_user.FirstName = "Tom";
            reg_user.LastName = "Hanks";
            modelBuilder.Entity<User>().HasData(reg_user);

            base.OnModelCreating(modelBuilder);
        }
    }
}
