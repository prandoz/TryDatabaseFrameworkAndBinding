using TryDatabaseFrameworkAndBinding.Common.Interfaces.Entities;

namespace TryDatabaseFrameworkAndBinding.Common.Interfaces.Repositories;

public interface ITryDatabaseFrameworkAndBindingEntityFrameworkRepository
{
	#region GET

	Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkWithouTrackingAsync();
	Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAndLinqAsync();
	Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAndLinqkWithouTrackingAsync();
	Task<IEnumerable<IItemDTO>> GetModelCreatedWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> GetModelCreatedWithEntityFrameworkkWithouTrackingAsync();

	#endregion GET

	#region INSERT

	Task InsertModelWithEntityFrameworkAsync(IItemDTO itemDTO);
	Task InsertModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO);
	Task InsertModelCreatedWithEntityFrameworkAsync(IItemDTO itemDTO);

	#endregion INSERT

	#region UPDATE

	Task UpdateModelWithEntityFrameworkAsync(IItemDTO itemDTO);
	Task UpdateModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO);
	Task UpdateModelCreatedWithEntityFrameworkAsync(IItemDTO itemDTO);

	#endregion UPDATE

	#region DELETE

	Task DeleteModelWithEntityFrameworkAsync(IItemDTO itemDTO);
	Task DeleteModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO);
	Task DeleteModelCreatadWithEntityFrameworkAsync(IItemDTO itemDTO);

	#endregion DELETE
}
