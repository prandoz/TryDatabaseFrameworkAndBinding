using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TryDatabaseFrameworkAndBinding.Common.Interfaces.Repositories;
using TryDatabaseFrameworkAndBinding.Common.Interfaces.Settings;
using TryDatabaseFrameworkAndBinding.Infrastructure.Repositories;

namespace TryDatabaseFrameworkAndBinding.Infrastructure;
public static class DependencyInjection
{
	public static IServiceCollection AddInfrastructure(this IServiceCollection services, IDatabaseSetting databaseSetting)
	{
		services.AddDbContext<TryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext>(options => options.UseSqlServer(databaseSetting.connectionString));
		services.AddScoped<ITryDatabaseFrameworkAndBindingEntityFrameworkRepository, TryDatabaseFrameworkAndBindingEntityFrameworkRepository>();

		services.AddScoped<TryDatabaseFrameworkAndBindingDapperDatabaseContext>();

		return services;
	}
}
