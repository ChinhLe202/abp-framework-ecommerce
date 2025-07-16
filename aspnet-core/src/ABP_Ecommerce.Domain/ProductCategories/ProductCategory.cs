using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace ABP_Ecommerce.ProductCategories
{
    public class ProductCategory : CreationAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Slug { get; set; }
        public int SortOder { get; set; }
        public string CoverPicture { get; set; }
        public bool Visibility { get; set; }
        public bool IsActive { get; set; }
        public Guid? ParentId { get; set; }
        public string SeoMetaDesciption  { get; set; }
    }
}
