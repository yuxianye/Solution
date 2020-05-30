using System;
using Solution.Permissions;
using Solution.Materials.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Materials
{
    public class ProductTypeAppService : CrudAppService<ProductType, ProductTypeDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductTypeDto, CreateUpdateProductTypeDto>,
        IProductTypeAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.Materials.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.Materials.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.Materials.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.Materials.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.Materials.Delete;

        public ProductTypeAppService(IRepository<ProductType, Guid> repository) : base(repository)
        {
        }
    }
}