

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using adminAbp.Persons;

namespace adminAbp.Persons.Dtos
{
    public class PhoneNumberListDto : EntityDto<long>,IHasCreationTime 
    {

        
		/// <summary>
		/// Number
		/// </summary>
[MaxLength(11)]
		[Required(ErrorMessage="Number不能为空")]
		public string Number { get; set; }



		/// <summary>
		/// Type
		/// </summary>
		public PhoneType Type { get; set; }



		/// <summary>
		/// PersonId
		/// </summary>
		public int PersonId { get; set; }



		/// <summary>
		/// Person
		/// </summary>
		public Person Person { get; set; }



		/// <summary>
		/// CreationTime
		/// </summary>
		public DateTime CreationTime { get; set; }




    }
}