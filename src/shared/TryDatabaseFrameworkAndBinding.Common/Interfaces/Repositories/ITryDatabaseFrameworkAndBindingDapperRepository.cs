using TryDatabaseFrameworkAndBinding.Common.Interfaces.Entities;

namespace TryDatabaseFrameworkAndBinding.Common.Interfaces.Repositories;

public interface ITryDatabaseFrameworkAndBindingDapperRepository
{
	#region GET

	Task<IEnumerable<IItemDTO>> GetModelWithDapperkAsync();
	Task<IEnumerable<dynamic>> GetDynamicWithDapperAsync();

	#endregion GET

	#region INSERT

	Task InsertModelWithDapperkAsync(IItemDTO itemDTO);
	Task InsertDynamicWithDapperAsync(dynamic dynamic);

	#endregion INSERT

	#region UPDATE

	Task UpdateModelWithDapperkAsync(IItemDTO itemDTO);
	Task UpdateDynamicWithDapperAsync(dynamic dynamic);

	#endregion UPDATE

	#region DELETE

	Task DeleteModelWithDapperkAsync(IItemDTO itemDTO);
	Task DeleteDynamicWithDapperAsync(dynamic dynamic);

	#endregion DELETE
}
