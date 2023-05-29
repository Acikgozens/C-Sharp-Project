
using Eticaret.Core.Models;
using ETicaret.DataAccesLayer.Mappings;
using Microsoft.EntityFrameworkCore;


namespace ETicaret.DataAccesLayer.Concretes.Contexts
{
    /// <summary>
    /// Ef  Db Process....
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        //DbSet<Category> Categories { get; set; }
        //DbSet<Brand> Brands { get; set; }
        //DbSet<Adress> Adresses { get; set; }


        // Enttiy ile veritabanı arasındaki ilişki sağlıyor
        DbSet<Customer> Customers { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<SubCategoryBrand> SubCategoryBrands { get; set; }
        DbSet<Employee> employees { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    

    public ApplicationDbContext()
        {

        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Sql 
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-K5S7FQ58\\SQLEXPRESS;database=DbETradeMvc22-23-Guz;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new SubCategoryBrandMap());
            modelBuilder.ApplyConfiguration(new EmployeeMap());

        }
    }
}
