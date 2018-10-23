
using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using adminAbp.Persons;

namespace  adminAbp.Persons.Dtos
{
    [AutoMapTo(typeof(Person))]
    public class PersonEditDto
    {

        /// <summary>
        /// Id
        /// </summary>
        public int? Id { get; set; }         


        
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