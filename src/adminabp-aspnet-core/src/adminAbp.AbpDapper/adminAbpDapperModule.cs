using System;
using System.Collections.Generic;
using System.Reflection;
using Abp.Dapper;
using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace adminAbp.AbpDapper
{
    [DependsOn(
          typeof(AbpEntityFrameworkCoreModule), typeof(AbpDapperModule))]//通过注解来定义依赖关系
    public class adminAbpDapperModule : AbpModule
    {
        public override void Initialize() //初始化
        {
            IocManager.RegisterAssemblyByConvention(typeof(adminAbpApplicationModule).GetAssembly());
        
            //这里会自动去扫描程序集中配置好的映射关系
            DapperExtensions.DapperExtensions.SetMappingAssemblies(new List<Assembly> { typeof(adminAbpDapperModule).GetAssembly() });
            //这行代码的写法基本上是不变的。它的作用是把当前程序集的特定类或接口注册到依赖注入容器中。
        }
    }

}
