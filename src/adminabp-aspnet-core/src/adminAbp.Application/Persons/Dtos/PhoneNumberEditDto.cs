
using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using adminAbp.Persons;

namespace  adminAbp.Persons.Dtos
{
    [AutoMapTo(typeof(PhoneNumber))]
    public class PhoneNumberEditDto
    {

        /// <summary>
        /// Id
        /// </summary>
        public long? Id { get; set; }         


        
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