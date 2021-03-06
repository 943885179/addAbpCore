

using System.Linq;
using Abp.Authorization;
using Abp.Localization;
using adminAbp.Authorization;

namespace adminAbp.Persons.Authorization
{
    /// <summary>
    /// 权限配置都在这里。
    /// 给权限默认设置服务
    /// See <see cref="PersonPermissions" /> for all permission names. Person
    ///</summary>
    public class PersonAuthorizationProvider : AuthorizationProvider
    {
		public override void SetPermissions(IPermissionDefinitionContext context)
		{
			// 在这里配置了Person 的权限。
			var pages = context.GetPermissionOrNull(AppLtmPermissions.Pages) ?? context.CreatePermission(AppLtmPermissions.Pages, L("Pages"));

			var administration = pages.Children.FirstOrDefault(p => p.Name == AppLtmPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppLtmPermissions.Pages_Administration, L("Administration"));

			var entityPermission = administration.CreateChildPermission(PersonPermissions.Node , L("Person"));
			entityPermission.CreateChildPermission(PersonPermissions.Query, L("QueryPerson"));
			entityPermission.CreateChildPermission(PersonPermissions.Create, L("CreatePerson"));
			entityPermission.CreateChildPermission(PersonPermissions.Edit, L("EditPerson"));
			entityPermission.CreateChildPermission(PersonPermissions.Delete, L("DeletePerson"));
			entityPermission.CreateChildPermission(PersonPermissions.BatchDelete, L("BatchDeletePerson"));
			entityPermission.CreateChildPermission(PersonPermissions.ExportExcel, L("ExportExcelPerson"));



			 
			 
			 
		}

		private static ILocalizableString L(string name)
		{
			return new LocalizableString(name, adminAbpConsts.LocalizationSourceName);
		}
    }
}