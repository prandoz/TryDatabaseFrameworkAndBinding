using TryDatabaseFrameworkAndBinding.Common.Interfaces.Entities;

namespace TryDatabaseFrameworkAndBinding.Domain.Enties;

public class ItemDTO : IItemDTO
{
	public int? ID { get; set; }
	public string? IDInsertUser { get; set; }
	public DateTime? DateInsert { get; set; }
	public string? IDModifyUser { get; set; }
	public DateTime? DateUpdate { get; set; }
	public string? NumberCode1 { get; set; }
	public string? NumberCode2 { get; set; }
	public int? IDSociety { get; set; }
	public bool? Reserved { get; set; }
	public decimal? SafetyStock { get; set; }
	public int? IDCategory { get; set; }
	public string? UnitOfMeasure { get; set; }
	public string? SecondUnityOfMeasure { get; set; }
	public bool? Kit { get; set; }
	public int? ManifacturingLeadtime { get; set; }
	public int? IDMachineModel { get; set; }
	public int? IDFamily { get; set; }
	public decimal? Weight { get; set; }
	public string? Note { get; set; }
	public bool? Package { get; set; }
	public string? Design { get; set; }
	public string? DesignReview { get; set; }
	public string? HSCode { get; set; }
	public int? IDPackaging { get; set; }
	public decimal? QuantityForPackaging { get; set; }
	public string? NumberCode3 { get; set; }
	public string? Description1 { get; set; }
	public string? Description2 { get; set; }
	public string? Description3 { get; set; }
	public decimal? OriginalWeight { get; set; }
	public decimal? Height { get; set; }
	public decimal? Width { get; set; }
	public decimal? Depth { get; set; }
	public string? UniversalProductCode { get; set; }
	public int? IDDefaultBom { get; set; }
	public string? NumberCode1Index { get; set; }
	public string? NumberCode1IndexDesignReview { get; set; }
	public int? IDVatType { get; set; }
	public int? IDItemType { get; set; }
	public string? ResourceSignImage { get; set; }
	public string? ResourceSignJson { get; set; }
	public int? IDBrand { get; set; }
	public decimal? MinimumProvisioningQuantity { get; set; }
	public int? idMaker { get; set; }
	public long? WooCommerce_ID { get; set; }
}
