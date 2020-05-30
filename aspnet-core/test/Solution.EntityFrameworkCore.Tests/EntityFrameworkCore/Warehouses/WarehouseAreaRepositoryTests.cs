using System;
using System.Threading.Tasks;
using Solution.Warehouses;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Warehouses
{
    public class WarehouseAreaRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<WarehouseArea, Guid> _warehouseAreaRepository;

        public WarehouseAreaRepositoryTests()
        {
            _warehouseAreaRepository = GetRequiredService<IRepository<WarehouseArea, Guid>>();
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
