using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Warehouses
{
    public class WarehouseAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IWarehouseAppService _warehouseAppService;

        public WarehouseAppServiceTests()
        {
            _warehouseAppService = GetRequiredService<IWarehouseAppService>();
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
