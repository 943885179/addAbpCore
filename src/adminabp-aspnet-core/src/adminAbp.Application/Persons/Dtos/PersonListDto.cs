

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using adminAbp.Persons;

namespace adminAbp.Persons.Dtos
{
    public class PersonListDto : FullAuditedEntityDto 
    {

        
		/// <summary>
		/// name
		/// </summary>
[MaxLength(50)]
		[Required(ErrorMessage="name不能为空")]
		public string name { get; set; }



		/// <summary>
		/// address
		/// </summary>
[MaxLength(200)]
		public string address { get; set; }



		/// <summary>
		/// emalill
		/// </summary>
[MaxLength(80)]
		public string emalill { get; set; }




    }
}