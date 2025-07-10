using ABP_Ecommerce.Samples;
using Xunit;

namespace ABP_Ecommerce.EntityFrameworkCore.Applications;

[Collection(ABP_EcommerceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ABP_EcommerceEntityFrameworkCoreTestModule>
{

}
