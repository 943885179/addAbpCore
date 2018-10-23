
using Abp.Runtime.Validation;
using adminAbp.Dtos;
using adminAbp.Persons;

namespace adminAbp.Persons.Dtos
{
    public class GetPersonsInput : PagedSortedAndFilteredInputDto, IShouldNormalize
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
