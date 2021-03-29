using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain.Catalog;

namespace TechTest01.Repository.DataMapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            HasKey(t => t.Id);
            //properties
            Property(t => t.Name).IsRequired();
            Property(t => t.Price).IsRequired().HasColumnType("decimal");
            Property(t => t.ImageUrl).IsRequired().HasMaxLength(1000);
            Property(t => t.Slug).IsRequired(); 
            Property(t => t.Description).IsRequired().HasMaxLength(1000);  
            //table
            ToTable("Products");
        }
    }
}
