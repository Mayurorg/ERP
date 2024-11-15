using Android_CRUD_app.Models;
using Microsoft.EntityFrameworkCore;
namespace Android_CRUD_app.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
