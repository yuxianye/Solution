using System;
using System.Threading.Tasks;
using Solution.Qualities;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Qualities
{
    public class QualityProblemLibRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<QualityProblemLib, Guid> _qualityProblemLibRepository;

        public QualityProblemLibRepositoryTests()
        {
            _qualityProblemLibRepository = GetRequiredService<IRepository<QualityProblemLib, Guid>>();
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
