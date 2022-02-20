using TryDatabaseFrameworkAndBinding.Common.Interfaces.Entities;

namespace TryDatabaseFrameworkAndBinding.Common.Interfaces.Repositories;

public interface ITryDatabaseFrameworkAndBindingDapperRepository
{
	#region GET

	Task<IEnumerable<IItemDTO>> GetModelWithDapperkAsync();
	Task<IEnumerable<IItemDTO>> GetModelWithDapperkkWithouTrackingAsync();
	Task<IEnumerable<IItemDTO>> GetDynamicWithDapperAsync();
	Task<IEnumerable<IItemDTO>> GetDynamicWithDapperkWithouTrackingAsync();
	Task<IEnumerable<IItemDTO>> GetModelCreatedWithDapperAsync();
	Task<IEnumerable<IItemDTO>> GetModelCreatedWithDapperkWithouTrackingAsync();

	#endregion GET

	#region INSERT

	Task InsertModelWithDapperkAsync();
	Task InsertDynamicWithDapperAsync();
	Task InsertModelCreatedWithDapperAsync();

	#endregion INSERT

	#region UPDATE

	Task UpdateModelWithDapperkAsync();
	Task UpdateDynamicWithDapperAsync();
	Task UpdateModelCreatedWithDapperAsync();

	#endregion UPDATE

	#region UPDATE BULK

	Task UpdateBulkModelWithDapperkAsync();
	Task UpdateBulkDynamicWithDapperAsync();
	Task UpdateBulkModelCreatedWithDapperAsync();

	#endregion UPDATE BULK

	#region DELETE

	Task DeleteModelWithDapperkAsync();
	Task DeleteDynamicWithDapperAsync();
	Task DeleteModelCreatedWithDapperAsync();

	#endregion DELETE

	#region DELETE BULK

	Task DeleteBulkModelWithDapperkAsync();
	Task DeleteBulkDynamicWithDapperAsync();
	Task DeleteBulkModelCreatedWithDapperAsync();

	#endregion DELETE BUlK
}
