using System;
using System.Threading.Tasks;
using Solution.Qualities;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Qualities
{
    public class QualityInspectTypeRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<QualityInspectType, Guid> _qualityInspectTypeRepository;

        public QualityInspectTypeRepositoryTests()
        {
            _qualityInspectTypeRepository = GetRequiredService<IRepository<QualityInspectType, Guid>>();
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
