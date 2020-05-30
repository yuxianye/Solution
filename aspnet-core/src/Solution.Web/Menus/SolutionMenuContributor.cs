using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Solution.Permissions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Solution.Localization;
using Solution.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Solution.Web.Menus
{
    public class SolutionMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var authorizationService = context.ServiceProvider.GetRequiredService<IAuthorizationService>();
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<SolutionResource>>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem("Solution.Home", l["Menu:Home"], "/"));
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.Enterprises.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Enterprises", l["Menu:Enterprises"], "/Enterprises/Enterprise")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.EnterpriseAreas.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Enterprises", l["Menu:Enterprises"], "/Enterprises/EnterpriseArea")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.EnterpriseProductionLines.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Enterprises", l["Menu:Enterprises"], "/Enterprises/EnterpriseProductionLine")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.EnterpriseSites.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Enterprises", l["Menu:Enterprises"], "/Enterprises/EnterpriseSite")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.EnterpriseWorkCenters.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Enterprises", l["Menu:Enterprises"], "/Enterprises/EnterpriseWorkCenter")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.EnterpriseWorkLocations.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Enterprises", l["Menu:Enterprises"], "/Enterprises/EnterpriseWorkLocation")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.Equipments.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Equipments", l["Menu:Equipments"], "/Equipments/Equipment")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.EquipmentBrands.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Equipments", l["Menu:Equipments"], "/Equipments/EquipmentBrand")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.EquipmentInspections.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Equipments", l["Menu:Equipments"], "/Equipments/EquipmentInspection")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.EquipmentInspectionResults.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Equipments", l["Menu:Equipments"], "/Equipments/EquipmentInspectionResult")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.EquipmentMaintenances.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Equipments", l["Menu:Equipments"], "/Equipments/EquipmentMaintenance")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.EquipmentMaintenanceResults.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Equipments", l["Menu:Equipments"], "/Equipments/EquipmentMaintenanceResult")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.EquipmentSpareParts.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Equipments", l["Menu:Equipments"], "/Equipments/EquipmentSparePart")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.EquipmentSparePartTypes.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Equipments", l["Menu:Equipments"], "/Equipments/EquipmentSparePartType")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.EquipmentStatus.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Equipments", l["Menu:Equipments"], "/Equipments/EquipmentStatus")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.EquipmentTypes.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Equipments", l["Menu:Equipments"], "/Equipments/EquipmentType")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.Materials.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Materials", l["Menu:Materials"], "/Materials/Material")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.Products.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Materials", l["Menu:Materials"], "/Materials/Product")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.ProductTypes.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Materials", l["Menu:Materials"], "/Materials/ProductType")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.BOMs.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Materials", l["Menu:Materials"], "/Materials/BOM")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.Units.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Public", l["Menu:Units"], "/Public/Unit")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.QualityInspects.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Qualities", l["Menu:Qualities"], "/Qualities/QualityInspect")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.QualityInspectResults.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Qualities", l["Menu:Qualities"], "/Qualities/QualityInspectResult")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.QualityInspectTypes.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Qualities", l["Menu:Qualities"], "/Qualities/QualityInspectType")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.QualityProblemLibs.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Qualities", l["Menu:Qualities"], "/Qualities/QualityProblemLib")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.Suppliers.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Suppliers", l["Menu:Suppliers"], "/Suppliers/Suppliers")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.SupplierLevels.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Suppliers", l["Menu:Suppliers"], "/Suppliers/SupplierLevel")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.Warehouses.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Warehouses", l["Menu:Warehouses"], "/Warehouses/Warehouse")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.WarehouseAreas.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Warehouses", l["Menu:Warehouses"], "/Warehouses/WarehouseArea")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.WareHouseLocations.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Warehouses", l["Menu:Warehouses"], "/Warehouses/WareHouseLocation")
                );
            }
            if (await authorizationService.IsGrantedAsync(SolutionPermissions.WarehouseTypes.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem("Warehouses", l["Menu:Warehouses"], "/Warehouses/WarehouseType")
                );
            }
            
        }
    }
}
