

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using adminAbp.Citys;

namespace adminAbp.Citys.Dtos
{
    public class CreateOrUpdateCityInput
    {
        [Required]
        public CityEditDto City { get; set; }

    }
}