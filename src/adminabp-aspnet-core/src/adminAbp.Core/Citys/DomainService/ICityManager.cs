

using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using adminAbp.Citys;


namespace adminAbp.Citys.DomainService
{
    public interface ICityManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        ///</summary>
        void InitCity();



		 
      
         

    }
}
