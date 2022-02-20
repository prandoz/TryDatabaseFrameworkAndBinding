using Microsoft.EntityFrameworkCore;
using TryDatabaseFrameworkAndBinding.Infrastructure.Entities;

namespace TryDatabaseFrameworkAndBinding.Infrastructure;

public class TryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext : DbContext
{
	public TryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext(DbContextOptions<TryDatabaseFrameworkAndBindingEntityFrameworkDatabaseContext> options) : base(options) { }

	public DbSet<Item> Item { get; set; } = null!;
}
