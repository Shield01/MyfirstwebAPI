using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MyfirstwebAPI.Models;

namespace MyfirstwebAPI.DAL
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<AgentsDetails> Agent { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
    }
}
