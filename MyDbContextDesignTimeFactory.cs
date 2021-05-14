using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace EFCoreAlterColumnNoLongerWorking
{
    public class YastahDbContextDesignTimeFactory
        : IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args)
            => new ServiceCollection()
                .AddDbContext<MyDbContext>(optionsBuilder => optionsBuilder
                    .UseNpgsql(MyDbContext.ConnectionString))
                .BuildServiceProvider()
                .GetRequiredService<MyDbContext>();
    }
}
