using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using coreMVC.Models;

namespace coreMVC.Data
{
    public class coreMVCContext : DbContext
    {
        public coreMVCContext (DbContextOptions<coreMVCContext> options)
            : base(options)
        {
        }

        public DbSet<coreMVC.Models.User> User { get; set; } = default!;
    }
}
