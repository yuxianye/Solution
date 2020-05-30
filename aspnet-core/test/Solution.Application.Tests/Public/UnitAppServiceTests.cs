using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Public
{
    public class UnitAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IUnitAppService _unitAppService;

        public UnitAppServiceTests()
        {
            _unitAppService = GetRequiredService<IUnitAppService>();
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
