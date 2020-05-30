using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Warehouses
{
    public class WarehouseAreaAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IWarehouseAreaAppService _warehouseAreaAppService;

        public WarehouseAreaAppServiceTests()
        {
            _warehouseAreaAppService = GetRequiredService<IWarehouseAreaAppService>();
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
