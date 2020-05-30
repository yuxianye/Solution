using System;
using Solution.Permissions;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Equipments
{
    public class EquipmentInspectionResultAppService : CrudAppService<EquipmentInspectionResult, EquipmentInspectionResultDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEquipmentInspectionResultDto, CreateUpdateEquipmentInspectionResultDto>,
        IEquipmentInspectionResultAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.Equipments.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.Equipments.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.Equipments.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.Equipments.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.Equipments.Delete;

        public EquipmentInspectionResultAppService(IRepository<EquipmentInspectionResult, Guid> repository) : base(repository)
        {
        }
    }
}