using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Qualities
{
    public class QualityInspectAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IQualityInspectAppService _qualityInspectAppService;

        public QualityInspectAppServiceTests()
        {
            _qualityInspectAppService = GetRequiredService<IQualityInspectAppService>();
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
