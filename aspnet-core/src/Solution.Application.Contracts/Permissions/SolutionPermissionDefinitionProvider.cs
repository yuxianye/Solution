using Solution.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Solution.Permissions
{
    public class SolutionPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(SolutionPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(SolutionPermissions.MyPermission1, L("Permission:MyPermission1"));

            var enterprisePermission = myGroup.AddPermission(SolutionPermissions.Enterprises.Default, L("Permission:Enterprises"));
            enterprisePermission.AddChild(SolutionPermissions.Enterprises.Create, L("Permission:Create"));
            enterprisePermission.AddChild(SolutionPermissions.Enterprises.Update, L("Permission:Update"));
            enterprisePermission.AddChild(SolutionPermissions.Enterprises.Delete, L("Permission:Delete"));

            var enterpriseAreaPermission = myGroup.AddPermission(SolutionPermissions.Enterprises.Default, L("Permission:Enterprises"));
            enterpriseAreaPermission.AddChild(SolutionPermissions.Enterprises.Create, L("Permission:Create"));
            enterpriseAreaPermission.AddChild(SolutionPermissions.Enterprises.Update, L("Permission:Update"));
            enterpriseAreaPermission.AddChild(SolutionPermissions.Enterprises.Delete, L("Permission:Delete"));

            var enterpriseProductionLinePermission = myGroup.AddPermission(SolutionPermissions.Enterprises.Default, L("Permission:Enterprises"));
            enterpriseProductionLinePermission.AddChild(SolutionPermissions.Enterprises.Create, L("Permission:Create"));
            enterpriseProductionLinePermission.AddChild(SolutionPermissions.Enterprises.Update, L("Permission:Update"));
            enterpriseProductionLinePermission.AddChild(SolutionPermissions.Enterprises.Delete, L("Permission:Delete"));

            var enterpriseSitePermission = myGroup.AddPermission(SolutionPermissions.Enterprises.Default, L("Permission:Enterprises"));
            enterpriseSitePermission.AddChild(SolutionPermissions.Enterprises.Create, L("Permission:Create"));
            enterpriseSitePermission.AddChild(SolutionPermissions.Enterprises.Update, L("Permission:Update"));
            enterpriseSitePermission.AddChild(SolutionPermissions.Enterprises.Delete, L("Permission:Delete"));

            var enterpriseWorkCenterPermission = myGroup.AddPermission(SolutionPermissions.Enterprises.Default, L("Permission:Enterprises"));
            enterpriseWorkCenterPermission.AddChild(SolutionPermissions.Enterprises.Create, L("Permission:Create"));
            enterpriseWorkCenterPermission.AddChild(SolutionPermissions.Enterprises.Update, L("Permission:Update"));
            enterpriseWorkCenterPermission.AddChild(SolutionPermissions.Enterprises.Delete, L("Permission:Delete"));

            var enterpriseWorkLocationPermission = myGroup.AddPermission(SolutionPermissions.Enterprises.Default, L("Permission:Enterprises"));
            enterpriseWorkLocationPermission.AddChild(SolutionPermissions.Enterprises.Create, L("Permission:Create"));
            enterpriseWorkLocationPermission.AddChild(SolutionPermissions.Enterprises.Update, L("Permission:Update"));
            enterpriseWorkLocationPermission.AddChild(SolutionPermissions.Enterprises.Delete, L("Permission:Delete"));

            var equipmentPermission = myGroup.AddPermission(SolutionPermissions.Equipments.Default, L("Permission:Equipments"));
            equipmentPermission.AddChild(SolutionPermissions.Equipments.Create, L("Permission:Create"));
            equipmentPermission.AddChild(SolutionPermissions.Equipments.Update, L("Permission:Update"));
            equipmentPermission.AddChild(SolutionPermissions.Equipments.Delete, L("Permission:Delete"));

            var equipmentBrandPermission = myGroup.AddPermission(SolutionPermissions.Equipments.Default, L("Permission:Equipments"));
            equipmentBrandPermission.AddChild(SolutionPermissions.Equipments.Create, L("Permission:Create"));
            equipmentBrandPermission.AddChild(SolutionPermissions.Equipments.Update, L("Permission:Update"));
            equipmentBrandPermission.AddChild(SolutionPermissions.Equipments.Delete, L("Permission:Delete"));

            var equipmentInspectionPermission = myGroup.AddPermission(SolutionPermissions.Equipments.Default, L("Permission:Equipments"));
            equipmentInspectionPermission.AddChild(SolutionPermissions.Equipments.Create, L("Permission:Create"));
            equipmentInspectionPermission.AddChild(SolutionPermissions.Equipments.Update, L("Permission:Update"));
            equipmentInspectionPermission.AddChild(SolutionPermissions.Equipments.Delete, L("Permission:Delete"));

            var equipmentInspectionResultPermission = myGroup.AddPermission(SolutionPermissions.Equipments.Default, L("Permission:Equipments"));
            equipmentInspectionResultPermission.AddChild(SolutionPermissions.Equipments.Create, L("Permission:Create"));
            equipmentInspectionResultPermission.AddChild(SolutionPermissions.Equipments.Update, L("Permission:Update"));
            equipmentInspectionResultPermission.AddChild(SolutionPermissions.Equipments.Delete, L("Permission:Delete"));

            var equipmentMaintenancePermission = myGroup.AddPermission(SolutionPermissions.Equipments.Default, L("Permission:Equipments"));
            equipmentMaintenancePermission.AddChild(SolutionPermissions.Equipments.Create, L("Permission:Create"));
            equipmentMaintenancePermission.AddChild(SolutionPermissions.Equipments.Update, L("Permission:Update"));
            equipmentMaintenancePermission.AddChild(SolutionPermissions.Equipments.Delete, L("Permission:Delete"));

            var equipmentMaintenanceResultPermission = myGroup.AddPermission(SolutionPermissions.Equipments.Default, L("Permission:Equipments"));
            equipmentMaintenanceResultPermission.AddChild(SolutionPermissions.Equipments.Create, L("Permission:Create"));
            equipmentMaintenanceResultPermission.AddChild(SolutionPermissions.Equipments.Update, L("Permission:Update"));
            equipmentMaintenanceResultPermission.AddChild(SolutionPermissions.Equipments.Delete, L("Permission:Delete"));

            var equipmentSparePartPermission = myGroup.AddPermission(SolutionPermissions.Equipments.Default, L("Permission:Equipments"));
            equipmentSparePartPermission.AddChild(SolutionPermissions.Equipments.Create, L("Permission:Create"));
            equipmentSparePartPermission.AddChild(SolutionPermissions.Equipments.Update, L("Permission:Update"));
            equipmentSparePartPermission.AddChild(SolutionPermissions.Equipments.Delete, L("Permission:Delete"));

            var equipmentSparePartTypePermission = myGroup.AddPermission(SolutionPermissions.Equipments.Default, L("Permission:Equipments"));
            equipmentSparePartTypePermission.AddChild(SolutionPermissions.Equipments.Create, L("Permission:Create"));
            equipmentSparePartTypePermission.AddChild(SolutionPermissions.Equipments.Update, L("Permission:Update"));
            equipmentSparePartTypePermission.AddChild(SolutionPermissions.Equipments.Delete, L("Permission:Delete"));

            var equipmentStatusPermission = myGroup.AddPermission(SolutionPermissions.Equipments.Default, L("Permission:Equipments"));
            equipmentStatusPermission.AddChild(SolutionPermissions.Equipments.Create, L("Permission:Create"));
            equipmentStatusPermission.AddChild(SolutionPermissions.Equipments.Update, L("Permission:Update"));
            equipmentStatusPermission.AddChild(SolutionPermissions.Equipments.Delete, L("Permission:Delete"));

            var equipmentTypePermission = myGroup.AddPermission(SolutionPermissions.Equipments.Default, L("Permission:Equipments"));
            equipmentTypePermission.AddChild(SolutionPermissions.Equipments.Create, L("Permission:Create"));
            equipmentTypePermission.AddChild(SolutionPermissions.Equipments.Update, L("Permission:Update"));
            equipmentTypePermission.AddChild(SolutionPermissions.Equipments.Delete, L("Permission:Delete"));

            var materialPermission = myGroup.AddPermission(SolutionPermissions.Materials.Default, L("Permission:Materials"));
            materialPermission.AddChild(SolutionPermissions.Materials.Create, L("Permission:Create"));
            materialPermission.AddChild(SolutionPermissions.Materials.Update, L("Permission:Update"));
            materialPermission.AddChild(SolutionPermissions.Materials.Delete, L("Permission:Delete"));

            var productPermission = myGroup.AddPermission(SolutionPermissions.Materials.Default, L("Permission:Materials"));
            productPermission.AddChild(SolutionPermissions.Materials.Create, L("Permission:Create"));
            productPermission.AddChild(SolutionPermissions.Materials.Update, L("Permission:Update"));
            productPermission.AddChild(SolutionPermissions.Materials.Delete, L("Permission:Delete"));

            var productTypePermission = myGroup.AddPermission(SolutionPermissions.Materials.Default, L("Permission:Materials"));
            productTypePermission.AddChild(SolutionPermissions.Materials.Create, L("Permission:Create"));
            productTypePermission.AddChild(SolutionPermissions.Materials.Update, L("Permission:Update"));
            productTypePermission.AddChild(SolutionPermissions.Materials.Delete, L("Permission:Delete"));

            var bOMPermission = myGroup.AddPermission(SolutionPermissions.Materials.Default, L("Permission:Materials"));
            bOMPermission.AddChild(SolutionPermissions.Materials.Create, L("Permission:Create"));
            bOMPermission.AddChild(SolutionPermissions.Materials.Update, L("Permission:Update"));
            bOMPermission.AddChild(SolutionPermissions.Materials.Delete, L("Permission:Delete"));

            var unitPermission = myGroup.AddPermission(SolutionPermissions.Public.Default, L("Permission:Public"));
            unitPermission.AddChild(SolutionPermissions.Public.Create, L("Permission:Create"));
            unitPermission.AddChild(SolutionPermissions.Public.Update, L("Permission:Update"));
            unitPermission.AddChild(SolutionPermissions.Public.Delete, L("Permission:Delete"));

            var qualityInspectPermission = myGroup.AddPermission(SolutionPermissions.Qualities.Default, L("Permission:Qualities"));
            qualityInspectPermission.AddChild(SolutionPermissions.Qualities.Create, L("Permission:Create"));
            qualityInspectPermission.AddChild(SolutionPermissions.Qualities.Update, L("Permission:Update"));
            qualityInspectPermission.AddChild(SolutionPermissions.Qualities.Delete, L("Permission:Delete"));

            var qualityInspectResultPermission = myGroup.AddPermission(SolutionPermissions.Qualities.Default, L("Permission:Qualities"));
            qualityInspectResultPermission.AddChild(SolutionPermissions.Qualities.Create, L("Permission:Create"));
            qualityInspectResultPermission.AddChild(SolutionPermissions.Qualities.Update, L("Permission:Update"));
            qualityInspectResultPermission.AddChild(SolutionPermissions.Qualities.Delete, L("Permission:Delete"));

            var qualityInspectTypePermission = myGroup.AddPermission(SolutionPermissions.Qualities.Default, L("Permission:Qualities"));
            qualityInspectTypePermission.AddChild(SolutionPermissions.Qualities.Create, L("Permission:Create"));
            qualityInspectTypePermission.AddChild(SolutionPermissions.Qualities.Update, L("Permission:Update"));
            qualityInspectTypePermission.AddChild(SolutionPermissions.Qualities.Delete, L("Permission:Delete"));

            var qualityProblemLibPermission = myGroup.AddPermission(SolutionPermissions.Qualities.Default, L("Permission:Qualities"));
            qualityProblemLibPermission.AddChild(SolutionPermissions.Qualities.Create, L("Permission:Create"));
            qualityProblemLibPermission.AddChild(SolutionPermissions.Qualities.Update, L("Permission:Update"));
            qualityProblemLibPermission.AddChild(SolutionPermissions.Qualities.Delete, L("Permission:Delete"));

            var supplierLevelPermission = myGroup.AddPermission(SolutionPermissions.Suppliers.Default, L("Permission:Suppliers"));
            supplierLevelPermission.AddChild(SolutionPermissions.Suppliers.Create, L("Permission:Create"));
            supplierLevelPermission.AddChild(SolutionPermissions.Suppliers.Update, L("Permission:Update"));
            supplierLevelPermission.AddChild(SolutionPermissions.Suppliers.Delete, L("Permission:Delete"));

            var warehousePermission = myGroup.AddPermission(SolutionPermissions.Warehouses.Default, L("Permission:Warehouses"));
            warehousePermission.AddChild(SolutionPermissions.Warehouses.Create, L("Permission:Create"));
            warehousePermission.AddChild(SolutionPermissions.Warehouses.Update, L("Permission:Update"));
            warehousePermission.AddChild(SolutionPermissions.Warehouses.Delete, L("Permission:Delete"));

            var warehouseAreaPermission = myGroup.AddPermission(SolutionPermissions.Warehouses.Default, L("Permission:Warehouses"));
            warehouseAreaPermission.AddChild(SolutionPermissions.Warehouses.Create, L("Permission:Create"));
            warehouseAreaPermission.AddChild(SolutionPermissions.Warehouses.Update, L("Permission:Update"));
            warehouseAreaPermission.AddChild(SolutionPermissions.Warehouses.Delete, L("Permission:Delete"));

            var wareHouseLocationPermission = myGroup.AddPermission(SolutionPermissions.Warehouses.Default, L("Permission:Warehouses"));
            wareHouseLocationPermission.AddChild(SolutionPermissions.Warehouses.Create, L("Permission:Create"));
            wareHouseLocationPermission.AddChild(SolutionPermissions.Warehouses.Update, L("Permission:Update"));
            wareHouseLocationPermission.AddChild(SolutionPermissions.Warehouses.Delete, L("Permission:Delete"));

            var warehouseTypePermission = myGroup.AddPermission(SolutionPermissions.Warehouses.Default, L("Permission:Warehouses"));
            warehouseTypePermission.AddChild(SolutionPermissions.Warehouses.Create, L("Permission:Create"));
            warehouseTypePermission.AddChild(SolutionPermissions.Warehouses.Update, L("Permission:Update"));
            warehouseTypePermission.AddChild(SolutionPermissions.Warehouses.Delete, L("Permission:Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SolutionResource>(name);
        }
    }
}
