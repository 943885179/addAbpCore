
using AutoMapper;
using adminAbp.Citys;
using adminAbp.Citys.Dtos;

namespace adminAbp.Citys.Mapper
{

	/// <summary>
    /// 配置City的AutoMapper
    /// </summary>
	internal static class CityMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <City,CityListDto>();
            configuration.CreateMap <CityListDto,City>();

            configuration.CreateMap <CityEditDto,City>();
            configuration.CreateMap <City,CityEditDto>();

        }
	}
}
