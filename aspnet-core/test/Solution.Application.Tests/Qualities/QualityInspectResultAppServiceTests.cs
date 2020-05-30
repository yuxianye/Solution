using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Qualities
{
    public class QualityInspectResultAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IQualityInspectResultAppService _qualityInspectResultAppService;

        public QualityInspectResultAppServiceTests()
        {
            _qualityInspectResultAppService = GetRequiredService<IQualityInspectResultAppService>();
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
