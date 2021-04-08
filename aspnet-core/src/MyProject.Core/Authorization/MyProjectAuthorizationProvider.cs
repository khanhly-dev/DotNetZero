using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace MyProject.Authorization
{
    public class MyProjectAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Users_Activation, L("UsersActivation"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            //phan quyen cha con
            var danhMuc = context.CreatePermission(PermissionNames.Pages_DanhMuc, L("Pages_DanhMuc"));
            danhMuc.CreateChildPermission(PermissionNames.Pages_DanhMuc_Tinh, L("Pages_DanhMuc_Tinh"));
        }


        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, MyProjectConsts.LocalizationSourceName);
        }
    }
}
