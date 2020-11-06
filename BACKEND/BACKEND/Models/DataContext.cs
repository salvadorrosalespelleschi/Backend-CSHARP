

namespace BACKEND.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {
               
        }

        public DbSet<Student> Students { get; set; }
    }
}