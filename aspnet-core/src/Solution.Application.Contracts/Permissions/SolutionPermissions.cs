namespace Solution.Permissions
{
    public static class SolutionPermissions
    {
        public const string GroupName = "Solution";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        public class Enterprises
        {
            public const string Default = GroupName + ".Enterprises";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }


        public class Equipments
        {
            public const string Default = GroupName + ".Equipments";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }


        public class Materials
        {
            public const string Default = GroupName + ".Materials";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }


        public class Public
        {
            public const string Default = GroupName + ".Public";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }


        public class Qualities
        {
            public const string Default = GroupName + ".Qualities";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }


        public class Suppliers
        {
            public const string Default = GroupName + ".Suppliers";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }


        public class Warehouses
        {
            public const string Default = GroupName + ".Warehouses";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

    }
}
