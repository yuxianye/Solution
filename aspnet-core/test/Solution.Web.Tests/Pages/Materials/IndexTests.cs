
using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Solution.Pages.Materials
{
    public class Index_Tests : SolutionWebTestBase
    {
        [Fact]
        public async Task Index_Page_Test()
        {
            // Arrange

            // Act
            var response = await GetResponseAsStringAsync("/BOM");

            // Assert
            response.ShouldNotBeNull();
        }
    }
}
