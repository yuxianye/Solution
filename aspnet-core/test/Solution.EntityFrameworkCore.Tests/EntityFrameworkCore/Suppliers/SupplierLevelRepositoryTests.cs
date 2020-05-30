using System;
using System.Threading.Tasks;
using Solution.Suppliers;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Suppliers
{
    public class SupplierLevelRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<SupplierLevel, Guid> _supplierLevelRepository;

        public SupplierLevelRepositoryTests()
        {
            _supplierLevelRepository = GetRequiredService<IRepository<SupplierLevel, Guid>>();
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
