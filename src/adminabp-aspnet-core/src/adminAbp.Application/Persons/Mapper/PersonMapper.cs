
using AutoMapper;
using adminAbp.Persons;
using adminAbp.Persons.Dtos;

namespace adminAbp.Persons.Mapper
{

	/// <summary>
    /// 配置Person的AutoMapper
    /// </summary>
	internal static class PersonMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <Person,PersonListDto>();
            configuration.CreateMap <PersonListDto,Person>();

            configuration.CreateMap <PersonEditDto,Person>();
            configuration.CreateMap <Person,PersonEditDto>();

        }
	}
}
