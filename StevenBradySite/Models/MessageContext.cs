using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StevenBradySite.Models
{
    public class MessageContext : DbContext
    {
        public MessageContext(DbContextOptions<MessageContext> options) : base(options) { }

        public DbSet<MessageModel> Messages { get; set; }

        // seeds the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MessageModel>().HasData(
                new MessageModel { MessageId = 1, FirstName = "Bob", LastName = "Blank", Subject = "Not Sure", Date = "11-25-21", Message = "I'm drawing a blank" },
                new MessageModel { MessageId = 2, FirstName = "Kevin", LastName = "Klink", Subject = "Hogan", Date = "11-25-21", Message = "Hogaaaan!" }
                );
        }
    }
}
