using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Domain.Entities;

namespace adminAbp.Citys
{
    public class City:Entity
    {
        [Required]
        public string  name { get; set; }
    }
}
