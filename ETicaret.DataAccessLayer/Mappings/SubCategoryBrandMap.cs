using Eticaret.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETicaret.DataAccesLayer.Mappings
{
    public class SubCategoryBrandMap : IEntityTypeConfiguration<SubCategoryBrand>
    {
        public void Configure(EntityTypeBuilder<SubCategoryBrand> builder)
        {
            builder.Property(x => x.SubCategoryBrandId).HasColumnType("int");
            builder.Property(x => x.SubCategoryBrandName).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(x => x.SortKey).HasDefaultValue(0);
            builder.Property(x => x.SubCategoryBrandStatus).HasDefaultValue(true); 

            builder.HasData(new SubCategoryBrand
            {
                SubCategoryBrandId = 1,
                SubCategoryBrandName = "Puma",
                SubCategoryBrandStatus = true,
                SortKey = 1
                

            });


        }
    }
}
