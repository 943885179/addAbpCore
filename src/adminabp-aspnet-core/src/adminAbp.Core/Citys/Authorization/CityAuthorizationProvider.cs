

using System.Linq;
using Abp.Authorization;
using Abp.Localization;
using adminAbp.Authorization;

namespace adminAbp.Citys.Authorization
{
    /// <summary>
    /// 权限配置都在这里。
    /// 给权限默认设置服务
    /// See <see cref="CityPermissions" /> for all permission names. City
    ///</summary>
    public class CityAuthorizationProvider : AuthorizationProvider
    {
		public override void SetPermissions(IPermissionDefinitionContext context)
		{
			// 在这里配置了City 的权限。
			var pages = context.GetPermissionOrNull(AppLtmPermissions.Pages) ?? context.CreatePermission(AppLtmPermissions.Pages, L("Pages"));

			var administration = pages.Children.FirstOrDefault(p => p.Name == AppLtmPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppLtmPermissions.Pages_Administration, L("Administration"));

			var entityPermission = administration.CreateChildPermission(CityPermissions.Node , L("City"));
			entityPermission.CreateChildPermission(CityPermissions.Query, L("QueryCity"));
			entityPermission.CreateChildPermission(CityPermissions.Create, L("CreateCity"));
			entityPermission.CreateChildPermission(CityPermissions.Edit, L("EditCity"));
			entityPermission.CreateChildPermission(CityPermissions.Delete, L("DeleteCity"));
			entityPermission.CreateChildPermission(CityPermissions.BatchDelete, L("BatchDeleteCity"));
			entityPermission.CreateChildPermission(CityPermissions.ExportExcel, L("ExportExcelCity"));



			 
			 
			 
		}

		private static ILocalizableString L(string name)
		{
			return new LocalizableString(name, adminAbpConsts.LocalizationSourceName);
		}
    }
}