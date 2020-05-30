using System;
using System.Threading.Tasks;
using Solution.Suppliers;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Suppliers
{
    public class SuppliersRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<Solution.Suppliers.Suppliers, Guid> _suppliersRepository;

        public SuppliersRepositoryTests()
        {
            _suppliersRepository = GetRequiredService<IRepository<Solution.Suppliers.Suppliers, Guid>>();
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
