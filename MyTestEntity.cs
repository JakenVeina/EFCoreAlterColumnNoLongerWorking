using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAlterColumnNoLongerWorking
{
    public class MyTestEntity
    {
        public long Id { get; set; }

        public MyTestType Type { get; set; }
    }

    public class MyTestEntityConfigurator
        : IEntityTypeConfiguration<MyTestEntity>
    {
        public void Configure(EntityTypeBuilder<MyTestEntity> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Type)
                .HasConversion<string>();

            builder
                .ToTable("Tests");
        }
    }
}
