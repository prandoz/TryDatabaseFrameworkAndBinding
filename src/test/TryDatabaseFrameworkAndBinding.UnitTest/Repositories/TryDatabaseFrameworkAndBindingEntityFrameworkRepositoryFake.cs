using System;
using Bogus;
using Microsoft.EntityFrameworkCore;
using TryDatabaseFrameworkAndBinding.Infrastructure;
using TryDatabaseFrameworkAndBinding.Infrastructure.Repositories;
using TryDatabaseFrameworkAndBinding.UnitTest.Settings;

namespace TryDatabaseFrameworkAndBinding.UnitTest.Repositories;

internal static class TryDatabaseFrameworkAndBindingEntityFrameworkRepositoryFake
{
	public static TryDatabaseFrameworkAndBindingEntityFrameworkRepository Initialize()
	{
		var dbName = new Faker();

		var tryDatabaseFrameworkAndBindingEntityFrameworkRepository =
			new TryDatabaseFrameworkAndBindingEntityFrameworkRepository(
				new TryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext(
					new DbContextOptionsBuilder<TryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext>()
						.UseSqlServer(DatabaseConnection.connectionString, dbOptions => dbOptions.EnableRetryOnFailure(5, TimeSpan.FromSeconds(3), null)).Options));

		return tryDatabaseFrameworkAndBindingEntityFrameworkRepository;
	}
}
