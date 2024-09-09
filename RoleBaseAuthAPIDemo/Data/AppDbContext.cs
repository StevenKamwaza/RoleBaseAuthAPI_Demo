using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RoleBaseAuthAPIDemo.Domain.Models;
using System.Diagnostics.Metrics;

namespace RoleBaseAuthAPIDemo.Data
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {

      
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Blog> Blogs { get; set; }
    }
}
