using System;
using System.Collections.Generic;
using System.Text;
using Abp.Dapper.Repositories;
using Abp.Dependency;
using Abp.Domain.Repositories;

namespace adminAbp.AbpDapper.Dapper
{
    public class SomeApplicationService : ITransientDependency
    {
        private readonly IDapperRepository<Persons.Person> _personDapperRepository;
        private readonly IRepository<Persons.Person> _personRepository;

        public SomeApplicationService(
            IRepository<Persons.Person> personRepository,
            IDapperRepository<Persons.Person> personDapperRepository)
        {
            _personRepository = personRepository;
            _personDapperRepository = personDapperRepository;
        }

        public void DoSomeStuff()
        {
            var people = _personDapperRepository.Query("select * from Person");
        }
    }
}
