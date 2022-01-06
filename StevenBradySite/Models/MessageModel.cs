using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StevenBradySite.Models
{
    public class MessageModel
    {
        [Key] // Add-Migration Initial would not work without [Key] to define primary key
        public int MessageId { get; set; }
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public string Date { get; set; }

    }
}
