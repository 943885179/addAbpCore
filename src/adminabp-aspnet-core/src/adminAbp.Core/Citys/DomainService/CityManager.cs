

using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Abp.Linq;
using Abp.Linq.Extensions;
using Abp.Extensions;
using Abp.UI;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

using adminAbp;
using adminAbp.Citys;


namespace adminAbp.Citys.DomainService
{
    /// <summary>
    /// City领域层的业务管理
    ///</summary>
    public class CityManager :adminAbpDomainServiceBase, ICityManager
    {
		
		private readonly IRepository<City,int> _repository;

		/// <summary>
		/// City的构造方法
		///</summary>
		public CityManager(
			IRepository<City, int> repository
		)
		{
			_repository =  repository;
		}


		/// <summary>
		/// 初始化
		///</summary>
		public void InitCity()
		{
			throw new NotImplementedException();
		}

		// TODO:编写领域业务代码



		 
		  
		 

	}
}
