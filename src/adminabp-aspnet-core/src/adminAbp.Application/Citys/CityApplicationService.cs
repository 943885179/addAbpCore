
using System;
using System.Data;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using Abp.UI;
using Abp.AutoMapper;
using Abp.Extensions;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Application.Services.Dto;
using Abp.Linq.Extensions;


using adminAbp.Citys;
using adminAbp.Citys.Dtos;
using adminAbp.Citys.DomainService;
using adminAbp.Citys.Authorization;


namespace adminAbp.Citys
{
    /// <summary>
    /// City应用层服务的接口实现方法  
    ///</summary>
    [AbpAuthorize]
    public class CityAppService : adminAbpAppServiceBase, ICityAppService
    {
        private readonly IRepository<City, int> _entityRepository;

        private readonly ICityManager _entityManager;

        /// <summary>
        /// 构造函数 
        ///</summary>
        public CityAppService(
        IRepository<City, int> entityRepository
        ,ICityManager entityManager
        )
        {
            _entityRepository = entityRepository; 
             _entityManager=entityManager;
        }


        /// <summary>
        /// 获取City的分页列表信息
        ///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
		[AbpAuthorize(CityPermissions.Query)] 
        public async Task<PagedResultDto<CityListDto>> GetPaged(GetCitysInput input)
		{

		    var query = _entityRepository.GetAll();
			// TODO:根据传入的参数添加过滤条件
            

			var count = await query.CountAsync();

			var entityList = await query
					.OrderBy(input.Sorting).AsNoTracking()
					.PageBy(input)
					.ToListAsync();

			// var entityListDtos = ObjectMapper.Map<List<CityListDto>>(entityList);
			var entityListDtos =entityList.MapTo<List<CityListDto>>();

			return new PagedResultDto<CityListDto>(count,entityListDtos);
		}


		/// <summary>
		/// 通过指定id获取CityListDto信息
		/// </summary>
		[AbpAuthorize(CityPermissions.Query)] 
		public async Task<CityListDto> GetById(EntityDto<int> input)
		{
			var entity = await _entityRepository.GetAsync(input.Id);

		    return entity.MapTo<CityListDto>();
		}

		/// <summary>
		/// 获取编辑 City
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(CityPermissions.Create,CityPermissions.Edit)]
		public async Task<GetCityForEditOutput> GetForEdit(NullableIdDto<int> input)
		{
			var output = new GetCityForEditOutput();
CityEditDto editDto;

			if (input.Id.HasValue)
			{
				var entity = await _entityRepository.GetAsync(input.Id.Value);

				editDto = entity.MapTo<CityEditDto>();

				//cityEditDto = ObjectMapper.Map<List<cityEditDto>>(entity);
			}
			else
			{
				editDto = new CityEditDto();
			}

			output.City = editDto;
			return output;
		}


		/// <summary>
		/// 添加或者修改City的公共方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(CityPermissions.Create,CityPermissions.Edit)]
		public async Task CreateOrUpdate(CreateOrUpdateCityInput input)
		{

			if (input.City.Id.HasValue)
			{
				await Update(input.City);
			}
			else
			{
				await Create(input.City);
			}
		}


		/// <summary>
		/// 新增City
		/// </summary>
		[AbpAuthorize(CityPermissions.Create)]
		protected virtual async Task<CityEditDto> Create(CityEditDto input)
		{
			//TODO:新增前的逻辑判断，是否允许新增

            // var entity = ObjectMapper.Map <City>(input);
            var entity=input.MapTo<City>();
			

			entity = await _entityRepository.InsertAsync(entity);
			return entity.MapTo<CityEditDto>();
		}

		/// <summary>
		/// 编辑City
		/// </summary>
		[AbpAuthorize(CityPermissions.Edit)]
		protected virtual async Task Update(CityEditDto input)
		{
			//TODO:更新前的逻辑判断，是否允许更新

			var entity = await _entityRepository.GetAsync(input.Id.Value);
			input.MapTo(entity);

			// ObjectMapper.Map(input, entity);
		    await _entityRepository.UpdateAsync(entity);
		}



		/// <summary>
		/// 删除City信息的方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(CityPermissions.Delete)]
		public async Task Delete(EntityDto<int> input)
		{
			//TODO:删除前的逻辑判断，是否允许删除
			await _entityRepository.DeleteAsync(input.Id);
		}



		/// <summary>
		/// 批量删除City的方法
		/// </summary>
		[AbpAuthorize(CityPermissions.BatchDelete)]
		public async Task BatchDelete(List<int> input)
		{
			// TODO:批量删除前的逻辑判断，是否允许删除
			await _entityRepository.DeleteAsync(s => input.Contains(s.Id));
		}


		/// <summary>
		/// 导出City为excel表,等待开发。
		/// </summary>
		/// <returns></returns>
		//public async Task<FileDto> GetToExcel()
		//{
		//	var users = await UserManager.Users.ToListAsync();
		//	var userListDtos = ObjectMapper.Map<List<UserListDto>>(users);
		//	await FillRoleNames(userListDtos);
		//	return _userListExcelExporter.ExportToFile(userListDtos);
		//}

    }
}


