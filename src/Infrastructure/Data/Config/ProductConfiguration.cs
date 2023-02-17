using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //builder.Property(x => x.Name).IsRequired() bu kısım zorunlu olduğu için yazmak gereği duymadık
            builder.Property(x => x.Name).HasMaxLength(100);

            //Non-nullable olduğu için IsRequired gereksiz
            builder.Property(x => x.Price).IsRequired().HasPrecision(18,2); //Toplam 18 tane rakamdan oluşur fiyat 16 tam 2 virgülden sonra olacak şekilde

            builder.Property(x => x.PictureUrl).IsRequired(false);  //Nullable olduğu için yazmasanız da aynı olurdu.

            //Aşağıdakiler olmasa da olur, çünkü product sınıfında ef geleneğine uygun yazarak ilişkileri belirlemiştik.
            builder.HasOne(x => x.Category).WithMany().HasForeignKey(x=>x.CategoryId);
            builder.HasOne(x => x.Brand).WithMany().HasForeignKey(x => x.BrandId);
        }
    }
}
