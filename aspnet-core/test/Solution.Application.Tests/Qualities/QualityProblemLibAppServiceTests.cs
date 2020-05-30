using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Qualities
{
    public class QualityProblemLibAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IQualityProblemLibAppService _qualityProblemLibAppService;

        public QualityProblemLibAppServiceTests()
        {
            _qualityProblemLibAppService = GetRequiredService<IQualityProblemLibAppService>();
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
