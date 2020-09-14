namespace ModeloJWT.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}