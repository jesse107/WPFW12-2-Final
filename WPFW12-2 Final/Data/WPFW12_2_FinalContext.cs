using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WPFW12_2_Final.Models;

namespace WPFW12_2_Final.Data
{
    public class WPFW12_2_FinalContext : DbContext
    {
        public WPFW12_2_FinalContext (DbContextOptions<WPFW12_2_FinalContext> options)
            : base(options)
        {
        }

        public DbSet<WPFW12_2_Final.Models.Student> Student { get; set; }
    }
}
