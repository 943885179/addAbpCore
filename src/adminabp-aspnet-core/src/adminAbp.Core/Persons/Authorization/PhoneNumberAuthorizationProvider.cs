

using System.Linq;
using Abp.Authorization;
using Abp.Localization;
using adminAbp.Authorization;

namespace adminAbp.Persons.Authorization
{
    /// <summary>
    /// 权限配置都在这里。
    /// 给权限默认设置服务
    /// See <see cref="PhoneNumberPermissions" /> for all permission names. PhoneNumber
    ///</summary>
    public class PhoneNumberAuthorizationProvider : AuthorizationProvider
    {
		public override void SetPermissions(IPermissionDefinitionContext context)
		{
			// 在这里配置了PhoneNumber 的权限。
			var pages = context.GetPermissionOrNull(AppLtmPermissions.Pages) ?? context.CreatePermission(AppLtmPermissions.Pages, L("Pages"));

			var administration = pages.Children.FirstOrDefault(p => p.Name == AppLtmPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppLtmPermissions.Pages_Administration, L("Administration"));

			var entityPermission = administration.CreateChildPermission(PhoneNumberPermissions.Node , L("PhoneNumber"));
			entityPermission.CreateChildPermission(PhoneNumberPermissions.Query, L("QueryPhoneNumber"));
			entityPermission.CreateChildPermission(PhoneNumberPermissions.Create, L("CreatePhoneNumber"));
			entityPermission.CreateChildPermission(PhoneNumberPermissions.Edit, L("EditPhoneNumber"));
			entityPermission.CreateChildPermission(PhoneNumberPermissions.Delete, L("DeletePhoneNumber"));
			entityPermission.CreateChildPermission(PhoneNumberPermissions.BatchDelete, L("BatchDeletePhoneNumber"));
			entityPermission.CreateChildPermission(PhoneNumberPermissions.ExportExcel, L("ExportExcelPhoneNumber"));



			 
			 
			 
		}

		private static ILocalizableString L(string name)
		{
			return new LocalizableString(name, adminAbpConsts.LocalizationSourceName);
		}
    }
}