using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Suppliers
{
    public class SuppliersAppServiceTests : SolutionApplicationTestBase
    {
        private readonly ISuppliersAppService _suppliersAppService;

        public SuppliersAppServiceTests()
        {
            _suppliersAppService = GetRequiredService<ISuppliersAppService>();
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
