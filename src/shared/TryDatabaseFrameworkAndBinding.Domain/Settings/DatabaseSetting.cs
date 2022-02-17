using System.ComponentModel.DataAnnotations;
using TryDatabaseFrameworkAndBinding.Common.Interfaces.Settings;

namespace TryDatabaseFrameworkAndBinding.Domain.Settings;

public class DatabaseSetting : IDatabaseSetting
{
	[Required]
	public string connectionString { get; set; } = string.Empty;
}
