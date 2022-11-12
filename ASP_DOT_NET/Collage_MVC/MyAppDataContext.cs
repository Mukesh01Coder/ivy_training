using Collage_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Collage_MVC
{
    public class MyAppDataContext: DbContext
    {
        public MyAppDataContext(DbContextOptions options ):base(options)
        {

        }
       
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Club> Clubs { get; set; }

    }
}
