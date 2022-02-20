using TryDatabaseFrameworkAndBinding.Common.Interfaces.Entities;
using TryDatabaseFrameworkAndBinding.Common.Interfaces.Repositories;

namespace TryDatabaseFrameworkAndBinding.Infrastructure.Repositories;

public class TryDatabaseFrameworkAndBindingDapperRepository : ITryDatabaseFrameworkAndBindingDapperRepository
{
	#region GET

	public Task<IEnumerable<IItemDTO>> GetModelWithDapperkAsync() => throw new NotImplementedException();
	public Task<IEnumerable<IItemDTO>> GetModelWithDapperkkWithouTrackingAsync() => throw new NotImplementedException();
	public Task<IEnumerable<IItemDTO>> GetDynamicWithDapperAsync() => throw new NotImplementedException();
	public Task<IEnumerable<IItemDTO>> GetDynamicWithDapperkWithouTrackingAsync() => throw new NotImplementedException();
	public Task<IEnumerable<IItemDTO>> GetModelCreatedWithDapperAsync() => throw new NotImplementedException();
	public Task<IEnumerable<IItemDTO>> GetModelCreatedWithDapperkWithouTrackingAsync() => throw new NotImplementedException();

	#endregion GET

	#region INSERT

	public Task InsertModelWithDapperkAsync() => throw new NotImplementedException();
	public Task InsertDynamicWithDapperAsync() => throw new NotImplementedException();
	public Task InsertModelCreatedWithDapperAsync() => throw new NotImplementedException();

	#endregion INSERT

	#region UPDATE

	public Task UpdateModelWithDapperkAsync() => throw new NotImplementedException();
	public Task UpdateDynamicWithDapperAsync() => throw new NotImplementedException();
	public Task UpdateModelCreatedWithDapperAsync() => throw new NotImplementedException();

	#endregion UPDATE

	#region UPDATE BULK

	public Task UpdateBulkModelWithDapperkAsync() => throw new NotImplementedException();
	public Task UpdateBulkDynamicWithDapperAsync() => throw new NotImplementedException();
	public Task UpdateBulkModelCreatedWithDapperAsync() => throw new NotImplementedException();

	#endregion UPDATE BULK

	#region DELETE

	public Task DeleteModelWithDapperkAsync() => throw new NotImplementedException();
	public Task DeleteDynamicWithDapperAsync() => throw new NotImplementedException();
	public Task DeleteModelCreatedWithDapperAsync() => throw new NotImplementedException();

	#endregion DELETE

	#region DELETE BULK

	public Task DeleteBulkModelWithDapperkAsync() => throw new NotImplementedException();
	public Task DeleteBulkDynamicWithDapperAsync() => throw new NotImplementedException();
	public Task DeleteBulkModelCreatedWithDapperAsync() => throw new NotImplementedException();

	#endregion DELETE BUlK
}

