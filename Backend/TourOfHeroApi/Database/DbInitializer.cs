using Microsoft.EntityFrameworkCore;

namespace TourOfHeroApi.Database;

public static class DatabaseComponent
{
    public static IHost Migrate<T>(this IHost host) where T : DbContext
    {
        using var scope = host.Services.GetService<IServiceScopeFactory>()?.CreateScope();
        using var dbContext = scope?.ServiceProvider.GetRequiredService<T>();
        dbContext?.Database.Migrate();
        return host;
    }
}
