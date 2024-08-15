using Announcement_Web_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Announcement_Web_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Announcement> Announcements { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
