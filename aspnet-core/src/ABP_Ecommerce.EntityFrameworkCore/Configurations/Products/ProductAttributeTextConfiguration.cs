using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP_Ecommerce.Products
{
    public class ProductAttributeTextConfiguration : IEntityTypeConfiguration<ProductAttributeText>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeText> builder)
        {
            builder.ToTable(ABP_EcommerceConsts.DbTablePrefix + "ProductAttributeTexts");
            builder.HasKey(x => x.Id);

        }
    }
}
