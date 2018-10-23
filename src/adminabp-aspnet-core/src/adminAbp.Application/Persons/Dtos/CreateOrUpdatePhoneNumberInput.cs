

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using adminAbp.Persons;

namespace adminAbp.Persons.Dtos
{
    public class CreateOrUpdatePhoneNumberInput
    {
        [Required]
        public PhoneNumberEditDto PhoneNumber { get; set; }

    }
}