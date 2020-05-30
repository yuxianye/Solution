using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Suppliers
{
    public class SupplierLevelAppServiceTests : SolutionApplicationTestBase
    {
        private readonly ISupplierLevelAppService _supplierLevelAppService;

        public SupplierLevelAppServiceTests()
        {
            _supplierLevelAppService = GetRequiredService<ISupplierLevelAppService>();
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
