using System;
using System.Threading.Tasks;
using Solution.Public;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Public
{
    public class UnitRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<Unit, Guid> _unitRepository;

        public UnitRepositoryTests()
        {
            _unitRepository = GetRequiredService<IRepository<Unit, Guid>>();
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
