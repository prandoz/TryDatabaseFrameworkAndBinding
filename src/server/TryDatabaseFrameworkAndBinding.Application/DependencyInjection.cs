using Microsoft.Extensions.DependencyInjection;
using TryDatabaseFrameworkAndBinding.Application.Services;
using TryDatabaseFrameworkAndBinding.Common.Interfaces.Services;
using TryDatabaseFrameworkAndBinding.Common.Interfaces.Settings;
using TryDatabaseFrameworkAndBinding.Infrastructure;

namespace TryDatabaseFrameworkAndBinding.Application;
public static class DependencyInjection
{
	public static IServiceCollection AddApplication(this IServiceCollection services, IDatabaseSetting databaseSetting)
	{
		services.AddScoped<ITryDatabaseFrameworkAndBindingService, TryDatabaseFrameworkAndBindingService>();
		services.AddInfrastructure(databaseSetting);

		return services;
	}
}
