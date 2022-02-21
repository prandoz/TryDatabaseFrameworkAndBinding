using Bogus;
using TryDatabaseFrameworkAndBinding.Domain.Settings;
using TryDatabaseFrameworkAndBinding.Infrastructure;
using TryDatabaseFrameworkAndBinding.Infrastructure.Repositories;
using TryDatabaseFrameworkAndBinding.UnitTest.Settings;

namespace TryDatabaseFrameworkAndBinding.UnitTest.Repositories;

internal static class TryDatabaseFrameworkAndBindingDapperRepositoryFake
{
	public static TryDatabaseFrameworkAndBindingDapperRepository Initialize()
	{
		var dbName = new Faker();

		var tryDatabaseFrameworkAndBindingDapperRepository =
			new TryDatabaseFrameworkAndBindingDapperRepository(
				new TryDatabaseFrameworkAndBindingDapperDatabaseContext(
					new DatabaseSetting() { connectionString = DatabaseConnection.connectionString }));

		return tryDatabaseFrameworkAndBindingDapperRepository;
	}
}
