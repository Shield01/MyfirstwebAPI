using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace MyfirstwebAPI.Models
{
    public class AgentsDetails
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string FullName { get; set; }

        public int Age { get; set; }

        public long PhoneNumber { get; set; }

        public char Gender { get; set; }

        public string EmailAddress { get; set; }
        //public void Configure(IApplicationBuilder app)
        //{
        //    For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

            
        //}
    }
}
