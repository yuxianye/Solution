using System;
using Solution.Permissions;
using Solution.Materials.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Materials
{
    public class ProductAppService : CrudAppService<Product, ProductDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductDto, CreateUpdateProductDto>,
        IProductAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.Materials.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.Materials.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.Materials.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.Materials.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.Materials.Delete;

        public ProductAppService(IRepository<Product, Guid> repository) : base(repository)
        {
        }
    }
}