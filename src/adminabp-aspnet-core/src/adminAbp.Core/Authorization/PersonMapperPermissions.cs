

namespace adminAbp.AbpDapper.Person.Authorization
{
	/// <summary>
    /// 定义系统的权限名称的字符串常量。
    /// <see cref="PersonMapperAuthorizationProvider" />中对权限的定义.
    ///</summary>
	public static  class PersonMapperPermissions
	{
		/// <summary>
		/// PersonMapper权限节点
		///</summary>
		public const string Node = "Pages.PersonMapper";

		/// <summary>
		/// PersonMapper查询授权
		///</summary>
		public const string Query = "Pages.PersonMapper.Query";

		/// <summary>
		/// PersonMapper创建权限
		///</summary>
		public const string Create = "Pages.PersonMapper.Create";

		/// <summary>
		/// PersonMapper修改权限
		///</summary>
		public const string Edit = "Pages.PersonMapper.Edit";

		/// <summary>
		/// PersonMapper删除权限
		///</summary>
		public const string Delete = "Pages.PersonMapper.Delete";

        /// <summary>
		/// PersonMapper批量删除权限
		///</summary>
		public const string BatchDelete = "Pages.PersonMapper.BatchDelete";

		/// <summary>
		/// PersonMapper导出Excel
		///</summary>
		public const string ExportExcel="Pages.PersonMapper.ExportExcel";

		 
		 
         
    }

}

