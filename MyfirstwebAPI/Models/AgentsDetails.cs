using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace MyfirstwebAPI.Models
{
    public class AgentsDetails
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        public string FullName { get; set; }

        public int Age { get; set; }

        public long PhoneNumber { get; set; }

        public char Gender { get; set; }

        public string EmailAddress { get; set; }
        
    }
}
