using TryDatabaseFrameworkAndBinding.Common.Interfaces.Entities;

namespace TryDatabaseFrameworkAndBinding.Common.Interfaces.Services;

public interface ITryDatabaseFrameworkAndBindingService
{
	#region GET

	Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkWithouTrackingAsync();
	Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAndLinqAsync();
	Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAndLinqkWithouTrackingAsync();
	Task<IEnumerable<IItemDTO>> GetModelWithDapperkAsync();
	Task<IEnumerable<dynamic>> GetDynamicWithDapperAsync();

	#endregion GET

	#region INSERT

	Task InsertModelWithEntityFrameworkAsync(IItemDTO itemDTO);
	Task InsertModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO);
	Task InsertDynamicWithEntityFrameworkAsync(dynamic dynamic);
	Task InsertModelWithDapperkAsync(IItemDTO itemDTO);
	Task InsertDynamicWithDapperAsync(dynamic dynamic);

	#endregion INSERT

	#region UPDATE

	Task UpdateModelWithEntityFrameworkAsync(IItemDTO itemDTO);
	Task UpdateModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO);
	Task UpdateDynamicWithEntityFrameworkAsync(dynamic dynamic);
	Task UpdateModelWithDapperkAsync(IItemDTO itemDTO);
	Task UpdateDynamicWithDapperAsync(dynamic dynamic);

	#endregion UPDATE

	#region DELETE

	Task DeleteModelWithEntityFrameworkAsync(IItemDTO itemDTO);
	Task DeleteModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO);
	Task DeleteDynamicWithEntityFrameworkAsync(dynamic dynamic);
	Task DeleteModelWithDapperkAsync(IItemDTO itemDTO);
	Task DeleteDynamicWithDapperAsync(dynamic dynamic);

	#endregion DELETE
}
