using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace adminAbp.Persons
{

    /// <summary>
    /// 电话本
    /// </summary>
    public class PhoneNumber:Entity<long>,IHasCreationTime
    {
        [Required]
        [MaxLength(11)]
        public string Number { get; set; }
        public PhoneType Type { get; set; }

        public int PersonId { get; set; }

        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
