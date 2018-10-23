

using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using adminAbp.Persons;


namespace adminAbp.Persons.DomainService
{
    public interface IPhoneNumberManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        ///</summary>
        void InitPhoneNumber();



		 
      
         

    }
}
