using System;
using System.Threading.Tasks;
using Solution.Warehouses;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Warehouses
{
    public class WarehouseRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<Warehouse, Guid> _warehouseRepository;

        public WarehouseRepositoryTests()
        {
            _warehouseRepository = GetRequiredService<IRepository<Warehouse, Guid>>();
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
