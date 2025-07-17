using ABP_Ecommerce.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP_Ecommerce.Products
{
    public class ProductAttributeDateTimeConfiguration : IEntityTypeConfiguration<ProductAttribueDateTime>
    {
        public void Configure(EntityTypeBuilder<ProductAttribueDateTime> builder)
        {
            builder.ToTable(ABP_EcommerceConsts.DbTablePrefix + "ProductAttribueDateTimes");
            builder.HasKey(x => x.Id);

        }
    }
}
