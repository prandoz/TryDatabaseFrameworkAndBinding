using TryDatabaseFrameworkAndBinding.Common.Interfaces.Entities;
using TryDatabaseFrameworkAndBinding.Common.Interfaces.Repositories;

namespace TryDatabaseFrameworkAndBinding.Application.Services;

public class TryDatabaseFrameworkAndBindingService : ITryDatabaseFrameworkAndBindingService
{
	private ITryDatabaseFrameworkAndBindingService _TryDatabaseFrameworkAndBindingRepository { get; set; }

	public TryDatabaseFrameworkAndBindingService(ITryDatabaseFrameworkAndBindingService TryDatabaseFrameworkAndBindingRepository)
	{
		_TryDatabaseFrameworkAndBindingRepository = TryDatabaseFrameworkAndBindingRepository;
	}
	#region GET

	public async Task<IEnumerable<IItem>> GetModelFromEntityFramework() => await _TryDatabaseFrameworkAndBindingRepository.GetModelFromEntityFrameworkAsync();
	public async Task<IEnumerable<IItem>> GetDynamicFromEntityFrameworkAsync() => await _TryDatabaseFrameworkAndBindingRepository.GetDynamicFromEntityFrameworkAsync();
	public async Task<IEnumerable<IItem>> GetModelCretaedFromEntityFrameworkAsync() => await _TryDatabaseFrameworkAndBindingRepository.GetModelCretaedFromEntityFrameworkAsync();
	public async Task<IEnumerable<IItem>> GetModelFromDapperkAsync() => await _TryDatabaseFrameworkAndBindingRepository.GetModelFromDapperkAsync();
	public async Task<IEnumerable<IItem>> GetDynamicFromDapperAsync() => await _TryDatabaseFrameworkAndBindingRepository.GetDynamicFromDapperAsync();
	public async Task<IEnumerable<IItem>> GetModelCreatedFromDapperAsync() => await _TryDatabaseFrameworkAndBindingRepository.GetModelCreatedFromDapperAsync();

	#endregion GET

	#region INSERT

	public async Task<IEnumerable<IItem>> InsertModelFromEntityFrameworkAsync() => await _TryDatabaseFrameworkAndBindingRepository.InsertModelFromDapperkAsync();
	public async Task<IEnumerable<IItem>> InsertDynamicFromEntityFrameworkAsync() => await _TryDatabaseFrameworkAndBindingRepository.InsertDynamicFromEntityFrameworkAsync();
	public async Task<IEnumerable<IItem>> InsertModelCretaedFromEntityFrameworkAsync() => await _TryDatabaseFrameworkAndBindingRepository.InsertModelCretaedFromEntityFrameworkAsync();
	public async Task<IEnumerable<IItem>> InsertModelFromDapperkAsync() => await _TryDatabaseFrameworkAndBindingRepository.InsertModelFromDapperkAsync();
	public async Task<IEnumerable<IItem>> InsertDynamicFromDapperAsync() => await _TryDatabaseFrameworkAndBindingRepository.InsertDynamicFromDapperAsync();
	public async Task<IEnumerable<IItem>> InsertModelCreatedFromDapperAsync() => await _TryDatabaseFrameworkAndBindingRepository.InsertModelCreatedFromDapperAsync();

	#endregion INSERT

	#region UPDATE

	public async Task<IEnumerable<IItem>> UpdateModelFromEntityFrameworkAsync() => await _TryDatabaseFrameworkAndBindingRepository.UpdateModelCretaedFromEntityFrameworkAsync();
	public async Task<IEnumerable<IItem>> UpdateDynamicFromEntityFrameworkAsync() => await _TryDatabaseFrameworkAndBindingRepository.UpdateDynamicFromEntityFrameworkAsync();
	public async Task<IEnumerable<IItem>> UpdateModelCretaedFromEntityFrameworkAsync() => await _TryDatabaseFrameworkAndBindingRepository.UpdateModelCretaedFromEntityFrameworkAsync();
	public async Task<IEnumerable<IItem>> UpdateModelFromDapperkAsync();
	public async Task<IEnumerable<IItem>> UpdateDynamicFromDapperAsync();
	public async Task<IEnumerable<IItem>> UpdateModelCreatedFromDapperAsync();

	#endregion UPDATE

	#region UPDATE BULK

	public async Task<IEnumerable<IItem>> UpdateBulkModelFromEntityFrameworkAsync();
	public async Task<IEnumerable<IItem>> UpdateBulkDynamicFromEntityFrameworkAsync();
	public async Task<IEnumerable<IItem>> UpdateBulkModelCretaedFromEntityFrameworkAsync();
	public async Task<IEnumerable<IItem>> UpdateBulkModelFromDapperkAsync();
	public async Task<IEnumerable<IItem>> UpdateBulkDynamicFromDapperAsync();
	public async Task<IEnumerable<IItem>> UpdateBulkModelCreatedFromDapperAsync();

	#endregion UPDATE BULK

	#region DELETE

	public async Task<IEnumerable<IItem>> DeleteModelFromEntityFrameworkAsync();
	public async Task<IEnumerable<IItem>> DeleteDynamicFromEntityFrameworkAsync();
	public async Task<IEnumerable<IItem>> DeleteModelCretaedFromEntityFrameworkAsync();
	public async Task<IEnumerable<IItem>> DeleteModelFromDapperkAsync();
	public async Task<IEnumerable<IItem>> DeleteDynamicFromDapperAsync();
	public async Task<IEnumerable<IItem>> DeleteModelCreatedFromDapperAsync();

	#endregion DELETE

	#region DELETE BULK

	public async Task<IEnumerable<IItem>> DeleteBulkModelFromEntityFrameworkAsync();
	public async Task<IEnumerable<IItem>> DeleteBulkDynamicFromEntityFrameworkAsync();
	public async Task<IEnumerable<IItem>> DeleteBulkModelCretaedFromEntityFrameworkAsync();
	public async Task<IEnumerable<IItem>> DeleteBulkModelFromDapperkAsync();
	public async Task<IEnumerable<IItem>> DeleteBulkDynamicFromDapperAsync();
	public async Task<IEnumerable<IItem>> DeleteBulkModelCreatedFromDapperAsync();

	#endregion DELETE BUlK
}
