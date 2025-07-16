using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace ABP_Ecommerce.Products
{
    public class ProductAttribueDateTime : Entity<Guid>
    {
        public ProductAttribueDateTime(Guid id, Guid attributeId, Guid productId, DateTime? value)
        {
            Id = id;
            AttributeId = attributeId;
            ProductId = productId;
            Value = value;
        }

        public Guid AttributeId { get; set; }
        public Guid ProductId { get; set; }
        public DateTime? Value { get; set; }
    }
}
