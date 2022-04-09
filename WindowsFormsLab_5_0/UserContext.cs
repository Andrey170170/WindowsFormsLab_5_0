using System.Data.Entity;

namespace WindowsFormsLab_5_0
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DbConnection") { }
        public DbSet<User> Users { get; set; }
    }
}