using System;
using System.Collections.Generic;
using System.Text;
using adminAbp.Persons;
using DapperExtensions.Mapper;

namespace adminAbp.AbpDapper.Dapper
{
    public class PersonMapper : ClassMapper<Persons.Person>
    {
       public PersonMapper()
        {
            Table("Person");
           // Map(x => x.Id).Ignore();排除
            AutoMap();
        }
    }
}
