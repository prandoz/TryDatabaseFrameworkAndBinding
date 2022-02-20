using TryDatabaseFrameworkAndBinding.Common.Interfaces.Entities;

namespace TryDatabaseFrameworkAndBinding.Common.Interfaces.Repositories;

public interface ITryDatabaseFrameworkAndBindingEntityFrameworkRepository
{
	#region GET

	Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkWithouTrackingAsync();
	Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAndLinqAsync();
	Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAndLinqkWithouTrackingAsync();

	#endregion GET

	#region INSERT

	Task InsertModelWithEntityFrameworkAsync(IItemDTO itemDTO);
	Task InsertModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO);
	Task InsertDynamicWithEntityFrameworkAsync(dynamic dynamic);

	#endregion INSERT

	#region UPDATE

	Task UpdateModelWithEntityFrameworkAsync(IItemDTO itemDTO);
	Task UpdateModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO);
	Task UpdateDynamicWithEntityFrameworkAsync(dynamic dynamic);

	#endregion UPDATE

	#region DELETE

	Task DeleteModelWithEntityFrameworkAsync(IItemDTO itemDTO);
	Task DeleteModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO);
	Task DeleteDynamicWithEntityFrameworkAsync(dynamic dynamic);

	#endregion DELETE
}
