using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Qualities
{
    public class QualityInspectTypeAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IQualityInspectTypeAppService _qualityInspectTypeAppService;

        public QualityInspectTypeAppServiceTests()
        {
            _qualityInspectTypeAppService = GetRequiredService<IQualityInspectTypeAppService>();
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
