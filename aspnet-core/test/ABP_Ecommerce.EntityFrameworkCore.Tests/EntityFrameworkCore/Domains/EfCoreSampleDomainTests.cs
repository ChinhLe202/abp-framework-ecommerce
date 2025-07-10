using ABP_Ecommerce.Samples;
using Xunit;

namespace ABP_Ecommerce.EntityFrameworkCore.Domains;

[Collection(ABP_EcommerceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ABP_EcommerceEntityFrameworkCoreTestModule>
{

}
