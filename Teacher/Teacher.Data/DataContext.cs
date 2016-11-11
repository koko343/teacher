using System.Data.Entity;
using Teacher.Core.Interfaces;

namespace Teacher.Data
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext() : base("Connection")
        {
            //Database.SetInitializer(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().ToTable("Products").HasKey(q => q.Id);
        }
    }
}
