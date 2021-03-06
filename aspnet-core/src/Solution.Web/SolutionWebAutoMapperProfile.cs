using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.Enterprise.ViewModels;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseArea.ViewModels;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseProductionLine.ViewModels;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseSite.ViewModels;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseWorkCenter.ViewModels;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseWorkLocation.ViewModels;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.Equipment.ViewModels;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentBrand.ViewModels;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentInspection.ViewModels;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentInspectionResult.ViewModels;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentMaintenance.ViewModels;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentMaintenanceResult.ViewModels;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentSparePart.ViewModels;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentSparePartType.ViewModels;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentStatus.ViewModels;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentType.ViewModels;
using Solution.Materials.Dtos;
using Solution.Web.Pages.Materials.Material.ViewModels;
using Solution.Materials.Dtos;
using Solution.Web.Pages.Materials.Product.ViewModels;
using Solution.Materials.Dtos;
using Solution.Web.Pages.Materials.ProductType.ViewModels;
using Solution.Materials.Dtos;
using Solution.Web.Pages.Materials.BOM.ViewModels;
using Solution.Public.Dtos;
using Solution.Web.Pages.Public.Unit.ViewModels;
using Solution.Qualities.Dtos;
using Solution.Web.Pages.Qualities.QualityInspect.ViewModels;
using Solution.Qualities.Dtos;
using Solution.Web.Pages.Qualities.QualityInspectResult.ViewModels;
using Solution.Qualities.Dtos;
using Solution.Web.Pages.Qualities.QualityInspectType.ViewModels;
using Solution.Qualities.Dtos;
using Solution.Web.Pages.Qualities.QualityProblemLib.ViewModels;
using Solution.Suppliers.Dtos;
using Solution.Web.Pages.Suppliers.SupplierLevel.ViewModels;
using Solution.Warehouses.Dtos;
using Solution.Web.Pages.Warehouses.Warehouse.ViewModels;
using Solution.Warehouses.Dtos;
using Solution.Web.Pages.Warehouses.WarehouseArea.ViewModels;
using Solution.Warehouses.Dtos;
using Solution.Web.Pages.Warehouses.WareHouseLocation.ViewModels;
using Solution.Warehouses.Dtos;
using Solution.Web.Pages.Warehouses.WarehouseType.ViewModels;
using Solution.Suppliers.Dtos;
using Solution.Web.Pages.Suppliers.Suppliers.ViewModels;
using AutoMapper;

namespace Solution.Web
{
    public class SolutionWebAutoMapperProfile : Profile
    {
        public SolutionWebAutoMapperProfile()
        {
            //Define your AutoMapper configuration here for the Web project.
            CreateMap<EnterpriseDto, CreateEditEnterpriseViewModel>();
            CreateMap<CreateEditEnterpriseViewModel, CreateUpdateEnterpriseDto>();
            CreateMap<EnterpriseAreaDto, CreateEditEnterpriseAreaViewModel>();
            CreateMap<CreateEditEnterpriseAreaViewModel, CreateUpdateEnterpriseAreaDto>();
            CreateMap<EnterpriseProductionLineDto, CreateEditEnterpriseProductionLineViewModel>();
            CreateMap<CreateEditEnterpriseProductionLineViewModel, CreateUpdateEnterpriseProductionLineDto>();
            CreateMap<EnterpriseSiteDto, CreateEditEnterpriseSiteViewModel>();
            CreateMap<CreateEditEnterpriseSiteViewModel, CreateUpdateEnterpriseSiteDto>();
            CreateMap<EnterpriseWorkCenterDto, CreateEditEnterpriseWorkCenterViewModel>();
            CreateMap<CreateEditEnterpriseWorkCenterViewModel, CreateUpdateEnterpriseWorkCenterDto>();
            CreateMap<EnterpriseWorkLocationDto, CreateEditEnterpriseWorkLocationViewModel>();
            CreateMap<CreateEditEnterpriseWorkLocationViewModel, CreateUpdateEnterpriseWorkLocationDto>();
            CreateMap<EquipmentDto, CreateEditEquipmentViewModel>();
            CreateMap<CreateEditEquipmentViewModel, CreateUpdateEquipmentDto>();
            CreateMap<EquipmentBrandDto, CreateEditEquipmentBrandViewModel>();
            CreateMap<CreateEditEquipmentBrandViewModel, CreateUpdateEquipmentBrandDto>();
            CreateMap<EquipmentInspectionDto, CreateEditEquipmentInspectionViewModel>();
            CreateMap<CreateEditEquipmentInspectionViewModel, CreateUpdateEquipmentInspectionDto>();
            CreateMap<EquipmentInspectionResultDto, CreateEditEquipmentInspectionResultViewModel>();
            CreateMap<CreateEditEquipmentInspectionResultViewModel, CreateUpdateEquipmentInspectionResultDto>();
            CreateMap<EquipmentMaintenanceDto, CreateEditEquipmentMaintenanceViewModel>();
            CreateMap<CreateEditEquipmentMaintenanceViewModel, CreateUpdateEquipmentMaintenanceDto>();
            CreateMap<EquipmentMaintenanceResultDto, CreateEditEquipmentMaintenanceResultViewModel>();
            CreateMap<CreateEditEquipmentMaintenanceResultViewModel, CreateUpdateEquipmentMaintenanceResultDto>();
            CreateMap<EquipmentSparePartDto, CreateEditEquipmentSparePartViewModel>();
            CreateMap<CreateEditEquipmentSparePartViewModel, CreateUpdateEquipmentSparePartDto>();
            CreateMap<EquipmentSparePartTypeDto, CreateEditEquipmentSparePartTypeViewModel>();
            CreateMap<CreateEditEquipmentSparePartTypeViewModel, CreateUpdateEquipmentSparePartTypeDto>();
            CreateMap<EquipmentStatusDto, CreateEditEquipmentStatusViewModel>();
            CreateMap<CreateEditEquipmentStatusViewModel, CreateUpdateEquipmentStatusDto>();
            CreateMap<EquipmentTypeDto, CreateEditEquipmentTypeViewModel>();
            CreateMap<CreateEditEquipmentTypeViewModel, CreateUpdateEquipmentTypeDto>();
            CreateMap<MaterialDto, CreateEditMaterialViewModel>();
            CreateMap<CreateEditMaterialViewModel, CreateUpdateMaterialDto>();
            CreateMap<ProductDto, CreateEditProductViewModel>();
            CreateMap<CreateEditProductViewModel, CreateUpdateProductDto>();
            CreateMap<ProductTypeDto, CreateEditProductTypeViewModel>();
            CreateMap<CreateEditProductTypeViewModel, CreateUpdateProductTypeDto>();
            CreateMap<BOMDto, CreateEditBOMViewModel>();
            CreateMap<CreateEditBOMViewModel, CreateUpdateBOMDto>();
            CreateMap<UnitDto, CreateEditUnitViewModel>();
            CreateMap<CreateEditUnitViewModel, CreateUpdateUnitDto>();
            CreateMap<QualityInspectDto, CreateEditQualityInspectViewModel>();
            CreateMap<CreateEditQualityInspectViewModel, CreateUpdateQualityInspectDto>();
            CreateMap<QualityInspectResultDto, CreateEditQualityInspectResultViewModel>();
            CreateMap<CreateEditQualityInspectResultViewModel, CreateUpdateQualityInspectResultDto>();
            CreateMap<QualityInspectTypeDto, CreateEditQualityInspectTypeViewModel>();
            CreateMap<CreateEditQualityInspectTypeViewModel, CreateUpdateQualityInspectTypeDto>();
            CreateMap<QualityProblemLibDto, CreateEditQualityProblemLibViewModel>();
            CreateMap<CreateEditQualityProblemLibViewModel, CreateUpdateQualityProblemLibDto>();
            CreateMap<SupplierLevelDto, CreateEditSupplierLevelViewModel>();
            CreateMap<CreateEditSupplierLevelViewModel, CreateUpdateSupplierLevelDto>();
            CreateMap<WarehouseDto, CreateEditWarehouseViewModel>();
            CreateMap<CreateEditWarehouseViewModel, CreateUpdateWarehouseDto>();
            CreateMap<WarehouseAreaDto, CreateEditWarehouseAreaViewModel>();
            CreateMap<CreateEditWarehouseAreaViewModel, CreateUpdateWarehouseAreaDto>();
            CreateMap<WareHouseLocationDto, CreateEditWareHouseLocationViewModel>();
            CreateMap<CreateEditWareHouseLocationViewModel, CreateUpdateWareHouseLocationDto>();
            CreateMap<WarehouseTypeDto, CreateEditWarehouseTypeViewModel>();
            CreateMap<CreateEditWarehouseTypeViewModel, CreateUpdateWarehouseTypeDto>();
            CreateMap<SuppliersDto, CreateEditSuppliersViewModel>();
            CreateMap<CreateEditSuppliersViewModel, CreateUpdateSuppliersDto>();
        }
    }
}
