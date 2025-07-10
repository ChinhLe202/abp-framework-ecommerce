using Xunit;

namespace ABP_Ecommerce.EntityFrameworkCore;

[CollectionDefinition(ABP_EcommerceTestConsts.CollectionDefinitionName)]
public class ABP_EcommerceEntityFrameworkCoreCollection : ICollectionFixture<ABP_EcommerceEntityFrameworkCoreFixture>
{

}
