using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities.Auditing;

namespace adminAbp.Persons
{
    /*
    Entity<long> /Entity :父类Entity具有主键属性Id 默认是 int类型
    IHasCreationTime:创建时候自动设置当前时间
    IHasCreationAudited：创建人id+时间
    IModificationAudited：最后修改人+时间
    IAudited:IHasCreationAudited+IModificationAudited
    ISoftDelete:逻辑删除，在abp中逻辑删除默认无法显示，要设置才行
    IDeletionAutited：软删除+删除时间
    IFullAuditedEntity：IAudited, IDeletionAudited 
    IPassivable：IsActive 判断属性:激活状态/闲置状态(Active/Passive),自定义查默认不排除
    IExtendableObject，可以轻松的将 任意name-value数据,ExtensionData 显示报错使用setData赋值，getData取值
    */
    /// <summary>
    /// 人员
    /// </summary>
    [Table("Person")]
   public class Person:FullAuditedEntity
    {
        [Required]
        [MaxLength(50)]
        public string name { get; set; }
        [MaxLength(200)]
        public string address { get; set; }
        [EmailAddress]
        [MaxLength(80)]
        public string emalill { get; set; }
    }
}
