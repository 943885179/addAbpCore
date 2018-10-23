using System.Linq;
using Microsoft.EntityFrameworkCore;
using Abp.Configuration;
using Abp.Localization;
using Abp.Net.Mail;

namespace adminAbp.EntityFrameworkCore.Seed.Host
{
    public class DefaultSettingsCreator
    {
        private readonly adminAbpDbContext _context;

        public DefaultSettingsCreator(adminAbpDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            // Emailing
          /*  AddSettingIfNotExists(EmailSettingNames.DefaultFromAddress, "admin@52abp.com");
            AddSettingIfNotExists(EmailSettingNames.DefaultFromDisplayName, "mydomain.com mailer");*/

            AddSettingIfNotExists(EmailSettingNames.DefaultFromDisplayName, "faker");
            AddSettingIfNotExists(EmailSettingNames.DefaultFromAddress, "943885179@qq.com");//在发送邮件时，如果没有指定邮件发送者，该值会自动作为邮件的发送者(如上例所示)
            AddSettingIfNotExists(EmailSettingNames.Smtp.Host, "smtp.qq.com");
            AddSettingIfNotExists(EmailSettingNames.Smtp.Port, "587");
            AddSettingIfNotExists(EmailSettingNames.Smtp.UserName, "943885179@qq.com");
            AddSettingIfNotExists(EmailSettingNames.Smtp.Password, "qvknvptwqkbpbdgd");
            AddSettingIfNotExists(EmailSettingNames.Smtp.Domain, "");
            AddSettingIfNotExists(EmailSettingNames.Smtp.EnableSsl, "true");
            AddSettingIfNotExists(EmailSettingNames.Smtp.UseDefaultCredentials, "false");
            // Languages
            AddSettingIfNotExists(LocalizationSettingNames.DefaultLanguage, "zh-Hans");
        }

        private void AddSettingIfNotExists(string name, string value, int? tenantId = null)
        {
            if (_context.Settings.IgnoreQueryFilters().Any(s => s.Name == name && s.TenantId == tenantId && s.UserId == null))
            {
                return;
            }

            _context.Settings.Add(new Setting(tenantId, null, name, value));
            _context.SaveChanges();
        }
    }
}
