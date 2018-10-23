

using System.Linq;
using Abp.Authorization;
using Abp.Localization;
using adminAbp.Authorization;

namespace adminAbp.AbpDapper.Person.Authorization
{
    /// <summary>
    /// 权限配置都在这里。
    /// 给权限默认设置服务
    /// See <see cref="PersonMapperPermissions" /> for all permission names. PersonMapper
    ///</summary>
    public class PersonMapperAuthorizationProvider : AuthorizationProvider
    {
		public override void SetPermissions(IPermissionDefinitionContext context)
		{
			// 在这里配置了PersonMapper 的权限。
			var pages = context.GetPermissionOrNull(AppLtmPermissions.Pages) ?? context.CreatePermission(AppLtmPermissions.Pages, L("Pages"));

			var administration = pages.Children.FirstOrDefault(p => p.Name == AppLtmPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppLtmPermissions.Pages_Administration, L("Administration"));

			var entityPermission = administration.CreateChildPermission(PersonMapperPermissions.Node , L("PersonMapper"));
			entityPermission.CreateChildPermission(PersonMapperPermissions.Query, L("QueryPersonMapper"));
			entityPermission.CreateChildPermission(PersonMapperPermissions.Create, L("CreatePersonMapper"));
			entityPermission.CreateChildPermission(PersonMapperPermissions.Edit, L("EditPersonMapper"));
			entityPermission.CreateChildPermission(PersonMapperPermissions.Delete, L("DeletePersonMapper"));
			entityPermission.CreateChildPermission(PersonMapperPermissions.BatchDelete, L("BatchDeletePersonMapper"));
			entityPermission.CreateChildPermission(PersonMapperPermissions.ExportExcel, L("ExportExcelPersonMapper"));



			 
			 
			 
		}

		private static ILocalizableString L(string name)
		{
			return new LocalizableString(name, adminAbpConsts.LocalizationSourceName);
		}
    }
}