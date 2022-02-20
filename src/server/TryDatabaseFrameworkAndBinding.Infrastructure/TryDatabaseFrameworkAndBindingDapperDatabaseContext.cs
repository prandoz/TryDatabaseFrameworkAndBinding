using System.Data;
using Microsoft.Data.SqlClient;
using TryDatabaseFrameworkAndBinding.Common.Interfaces.Settings;

namespace TryDatabaseFrameworkAndBinding.Infrastructure;

public class TryDatabaseFrameworkAndBindingDapperDatabaseContext
{
	private readonly string connectionString;
	public TryDatabaseFrameworkAndBindingDapperDatabaseContext(IDatabaseSetting databaseSetting)
	{
		this.connectionString = databaseSetting.connectionString;
	}

	public IDbConnection CreateConnection() => new SqlConnection(connectionString);
}
