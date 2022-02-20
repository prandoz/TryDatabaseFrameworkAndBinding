using Microsoft.EntityFrameworkCore;
using TryDatabaseFrameworkAndBinding.Common.Interfaces.Entities;
using TryDatabaseFrameworkAndBinding.Common.Interfaces.Repositories;
using TryDatabaseFrameworkAndBinding.Domain.Enties;
using TryDatabaseFrameworkAndBinding.Infrastructure.Entities;

namespace TryDatabaseFrameworkAndBinding.Infrastructure.Repositories;

public class TryDatabaseFrameworkAndBindingEntityFrameworkRepository : ITryDatabaseFrameworkAndBindingEntityFrameworkRepository
{
	private readonly TryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext tryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext;

	public TryDatabaseFrameworkAndBindingEntityFrameworkRepository(TryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext tryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext)
	{
		this.tryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext = tryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext;
	}

	#region GET

	public async Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAsync() =>
											await tryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext.Set<ItemDTO>().FromSqlRaw(new Item().GetSqlSelect()).ToListAsync();

	public async Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkWithouTrackingAsync() =>
							await tryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext.Set<ItemDTO>().FromSqlRaw(new Item().GetSqlSelect()).AsNoTracking().ToListAsync();

	public async Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAndLinqAsync() =>
							await tryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext.Item.Select(i => new ItemDTO { DateInsert = i.DateInsert }).ToListAsync();

	public async Task<IEnumerable<IItemDTO>> GetModelWithEntityFrameworkAndLinqkWithouTrackingAsync() =>
			await tryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext.Item.Select(i => new ItemDTO { DateInsert = i.DateInsert }).AsNoTracking().ToListAsync();

	public Task<IEnumerable<IItemDTO>> GetModelCreatedWithEntityFrameworkAsync() => throw new NotImplementedException();
	public Task<IEnumerable<IItemDTO>> GetModelCreatedWithEntityFrameworkkWithouTrackingAsync() => throw new NotImplementedException();

	#endregion GET

	#region INSERT

	public async Task InsertModelWithEntityFrameworkAsync(IItemDTO itemDTO) =>
		await tryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext.Database.ExecuteSqlRawAsync(new Item().GetSqlInsert(itemDTO));

	public async Task InsertModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO)
	{
		tryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext.Item.Add(new Item().FromDto(itemDTO));
		await tryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext.SaveChangesAsync();
	}

	public Task InsertModelCreatedWithEntityFrameworkAsync(IItemDTO itemDTO) => throw new NotImplementedException();

	#endregion INSERT

	#region UPDATE

	public async Task UpdateModelWithEntityFrameworkAsync(IItemDTO itemDTO) =>
											await tryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext.Database.ExecuteSqlRawAsync(new Item().GetSqlUpdate(itemDTO));

	public async Task UpdateModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO)
	{
		tryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext.Entry(new Item().FromDto(itemDTO)).State = EntityState.Modified;
		await tryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext.SaveChangesAsync();
	}

	public Task UpdateModelCreatedWithEntityFrameworkAsync(IItemDTO itemDTO) => throw new NotImplementedException();

	#endregion UPDATE

	#region DELETE

	public async Task DeleteModelWithEntityFrameworkAsync(IItemDTO itemDTO) =>
											await tryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext.Database.ExecuteSqlRawAsync(new Item().GetSqlDelete(itemDTO));

	public async Task DeleteModelWithEntityFrameworkAndLinqAsync(IItemDTO itemDTO)
	{
		tryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext.Entry(new Item().FromDto(itemDTO)).State = EntityState.Deleted;
		await tryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext.SaveChangesAsync();
	}

	public Task DeleteModelCreatadWithEntityFrameworkAsync(IItemDTO itemDTO) => throw new NotImplementedException();

	#endregion DELETE
}

