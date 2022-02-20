﻿using TryDatabaseFrameworkAndBinding.Common.Interfaces.Entities;

namespace TryDatabaseFrameworkAndBinding.Common.Interfaces.Services;

public interface ITryDatabaseFrameworkAndBindingService
{
	#region GET

	Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkWithouTrackingAsync();
	Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAndLinqAsync();
	Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAndLinqkWithouTrackingAsync();
	Task<IEnumerable<IItemDTO>> GetModelCreatedWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> GetModelCreatedWithEntityFrameworkkWithouTrackingAsync();
	Task<IEnumerable<IItemDTO>> GetModelWithDapperkAsync();
	Task<IEnumerable<IItemDTO>> GetModelWithDapperkkWithouTrackingAsync();
	Task<IEnumerable<IItemDTO>> GetDynamicWithDapperAsync();
	Task<IEnumerable<IItemDTO>> GetDynamicWithDapperkWithouTrackingAsync();
	Task<IEnumerable<IItemDTO>> GetModelCreatedWithDapperAsync();
	Task<IEnumerable<IItemDTO>> GetModelCreatedWithDapperkWithouTrackingAsync();

	#endregion GET

	#region INSERT

	Task InsertModelWithEntityFrameworkAsync(IItemDTO itemDTO);
	Task InsertModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO);
	Task InsertModelCreatedWithEntityFrameworkAsync(IItemDTO itemDTO);
	Task InsertModelWithDapperkAsync();
	Task InsertDynamicWithDapperAsync();
	Task InsertModelCreatedWithDapperAsync();

	#endregion INSERT

	#region UPDATE

	Task UpdateModelWithEntityFrameworkAsync(IItemDTO itemDTO);
	Task UpdateModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO);
	Task UpdateModelCreatedWithEntityFrameworkAsync(IItemDTO itemDTO);
	Task UpdateModelWithDapperkAsync();
	Task UpdateDynamicWithDapperAsync();
	Task UpdateModelCreatedWithDapperAsync();

	#endregion UPDATE

	#region DELETE

	Task DeleteModelWithEntityFrameworkAsync(IItemDTO itemDTO);
	Task DeleteModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO);
	Task DeleteModelCreatadWithEntityFrameworkAsync(IItemDTO itemDTO);
	Task DeleteModelWithDapperkAsync();
	Task DeleteDynamicWithDapperAsync();
	Task DeleteModelCreatedWithDapperAsync();

	#endregion DELETE
}
