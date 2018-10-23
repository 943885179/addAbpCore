

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using adminAbp.Citys;

namespace adminAbp.Citys.Dtos
{
    public class CityListDto : EntityDto 
    {

        
		/// <summary>
		/// name
		/// </summary>
		[Required(ErrorMessage="name不能为空")]
		public string name { get; set; }




    }
}