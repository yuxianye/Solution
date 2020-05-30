using System;
using System.Threading.Tasks;
using Solution.Warehouses;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Warehouses
{
    public class WarehouseTypeRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<WarehouseType, Guid> _warehouseTypeRepository;

        public WarehouseTypeRepositoryTests()
        {
            _warehouseTypeRepository = GetRequiredService<IRepository<WarehouseType, Guid>>();
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
