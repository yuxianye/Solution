using System;
using Solution.Permissions;
using Solution.Qualities.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Qualities
{
    public class QualityProblemLibAppService : CrudAppService<QualityProblemLib, QualityProblemLibDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateQualityProblemLibDto, CreateUpdateQualityProblemLibDto>,
        IQualityProblemLibAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.Qualities.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.Qualities.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.Qualities.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.Qualities.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.Qualities.Delete;

        public QualityProblemLibAppService(IRepository<QualityProblemLib, Guid> repository) : base(repository)
        {
        }
    }
}