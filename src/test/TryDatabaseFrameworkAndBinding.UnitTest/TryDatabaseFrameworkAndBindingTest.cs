using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using TryDatabaseFrameworkAndBinding.Application.Services;
using TryDatabaseFrameworkAndBinding.UnitTest.Repositories;
using Xunit;

namespace TryDatabaseFrameworkAndBinding.UnitTest;

public class TryDatabaseFrameworkAndBindingTest
{
	private ILogger<TryDatabaseFrameworkAndBindingTest> _logger;

	public TryDatabaseFrameworkAndBindingTest(ILogger<TryDatabaseFrameworkAndBindingTest> logger)
	{
		_logger = logger;
	}

	#region GET

	[Fact]
	public async Task LogGetModelWithEntityFrameworkAsync()
	{
		var startDate = DateTime.Now;

		var tryDatabaseFrameworkAndBindingService =
			new TryDatabaseFrameworkAndBindingService(
				TryDatabaseFrameworkAndBindingEntityFrameworkRepositoryFake.Initialize(),
				TryDatabaseFrameworkAndBindingDapperRepositoryFake.Initialize());

		await tryDatabaseFrameworkAndBindingService.GetModelWithEntityFrameworkAsync();

		_logger.LogInformation($"Binding model with entity framework in {(DateTime.Now - startDate).TotalSeconds} seconds");
	}

	public async Task LogGetModelWithEntityFrameworkWithouTrackingAsync()
	{
		var startDate = DateTime.Now;

		var tryDatabaseFrameworkAndBindingService =
			new TryDatabaseFrameworkAndBindingService(
				TryDatabaseFrameworkAndBindingEntityFrameworkRepositoryFake.Initialize(),
				TryDatabaseFrameworkAndBindingDapperRepositoryFake.Initialize());

		await tryDatabaseFrameworkAndBindingService.GetModelWithEntityFrameworkWithouTrackingAsync();

		_logger.LogInformation($"Binding model with entity framework without tracking in {(DateTime.Now - startDate).TotalSeconds} seconds");
	}

	public async Task GetModelWithEntityFrameworkAndLinqAsync()
	{
		var startDate = DateTime.Now;

		var tryDatabaseFrameworkAndBindingService =
			new TryDatabaseFrameworkAndBindingService(
				TryDatabaseFrameworkAndBindingEntityFrameworkRepositoryFake.Initialize(),
				TryDatabaseFrameworkAndBindingDapperRepositoryFake.Initialize());

		await tryDatabaseFrameworkAndBindingService.GetModelWithEntityFrameworkAndLinqAsync();

		_logger.LogInformation($"Binding model with entity framework and Linq in {(DateTime.Now - startDate).TotalSeconds} seconds");
	}

	public async Task GetModelWithEntityFrameworkAndLinqkWithouTrackingAsync()
	{
		var startDate = DateTime.Now;

		var tryDatabaseFrameworkAndBindingService =
			new TryDatabaseFrameworkAndBindingService(
				TryDatabaseFrameworkAndBindingEntityFrameworkRepositoryFake.Initialize(),
				TryDatabaseFrameworkAndBindingDapperRepositoryFake.Initialize());

		await tryDatabaseFrameworkAndBindingService.GetModelWithEntityFrameworkAndLinqkWithouTrackingAsync();

		_logger.LogInformation($"Binding model with entity framework and Linq withour tracking in {(DateTime.Now - startDate).TotalSeconds} seconds");
	}

	public async Task GetModelWithDapperkAsync()
	{
		var startDate = DateTime.Now;

		var tryDatabaseFrameworkAndBindingService =
			new TryDatabaseFrameworkAndBindingService(
				TryDatabaseFrameworkAndBindingEntityFrameworkRepositoryFake.Initialize(),
				TryDatabaseFrameworkAndBindingDapperRepositoryFake.Initialize());

		await tryDatabaseFrameworkAndBindingService.GetModelWithDapperkAsync();

		_logger.LogInformation($"Binding model with dapper in {(DateTime.Now - startDate).TotalSeconds} seconds");
	}


	public async Task GetDynamicWithDapperAsync()
	{
		var startDate = DateTime.Now;

		var tryDatabaseFrameworkAndBindingService =
			new TryDatabaseFrameworkAndBindingService(
				TryDatabaseFrameworkAndBindingEntityFrameworkRepositoryFake.Initialize(),
				TryDatabaseFrameworkAndBindingDapperRepositoryFake.Initialize());

		await tryDatabaseFrameworkAndBindingService.GetDynamicWithDapperAsync();

		_logger.LogInformation($"Binding dynamic with dapper in {(DateTime.Now - startDate).TotalSeconds} seconds");
	}

	#endregion GET

	#region INSERT

	//public async Task InsertModelWithEntityFrameworkAsync(IItemDTO itemDTO) =>
	//																await tryDatabaseFrameworkAndBindingEntityFrameworkRepository.InsertModelWithEntityFrameworkAsync(itemDTO);

	//public async Task InsertModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO) =>
	//															await tryDatabaseFrameworkAndBindingEntityFrameworkRepository.InsertModelWithEntityFrameworkAndLinqAsync(itemDTO);

	//public async Task InsertDynamicWithEntityFrameworkAsync(dynamic dynamic) =>
	//																await tryDatabaseFrameworkAndBindingEntityFrameworkRepository.InsertDynamicWithEntityFrameworkAsync(dynamic);

	//public async Task InsertModelWithDapperkAsync(IItemDTO itemDTO) => await tryDatabaseFrameworkAndBindingDapperRepository.InsertModelWithDapperkAsync(itemDTO);

	//public async Task InsertDynamicWithDapperAsync(dynamic dynamic) => await tryDatabaseFrameworkAndBindingDapperRepository.InsertDynamicWithDapperAsync(dynamic);

	#endregion INSERT

	#region UPDATE

	//public async Task UpdateModelWithEntityFrameworkAsync(IItemDTO itemDTO) =>
	//																await tryDatabaseFrameworkAndBindingEntityFrameworkRepository.UpdateModelWithEntityFrameworkAsync(itemDTO);

	//public async Task UpdateModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO) =>
	//															await tryDatabaseFrameworkAndBindingEntityFrameworkRepository.UpdateModelWithEntityFrameworkAndLinqAsync(itemDTO);
	//public async Task UpdateDynamicWithEntityFrameworkAsync(dynamic dynamic) =>
	//																await tryDatabaseFrameworkAndBindingEntityFrameworkRepository.UpdateDynamicWithEntityFrameworkAsync(dynamic);

	//public async Task UpdateModelWithDapperkAsync(IItemDTO itemDTO) => await tryDatabaseFrameworkAndBindingDapperRepository.UpdateModelWithDapperkAsync(itemDTO);

	//public async Task UpdateDynamicWithDapperAsync(dynamic dynamic) => await tryDatabaseFrameworkAndBindingDapperRepository.UpdateDynamicWithDapperAsync(dynamic);

	#endregion UPDATE

	#region DELETE

	//public async Task DeleteModelWithEntityFrameworkAsync(IItemDTO itemDTO) =>
	//																await tryDatabaseFrameworkAndBindingEntityFrameworkRepository.DeleteModelWithEntityFrameworkAsync(itemDTO);

	//public async Task DeleteModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO) =>
	//															await tryDatabaseFrameworkAndBindingEntityFrameworkRepository.DeleteModelWithEntityFrameworkAndLinqAsync(itemDTO);

	//public async Task DeleteDynamicWithEntityFrameworkAsync(dynamic dynamic) =>
	//																await tryDatabaseFrameworkAndBindingEntityFrameworkRepository.DeleteDynamicWithEntityFrameworkAsync(dynamic);

	//public async Task DeleteModelWithDapperkAsync(IItemDTO itemDTO) => await tryDatabaseFrameworkAndBindingDapperRepository.DeleteModelWithDapperkAsync(itemDTO);

	//public async Task DeleteDynamicWithDapperAsync(dynamic dynamic) => await tryDatabaseFrameworkAndBindingDapperRepository.DeleteDynamicWithDapperAsync(dynamic);

	#endregion DELETE
}