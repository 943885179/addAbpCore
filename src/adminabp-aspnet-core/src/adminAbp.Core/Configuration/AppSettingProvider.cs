using System.Collections.Generic;
using Abp.Configuration;
using Abp.Net.Mail;

namespace adminAbp.Configuration
{
    public class AppSettingProvider : SettingProvider
    {
        public override IEnumerable<SettingDefinition> GetSettingDefinitions(SettingDefinitionProviderContext context)
        {
            return new[]
            {new SettingDefinition(EmailSettingNames.DefaultFromAddress, "943885179@qq.com"),//在发送邮件时，如果没有指定邮件发送者，该值会自动作为邮件的发送者(如上例所示)
                new SettingDefinition(EmailSettingNames.DefaultFromAddress, "943885179@qq.com"),//在发送邮件时，如果没有指定邮件发送者，该值会自动作为邮件发送者的显示名(如上例所示)
                new SettingDefinition(EmailSettingNames.Smtp.Host, "smtp.qq.com" ),
            new SettingDefinition(EmailSettingNames.Smtp.Port, "587"),
            new SettingDefinition(EmailSettingNames.Smtp.UserName, "943885179@qq.com"),
            new SettingDefinition(EmailSettingNames.Smtp.Password, "qvknvptwqkbpbdgd"),
            new SettingDefinition(EmailSettingNames.Smtp.Domain, ""),
            new SettingDefinition(EmailSettingNames.Smtp.EnableSsl, "true"),
            new SettingDefinition(EmailSettingNames.Smtp.UseDefaultCredentials, "false"),
                new SettingDefinition(
                        "SmtpServerAddress",
                        "smtp.qq.com"
                        ),
                new SettingDefinition(AppSettingNames.UiTheme, "red",
                scopes: SettingScopes.Application | SettingScopes.Tenant | SettingScopes.User,
                isVisibleToClients: true)
            };
        }
    }
}
