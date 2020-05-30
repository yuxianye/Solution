
using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Solution.Pages.Suppliers
{
    public class Index_Tests : SolutionWebTestBase
    {
        [Fact]
        public async Task Index_Page_Test()
        {
            // Arrange

            // Act
            var response = await GetResponseAsStringAsync("/Suppliers");

            // Assert
            response.ShouldNotBeNull();
        }
    }
}
