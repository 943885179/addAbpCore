

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using adminAbp.Persons;

namespace adminAbp.Persons.Dtos
{
    public class CreateOrUpdatePersonInput
    {
        [Required]
        public PersonEditDto Person { get; set; }

    }
}