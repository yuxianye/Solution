using System;
using Solution.Permissions;
using Solution.Suppliers.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Suppliers
{
    public class SupplierLevelAppService : CrudAppService<SupplierLevel, SupplierLevelDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateSupplierLevelDto, CreateUpdateSupplierLevelDto>,
        ISupplierLevelAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.Suppliers.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.Suppliers.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.Suppliers.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.Suppliers.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.Suppliers.Delete;

        public SupplierLevelAppService(IRepository<SupplierLevel, Guid> repository) : base(repository)
        {
        }
    }
}