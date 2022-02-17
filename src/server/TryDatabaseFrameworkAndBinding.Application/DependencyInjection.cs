using Microsoft.Extensions.DependencyInjection;
using TryDatabaseFrameworkAndBinding.Application.Services;

namespace TryDatabaseFrameworkAndBinding.Application;
public class DependencyInjection
{
	public static IServiceCollection AddApplication(this IServiceCollection services, IDatabaseSetting databaseSetting)
	{
		services.AddScoped<ITryDatabaseFrameworkAndBindingService, TryDatabaseFrameworkAndBindingService>();
		services.AddInfrastructure(databaseSetting);

		return services;
	}
}
