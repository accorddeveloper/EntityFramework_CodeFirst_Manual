using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_Manual.Model
{
    public class LunchBoxModel : DbContext
    {
        public LunchBoxModel() : base("name=LunchBoxConn")
        {
            //將Entity Framework操作SQL顯示在Console
            this.Database.Log = s => Console.WriteLine(s);
        }
        /// <summary>
        /// 對映DB Products Table
        /// </summary>
        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {

            //modelBuilder.Ignore<Product>();
            //modelBuilder.Entity<Product>().ToTable("tbProduct");

            //modelBuilder.Entity<Product>().Ignore(p => p.Price);
            //modelBuilder.Entity<Product>().Property(p => p.Price).HasColumnName("ProductPrice");

            //modelBuilder.Entity<Product>().Property(p => p.Name).HasMaxLength(50);
            //modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired();

            //modelBuilder.Entity<Product>().Property(p => p.Name).HasColumnType("varchar");
            //modelBuilder.Entity<Product>().Property(p => p.Name).IsUnicode(true);

            //modelBuilder.Entity<Product>().HasKey(p => p.Id);
            //modelBuilder.Entity<Product>().Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
