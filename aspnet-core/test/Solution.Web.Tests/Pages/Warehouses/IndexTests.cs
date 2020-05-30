
using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Solution.Pages.Warehouses
{
    public class Index_Tests : SolutionWebTestBase
    {
        [Fact]
        public async Task Index_Page_Test()
        {
            // Arrange

            // Act
            var response = await GetResponseAsStringAsync("/WarehouseType");

            // Assert
            response.ShouldNotBeNull();
        }
    }
}
