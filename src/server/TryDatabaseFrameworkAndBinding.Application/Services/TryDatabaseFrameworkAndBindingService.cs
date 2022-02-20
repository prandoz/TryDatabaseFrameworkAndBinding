using TryDatabaseFrameworkAndBinding.Common.Interfaces.Entities;
using TryDatabaseFrameworkAndBinding.Common.Interfaces.Repositories;
using TryDatabaseFrameworkAndBinding.Common.Interfaces.Services;

namespace TryDatabaseFrameworkAndBinding.Application.Services;

public class TryDatabaseFrameworkAndBindingService : ITryDatabaseFrameworkAndBindingService
{
	private readonly ITryDatabaseFrameworkAndBindingEntityFrameworkRepository tryDatabaseFrameworkAndBindingEntityFrameworkRepository;
	private readonly ITryDatabaseFrameworkAndBindingDapperRepository tryDatabaseFrameworkAndBindingDapperRepository;

	public TryDatabaseFrameworkAndBindingService(ITryDatabaseFrameworkAndBindingEntityFrameworkRepository tryDatabaseFrameworkAndBindingEntityFrameworkRepository,
													ITryDatabaseFrameworkAndBindingDapperRepository tryDatabaseFrameworkAndBindingDapperRepository)
	{
		this.tryDatabaseFrameworkAndBindingEntityFrameworkRepository = tryDatabaseFrameworkAndBindingEntityFrameworkRepository;
		this.tryDatabaseFrameworkAndBindingDapperRepository = tryDatabaseFrameworkAndBindingDapperRepository;
	}

	#region GET

	public Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAsync() => tryDatabaseFrameworkAndBindingEntityFrameworkRepository.GetModelWithEntityFrameworkAsync();

	public Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkWithouTrackingAsync() =>
																		tryDatabaseFrameworkAndBindingEntityFrameworkRepository.GetModelWithEntityFrameworkWithouTrackingAsync();

	public Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAndLinqAsync() =>
																				tryDatabaseFrameworkAndBindingEntityFrameworkRepository.GetModelWithEntityFrameworkAndLinqAsync();

	public Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAndLinqkWithouTrackingAsync() =>
																tryDatabaseFrameworkAndBindingEntityFrameworkRepository.GetModelWithEntityFrameworkAndLinqkWithouTrackingAsync();

	public Task<IEnumerable<IItemDTO>> GetModelCreatedWithEntityFrameworkAsync() =>
																				tryDatabaseFrameworkAndBindingEntityFrameworkRepository.GetModelCreatedWithEntityFrameworkAsync();

	public Task<IEnumerable<IItemDTO>> GetModelCreatedWithEntityFrameworkkWithouTrackingAsync() =>
																tryDatabaseFrameworkAndBindingEntityFrameworkRepository.GetModelCreatedWithEntityFrameworkkWithouTrackingAsync();

	public Task<IEnumerable<IItemDTO>> GetModelWithDapperkAsync() => tryDatabaseFrameworkAndBindingDapperRepository.GetModelWithDapperkAsync();

	public Task<IEnumerable<IItemDTO>> GetModelWithDapperkkWithouTrackingAsync() => tryDatabaseFrameworkAndBindingDapperRepository.GetModelWithDapperkkWithouTrackingAsync();

	public Task<IEnumerable<IItemDTO>> GetDynamicWithDapperAsync() => tryDatabaseFrameworkAndBindingDapperRepository.GetDynamicWithDapperAsync();

	public Task<IEnumerable<IItemDTO>> GetDynamicWithDapperkWithouTrackingAsync() => tryDatabaseFrameworkAndBindingDapperRepository.GetDynamicWithDapperkWithouTrackingAsync();

	public Task<IEnumerable<IItemDTO>> GetModelCreatedWithDapperAsync() => tryDatabaseFrameworkAndBindingDapperRepository.GetModelCreatedWithDapperAsync();

	public Task<IEnumerable<IItemDTO>> GetModelCreatedWithDapperkWithouTrackingAsync() =>
																					tryDatabaseFrameworkAndBindingDapperRepository.GetModelCreatedWithDapperkWithouTrackingAsync();

	#endregion GET

	#region INSERT

	public Task InsertModelWithEntityFrameworkAsync(IItemDTO itemDTO) => tryDatabaseFrameworkAndBindingEntityFrameworkRepository.InsertModelWithEntityFrameworkAsync(itemDTO);

	public Task InsertModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO) =>
																	tryDatabaseFrameworkAndBindingEntityFrameworkRepository.InsertModelWithEntityFrameworkAndLinqAsync(itemDTO);

	public Task InsertModelCreatedWithEntityFrameworkAsync(IItemDTO itemDTO) =>
																	tryDatabaseFrameworkAndBindingEntityFrameworkRepository.InsertModelCreatedWithEntityFrameworkAsync(itemDTO);

	public Task InsertModelWithDapperkAsync() => tryDatabaseFrameworkAndBindingDapperRepository.InsertModelWithDapperkAsync();

	public Task InsertDynamicWithDapperAsync() => tryDatabaseFrameworkAndBindingDapperRepository.InsertDynamicWithDapperAsync();

	public Task InsertModelCreatedWithDapperAsync() => tryDatabaseFrameworkAndBindingDapperRepository.InsertModelCreatedWithDapperAsync();

	#endregion INSERT

	#region UPDATE

	public Task UpdateModelWithEntityFrameworkAsync(IItemDTO itemDTO) => tryDatabaseFrameworkAndBindingEntityFrameworkRepository.UpdateModelWithEntityFrameworkAsync(itemDTO);

	public Task UpdateModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO) =>
																	tryDatabaseFrameworkAndBindingEntityFrameworkRepository.UpdateModelWithEntityFrameworkAndLinqAsync(itemDTO);

	public Task UpdateModelCreatedWithEntityFrameworkAsync(IItemDTO itemDTO) =>
																	tryDatabaseFrameworkAndBindingEntityFrameworkRepository.UpdateModelCreatedWithEntityFrameworkAsync(itemDTO);

	public Task UpdateModelWithDapperkAsync() => tryDatabaseFrameworkAndBindingDapperRepository.UpdateModelWithDapperkAsync();

	public Task UpdateDynamicWithDapperAsync() => tryDatabaseFrameworkAndBindingDapperRepository.UpdateDynamicWithDapperAsync();

	public Task UpdateModelCreatedWithDapperAsync() => tryDatabaseFrameworkAndBindingDapperRepository.UpdateModelCreatedWithDapperAsync();

	#endregion UPDATE

	#region DELETE

	public Task DeleteModelWithEntityFrameworkAsync(IItemDTO itemDTO) => tryDatabaseFrameworkAndBindingEntityFrameworkRepository.DeleteModelWithEntityFrameworkAsync(itemDTO);

	public Task DeleteModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO) =>
																tryDatabaseFrameworkAndBindingEntityFrameworkRepository.DeleteModelWithEntityFrameworkAndLinqAsync(itemDTO);
	public Task DeleteModelCreatadWithEntityFrameworkAsync(IItemDTO itemDTO) =>
																tryDatabaseFrameworkAndBindingEntityFrameworkRepository.DeleteModelCreatadWithEntityFrameworkAsync(itemDTO);
	public Task DeleteModelWithDapperkAsync() => tryDatabaseFrameworkAndBindingDapperRepository.DeleteModelWithDapperkAsync();
	public Task DeleteDynamicWithDapperAsync() => tryDatabaseFrameworkAndBindingDapperRepository.DeleteDynamicWithDapperAsync();
	public Task DeleteModelCreatedWithDapperAsync() => tryDatabaseFrameworkAndBindingDapperRepository.DeleteModelCreatedWithDapperAsync();

	#endregion DELETE
}
