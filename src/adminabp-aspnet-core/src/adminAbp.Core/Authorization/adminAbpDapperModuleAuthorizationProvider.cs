

using System.Linq;
using Abp.Authorization;
using Abp.Localization;
using adminAbp.Authorization;

namespace adminAbp.AbpDapper.Authorization
{
    /// <summary>
    /// 权限配置都在这里。
    /// 给权限默认设置服务
    /// See <see cref="adminAbpDapperModulePermissions" /> for all permission names. adminAbpDapperModule
    ///</summary>
    public class adminAbpDapperModuleAuthorizationProvider : AuthorizationProvider
    {
		public override void SetPermissions(IPermissionDefinitionContext context)
		{
			// 在这里配置了adminAbpDapperModule 的权限。
			var pages = context.GetPermissionOrNull(AppLtmPermissions.Pages) ?? context.CreatePermission(AppLtmPermissions.Pages, L("Pages"));

			var administration = pages.Children.FirstOrDefault(p => p.Name == AppLtmPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppLtmPermissions.Pages_Administration, L("Administration"));

			var entityPermission = administration.CreateChildPermission(adminAbpDapperModulePermissions.Node , L("adminAbpDapperModule"));
			entityPermission.CreateChildPermission(adminAbpDapperModulePermissions.Query, L("QueryadminAbpDapperModule"));
			entityPermission.CreateChildPermission(adminAbpDapperModulePermissions.Create, L("CreateadminAbpDapperModule"));
			entityPermission.CreateChildPermission(adminAbpDapperModulePermissions.Edit, L("EditadminAbpDapperModule"));
			entityPermission.CreateChildPermission(adminAbpDapperModulePermissions.Delete, L("DeleteadminAbpDapperModule"));
			entityPermission.CreateChildPermission(adminAbpDapperModulePermissions.BatchDelete, L("BatchDeleteadminAbpDapperModule"));
			entityPermission.CreateChildPermission(adminAbpDapperModulePermissions.ExportExcel, L("ExportExceladminAbpDapperModule"));



			 
			 
			 
		}

		private static ILocalizableString L(string name)
		{
			return new LocalizableString(name, adminAbpConsts.LocalizationSourceName);
		}
    }
}