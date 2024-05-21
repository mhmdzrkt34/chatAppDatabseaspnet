using ChatAppDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatAppDatabase.data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> users {  get; set; }


        public DbSet<Messages> messages { get; set; }   


        public DbSet<Contact> contact {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Contact>().HasOne(i => i.user).WithMany(c => c.contacts).HasForeignKey(c => c.user_id);


            modelBuilder.Entity<Messages>().HasOne(i => i.sender).WithMany(c => c.SendedMessages).HasForeignKey(c => c.sender_id).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Messages>().HasOne(i => i.reciever).WithMany(c => c.RecievedMessages).HasForeignKey(c => c.reciever_id).OnDelete(DeleteBehavior.Restrict);



        }



    }
}
