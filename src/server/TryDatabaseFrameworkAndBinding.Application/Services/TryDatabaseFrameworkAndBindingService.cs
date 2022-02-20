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

	public async Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAsync() => await tryDatabaseFrameworkAndBindingEntityFrameworkRepository.GetModelWithEntityFrameworkAsync();

	public async Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkWithouTrackingAsync() => await
																		tryDatabaseFrameworkAndBindingEntityFrameworkRepository.GetModelWithEntityFrameworkWithouTrackingAsync();

	public async Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAndLinqAsync() => await
																				tryDatabaseFrameworkAndBindingEntityFrameworkRepository.GetModelWithEntityFrameworkAndLinqAsync();

	public async Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAndLinqkWithouTrackingAsync() => await
																tryDatabaseFrameworkAndBindingEntityFrameworkRepository.GetModelWithEntityFrameworkAndLinqkWithouTrackingAsync();

	public async Task<IEnumerable<IItemDTO>> GetModelWithDapperkAsync() => await tryDatabaseFrameworkAndBindingDapperRepository.GetModelWithDapperkAsync();


	public async Task<IEnumerable<dynamic>> GetDynamicWithDapperAsync() => await tryDatabaseFrameworkAndBindingDapperRepository.GetDynamicWithDapperAsync();

	#endregion GET

	#region INSERT

	public async Task InsertModelWithEntityFrameworkAsync(IItemDTO itemDTO) =>
																	await tryDatabaseFrameworkAndBindingEntityFrameworkRepository.InsertModelWithEntityFrameworkAsync(itemDTO);

	public async Task InsertModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO) =>
																await tryDatabaseFrameworkAndBindingEntityFrameworkRepository.InsertModelWithEntityFrameworkAndLinqAsync(itemDTO);

	public async Task InsertDynamicWithEntityFrameworkAsync(dynamic dynamic) =>
																	await tryDatabaseFrameworkAndBindingEntityFrameworkRepository.InsertDynamicWithEntityFrameworkAsync(dynamic);

	public async Task InsertModelWithDapperkAsync(IItemDTO itemDTO) => await tryDatabaseFrameworkAndBindingDapperRepository.InsertModelWithDapperkAsync(itemDTO);

	public async Task InsertDynamicWithDapperAsync(dynamic dynamic) => await tryDatabaseFrameworkAndBindingDapperRepository.InsertDynamicWithDapperAsync(dynamic);

	#endregion INSERT

	#region UPDATE

	public async Task UpdateModelWithEntityFrameworkAsync(IItemDTO itemDTO) =>
																	await tryDatabaseFrameworkAndBindingEntityFrameworkRepository.UpdateModelWithEntityFrameworkAsync(itemDTO);

	public async Task UpdateModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO) =>
																await tryDatabaseFrameworkAndBindingEntityFrameworkRepository.UpdateModelWithEntityFrameworkAndLinqAsync(itemDTO);
	public async Task UpdateDynamicWithEntityFrameworkAsync(dynamic dynamic) =>
																	await tryDatabaseFrameworkAndBindingEntityFrameworkRepository.UpdateDynamicWithEntityFrameworkAsync(dynamic);

	public async Task UpdateModelWithDapperkAsync(IItemDTO itemDTO) => await tryDatabaseFrameworkAndBindingDapperRepository.UpdateModelWithDapperkAsync(itemDTO);

	public async Task UpdateDynamicWithDapperAsync(dynamic dynamic) => await tryDatabaseFrameworkAndBindingDapperRepository.UpdateDynamicWithDapperAsync(dynamic);

	#endregion UPDATE

	#region DELETE

	public async Task DeleteModelWithEntityFrameworkAsync(IItemDTO itemDTO) =>
																	await tryDatabaseFrameworkAndBindingEntityFrameworkRepository.DeleteModelWithEntityFrameworkAsync(itemDTO);

	public async Task DeleteModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO) =>
																await tryDatabaseFrameworkAndBindingEntityFrameworkRepository.DeleteModelWithEntityFrameworkAndLinqAsync(itemDTO);

	public async Task DeleteDynamicWithEntityFrameworkAsync(dynamic dynamic) =>
																	await tryDatabaseFrameworkAndBindingEntityFrameworkRepository.DeleteDynamicWithEntityFrameworkAsync(dynamic);

	public async Task DeleteModelWithDapperkAsync(IItemDTO itemDTO) => await tryDatabaseFrameworkAndBindingDapperRepository.DeleteModelWithDapperkAsync(itemDTO);

	public async Task DeleteDynamicWithDapperAsync(dynamic dynamic) => await tryDatabaseFrameworkAndBindingDapperRepository.DeleteDynamicWithDapperAsync(dynamic);

	#endregion DELETE
}
