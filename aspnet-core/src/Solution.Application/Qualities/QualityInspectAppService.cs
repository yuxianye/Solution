using System;
using Solution.Permissions;
using Solution.Qualities.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Qualities
{
    public class QualityInspectAppService : CrudAppService<QualityInspect, QualityInspectDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateQualityInspectDto, CreateUpdateQualityInspectDto>,
        IQualityInspectAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.Qualities.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.Qualities.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.Qualities.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.Qualities.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.Qualities.Delete;

        public QualityInspectAppService(IRepository<QualityInspect, Guid> repository) : base(repository)
        {
        }
    }
}