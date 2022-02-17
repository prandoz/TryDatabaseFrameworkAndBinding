using TryDatabaseFrameworkAndBinding.Common.Interfaces.Entities;

namespace TryDatabaseFrameworkAndBinding.Common.Interfaces.Services;

interface ITryDatabaseFrameworkAndBindingService
{
	#region GET

	Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> GetDynamicWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> GetModelCretaedWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> GetModelWithDapperkAsync();
	Task<IEnumerable<IItemDTO>> GetDynamicWithDapperAsync();
	Task<IEnumerable<IItemDTO>> GetModelCreatedWithDapperAsync();

	#endregion GET

	#region INSERT

	Task<IEnumerable<IItemDTO>> InsertModelWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> InsertDynamicWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> InsertModelCretaedWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> InsertModelWithDapperkAsync();
	Task<IEnumerable<IItemDTO>> InsertDynamicWithDapperAsync();
	Task<IEnumerable<IItemDTO>> InsertModelCreatedWithDapperAsync();

	#endregion INSERT

	#region UPDATE

	Task<IEnumerable<IItemDTO>> UpdateModelWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> UpdateDynamicWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> UpdateModelCretaedWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> UpdateModelWithDapperkAsync();
	Task<IEnumerable<IItemDTO>> UpdateDynamicWithDapperAsync();
	Task<IEnumerable<IItemDTO>> UpdateModelCreatedWithDapperAsync();

	#endregion UPDATE

	#region UPDATE BULK

	Task<IEnumerable<IItemDTO>> UpdateBulkModelWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> UpdateBulkDynamicWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> UpdateBulkModelCretaedWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> UpdateBulkModelWithDapperkAsync();
	Task<IEnumerable<IItemDTO>> UpdateBulkDynamicWithDapperAsync();
	Task<IEnumerable<IItemDTO>> UpdateBulkModelCreatedWithDapperAsync();

	#endregion UPDATE BULK

	#region DELETE

	Task<IEnumerable<IItemDTO>> DeleteModelWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> DeleteDynamicWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> DeleteModelCretaedWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> DeleteModelWithDapperkAsync();
	Task<IEnumerable<IItemDTO>> DeleteDynamicWithDapperAsync();
	Task<IEnumerable<IItemDTO>> DeleteModelCreatedWithDapperAsync();

	#endregion DELETE

	#region DELETE BULK

	Task<IEnumerable<IItemDTO>> DeleteBulkModelWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> DeleteBulkDynamicWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> DeleteBulkModelCretaedWithEntityFrameworkAsync();
	Task<IEnumerable<IItemDTO>> DeleteBulkModelWithDapperkAsync();
	Task<IEnumerable<IItemDTO>> DeleteBulkDynamicWithDapperAsync();
	Task<IEnumerable<IItemDTO>> DeleteBulkModelCreatedWithDapperAsync();

	#endregion DELETE BUlK
}
