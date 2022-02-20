using System.Data;
using Dapper;
using TryDatabaseFrameworkAndBinding.Common.Interfaces.Entities;
using TryDatabaseFrameworkAndBinding.Common.Interfaces.Repositories;
using TryDatabaseFrameworkAndBinding.Infrastructure.Entities;

namespace TryDatabaseFrameworkAndBinding.Infrastructure.Repositories;

public class TryDatabaseFrameworkAndBindingDapperRepository : ITryDatabaseFrameworkAndBindingDapperRepository
{
	private readonly IDbConnection databaseConnection;

	public TryDatabaseFrameworkAndBindingDapperRepository(TryDatabaseFrameworkAndBindingDapperDatabaseContext tryDatabaseFrameworkAndBindingDapperDatabaseContext)
	{
		this.databaseConnection = tryDatabaseFrameworkAndBindingDapperDatabaseContext.CreateConnection();
	}

	#region GET

	public async Task<IEnumerable<IItemDTO>> GetModelWithDapperkAsync() => await databaseConnection.QueryAsync<Item>(new Item().GetSqlSelect());
	public async Task<IEnumerable<dynamic>> GetDynamicWithDapperAsync() => await databaseConnection.QueryAsync<dynamic>(new Item().GetSqlSelect());

	#endregion GET

	#region INSERT

	public async Task InsertModelWithDapperkAsync(IItemDTO itemDTO) => await databaseConnection.ExecuteAsync(new Item().GetSqlInsert(itemDTO));
	public async Task InsertDynamicWithDapperAsync(dynamic dynamic) => await databaseConnection.ExecuteAsync((string)new Item().GetDynamicSqlInsert(dynamic));

	#endregion INSERT

	#region UPDATE

	public async Task UpdateModelWithDapperkAsync(IItemDTO itemDTO) => await databaseConnection.ExecuteAsync(new Item().GetSqlUpdate(itemDTO));
	public async Task UpdateDynamicWithDapperAsync(dynamic dynamic) => await databaseConnection.ExecuteAsync((string)new Item().GetDynamicSqlUpdate(dynamic));

	#endregion UPDATE

	#region DELETE

	public async Task DeleteModelWithDapperkAsync(IItemDTO itemDTO) => await databaseConnection.ExecuteAsync(new Item().GetSqlDelete(itemDTO));
	public async Task DeleteDynamicWithDapperAsync(dynamic dynamic) => await databaseConnection.ExecuteAsync((string)new Item().GetDynamicSqlDelete(dynamic));

	#endregion DELETE
}

