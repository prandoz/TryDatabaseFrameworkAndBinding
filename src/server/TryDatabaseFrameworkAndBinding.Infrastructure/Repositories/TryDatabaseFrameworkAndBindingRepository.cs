using TryDatabaseFrameworkAndBinding.Common.Interfaces.Entities;
using TryDatabaseFrameworkAndBinding.Common.Interfaces.Repositories;

namespace TryDatabaseFrameworkAndBinding.Infrastructure.Repositories;

public class TryDatabaseFrameworkAndBindingRepository : ITryDatabaseFrameworkAndBindingService
{
	#region GET

	public async Task<IEnumerable<IItem>> GetModelWithEntityFrameworkWithLinqAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> GetModelWithEntityFrameworkWithoutLinqAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> GetDynamicWithEntityFrameworkAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> GetModelCretaedWithEntityFrameworkAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> GetModelWithDapperkAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> GetDynamicWithDapperAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> GetModelCreatedWithDapperAsync() => throw new NotImplementedException();

	#endregion GET

	#region INSERT

	public async Task<IEnumerable<IItem>> InsertModelWithEntityFrameworkWithLinqAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> InsertModelWithEntityFrameworkWithoutLinqAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> InsertDynamicWithEntityFrameworkAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> InsertModelCretaedWithEntityFrameworkAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> InsertModelWithDapperkAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> InsertDynamicWithDapperAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> InsertModelCreatedWithDapperAsync() => throw new NotImplementedException();

	#endregion INSERT

	#region UPDATE

	public async Task<IEnumerable<IItem>> UpdateModelWithEntityFrameworkWithLinqAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> UpdateModelWithEntityFrameworkWithoutLinqAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> UpdateDynamicWithEntityFrameworkAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> UpdateModelCretaedWithEntityFrameworkAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> UpdateModelWithDapperkAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> UpdateDynamicWithDapperAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> UpdateModelCreatedWithDapperAsync() => throw new NotImplementedException();

	#endregion UPDATE

	#region UPDATE BULK

	public async Task<IEnumerable<IItem>> UpdateBulkModelWithEntityFrameworkWithLinqAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> UpdateBulkModelWithEntityFrameworkWithoutLinqAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> UpdateBulkDynamicWithEntityFrameworkAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> UpdateBulkModelCretaedWithEntityFrameworkAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> UpdateBulkModelWithDapperkAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> UpdateBulkDynamicWithDapperAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> UpdateBulkModelCreatedWithDapperAsync() => throw new NotImplementedException();

	#endregion UPDATE BULK

	#region DELETE

	public async Task<IEnumerable<IItem>> DeleteModelWithEntityFrameworkWithLinqAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> DeleteModelWithEntityFrameworkWithoutLinqAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> DeleteDynamicWithEntityFrameworkAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> DeleteModelCretaedWithEntityFrameworkAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> DeleteModelWithDapperkAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> DeleteDynamicWithDapperAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> DeleteModelCreatedWithDapperAsync() => throw new NotImplementedException();

	#endregion DELETE

	#region DELETE BULK

	public async Task<IEnumerable<IItem>> DeleteBulkModelWithEntityFrameworkWithLinqAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> DeleteBulkModelWithEntityFrameworkWithoutLinqAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> DeleteBulkDynamicWithEntityFrameworkAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> DeleteBulkModelCretaedWithEntityFrameworkAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> DeleteBulkModelWithDapperkAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> DeleteBulkDynamicWithDapperAsync() => throw new NotImplementedException();
	public async Task<IEnumerable<IItem>> DeleteBulkModelCreatedWithDapperAsync() => throw new NotImplementedException();

	#endregion DELETE BUlK
}

