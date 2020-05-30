using System;
using System.Threading.Tasks;
using Solution.Warehouses;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Warehouses
{
    public class WareHouseLocationRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<WareHouseLocation, Guid> _wareHouseLocationRepository;

        public WareHouseLocationRepositoryTests()
        {
            _wareHouseLocationRepository = GetRequiredService<IRepository<WareHouseLocation, Guid>>();
        }

        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
    }
}
