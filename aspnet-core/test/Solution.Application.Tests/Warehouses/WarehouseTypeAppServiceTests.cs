using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Warehouses
{
    public class WarehouseTypeAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IWarehouseTypeAppService _warehouseTypeAppService;

        public WarehouseTypeAppServiceTests()
        {
            _warehouseTypeAppService = GetRequiredService<IWarehouseTypeAppService>();
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
