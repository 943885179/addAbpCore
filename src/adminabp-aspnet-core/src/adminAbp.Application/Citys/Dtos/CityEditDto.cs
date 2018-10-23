
using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using adminAbp.Citys;

namespace  adminAbp.Citys.Dtos
{
    [AutoMapTo(typeof(City))]
    public class CityEditDto
    {

        /// <summary>
        /// Id
        /// </summary>
        public int? Id { get; set; }         


        
		/// <summary>
		/// name
		/// </summary>
		[Required(ErrorMessage="name不能为空")]
		public string name { get; set; }




    }
}