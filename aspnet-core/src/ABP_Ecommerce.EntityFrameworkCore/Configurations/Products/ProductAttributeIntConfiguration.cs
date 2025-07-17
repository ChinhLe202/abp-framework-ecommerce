using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP_Ecommerce.Products
{
    public class ProductAttributeIntConfiguration : IEntityTypeConfiguration<ProductAttributeDecimal>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeDecimal> builder)
        {
            builder.ToTable(ABP_EcommerceConsts.DbTablePrefix + "ProductAttributeDecimals");
            builder.HasKey(x => x.Id);

        }
    }
}
