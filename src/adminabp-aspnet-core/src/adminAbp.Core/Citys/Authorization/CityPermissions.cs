

namespace adminAbp.Citys.Authorization
{
	/// <summary>
    /// 定义系统的权限名称的字符串常量。
    /// <see cref="CityAuthorizationProvider" />中对权限的定义.
    ///</summary>
	public static  class CityPermissions
	{
		/// <summary>
		/// City权限节点
		///</summary>
		public const string Node = "Pages.City";

		/// <summary>
		/// City查询授权
		///</summary>
		public const string Query = "Pages.City.Query";

		/// <summary>
		/// City创建权限
		///</summary>
		public const string Create = "Pages.City.Create";

		/// <summary>
		/// City修改权限
		///</summary>
		public const string Edit = "Pages.City.Edit";

		/// <summary>
		/// City删除权限
		///</summary>
		public const string Delete = "Pages.City.Delete";

        /// <summary>
		/// City批量删除权限
		///</summary>
		public const string BatchDelete = "Pages.City.BatchDelete";

		/// <summary>
		/// City导出Excel
		///</summary>
		public const string ExportExcel="Pages.City.ExportExcel";

		 
		 
         
    }

}

