using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Warehouses
{
    public class WareHouseLocationAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IWareHouseLocationAppService _wareHouseLocationAppService;

        public WareHouseLocationAppServiceTests()
        {
            _wareHouseLocationAppService = GetRequiredService<IWareHouseLocationAppService>();
        }

        [Fact]
        public async Task Test1()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
