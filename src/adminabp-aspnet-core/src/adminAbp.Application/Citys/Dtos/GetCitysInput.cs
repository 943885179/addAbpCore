
using Abp.Runtime.Validation;
using adminAbp.Dtos;
using adminAbp.Citys;

namespace adminAbp.Citys.Dtos
{
    public class GetCitysInput : PagedSortedAndFilteredInputDto, IShouldNormalize
    {

        /// <summary>
        /// 正常化排序使用
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }

    }
}
