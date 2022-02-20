namespace TryDatabaseFrameworkAndBinding.Common.Interfaces.Entities;

public interface IItemDTO
{
	int? ID { get; set; }
	string? IDInsertUser { get; set; }
	DateTime? DateInsert { get; set; }
	string? IDModifyUser { get; set; }
	DateTime? DateUpdate { get; set; }
	string? NumberCode1 { get; set; }
	string? NumberCode2 { get; set; }
	int? IDSociety { get; set; }
	bool? Reserved { get; set; }
	decimal? SafetyStock { get; set; }
	int? IDCategory { get; set; }
	string? UnitOfMeasure { get; set; }
	string? SecondUnityOfMeasure { get; set; }
	bool? Kit { get; set; }
	int? ManifacturingLeadtime { get; set; }
	int? IDMachineModel { get; set; }
	int? IDFamily { get; set; }
	decimal? Weight { get; set; }
	string? Note { get; set; }
	bool? Package { get; set; }
	string? Design { get; set; }
	string? DesignReview { get; set; }
	string? HSCode { get; set; }
	int? IDPackaging { get; set; }
	decimal? QuantityForPackaging { get; set; }
	string? NumberCode3 { get; set; }
	string? Description1 { get; set; }
	string? Description2 { get; set; }
	string? Description3 { get; set; }
	decimal? OriginalWeight { get; set; }
	decimal? Height { get; set; }
	decimal? Width { get; set; }
	decimal? Depth { get; set; }
	string? UniversalProductCode { get; set; }
	int? IDDefaultBom { get; set; }
	string? NumberCode1Index { get; set; }
	string? NumberCode1IndexDesignReview { get; set; }
	int? IDVatType { get; set; }
	int? IDItemType { get; set; }
	string? ResourceSignImage { get; set; }
	string? ResourceSignJson { get; set; }
	int? IDBrand { get; set; }
	decimal? MinimumProvisioningQuantity { get; set; }
	int? idMaker { get; set; }
	long? WooCommerce_ID { get; set; }
}
