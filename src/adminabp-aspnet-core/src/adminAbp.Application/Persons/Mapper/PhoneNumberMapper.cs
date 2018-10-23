
using AutoMapper;
using adminAbp.Persons;
using adminAbp.Persons.Dtos;

namespace adminAbp.Persons.Mapper
{

	/// <summary>
    /// 配置PhoneNumber的AutoMapper
    /// </summary>
	internal static class PhoneNumberMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <PhoneNumber,PhoneNumberListDto>();
            configuration.CreateMap <PhoneNumberListDto,PhoneNumber>();

            configuration.CreateMap <PhoneNumberEditDto,PhoneNumber>();
            configuration.CreateMap <PhoneNumber,PhoneNumberEditDto>();

        }
	}
}
