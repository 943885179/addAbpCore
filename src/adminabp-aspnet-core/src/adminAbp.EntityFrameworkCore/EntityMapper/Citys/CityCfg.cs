

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using adminAbp.Citys;

namespace adminAbp.EntityMapper.Citys
{
    public class CityCfg : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {

            builder.ToTable("Citys", YoYoAbpefCoreConsts.SchemaNames.CMS);

            
			builder.Property(a => a.name).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);


        }
    }
}


