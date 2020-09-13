namespace ModeloJWT.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ModeloJWT.Models.Student> Students { get; set; }
    }
}