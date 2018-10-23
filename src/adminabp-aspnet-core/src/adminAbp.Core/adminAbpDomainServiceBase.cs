

using Abp.Domain.Services;

namespace adminAbp
{
	public abstract class adminAbpDomainServiceBase : DomainService
	{
		/* Add your common members for all your domain services. */
		/*在领域服务中添加你的自定义公共方法*/





		protected adminAbpDomainServiceBase()
		{
			LocalizationSourceName = adminAbpConsts.LocalizationSourceName;
		}
	}
}
