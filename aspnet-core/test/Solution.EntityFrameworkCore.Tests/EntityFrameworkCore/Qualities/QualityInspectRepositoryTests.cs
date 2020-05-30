using System;
using System.Threading.Tasks;
using Solution.Qualities;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Qualities
{
    public class QualityInspectRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<QualityInspect, Guid> _qualityInspectRepository;

        public QualityInspectRepositoryTests()
        {
            _qualityInspectRepository = GetRequiredService<IRepository<QualityInspect, Guid>>();
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
