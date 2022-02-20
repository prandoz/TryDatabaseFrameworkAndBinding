using TryDatabaseFrameworkAndBinding.Common.Interfaces.Entities;
namespace TryDatabaseFrameworkAndBinding.Infrastructure.Entities;
public class Item : IItemDTO
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

	internal Item FromDto(IItemDTO itemDTO)
	{
		return new Item
		{
			DateInsert = itemDTO.DateInsert,
			DateUpdate = itemDTO.DateUpdate,
			Depth = itemDTO.Depth,
			Description1 = itemDTO.Description1,
			Description2 = itemDTO.Description2,
			Description3 = itemDTO.Description3,
			Design = itemDTO.Design,
			DesignReview = itemDTO.DesignReview,
			Height = itemDTO.Height,
			HSCode = itemDTO.HSCode,
			ID = itemDTO.ID,
			IDBrand = itemDTO.IDBrand,
			IDCategory = itemDTO.IDCategory,
			IDDefaultBom = itemDTO.IDDefaultBom,
			IDFamily = itemDTO.IDFamily,
			IDInsertUser = itemDTO.IDInsertUser,
			IDItemType = itemDTO.IDItemType,
			IDMachineModel = itemDTO.IDMachineModel,
			idMaker = itemDTO.idMaker,
			IDModifyUser = itemDTO.IDModifyUser,
			IDPackaging = itemDTO.IDPackaging,
			IDSociety = itemDTO.IDSociety,
			IDVatType = itemDTO.IDVatType,
			Kit = itemDTO.Kit,
			ManifacturingLeadtime = itemDTO.ManifacturingLeadtime,
			MinimumProvisioningQuantity = itemDTO.MinimumProvisioningQuantity,
			Note = itemDTO.Note,
			NumberCode1 = itemDTO.NumberCode1,
			NumberCode1Index = itemDTO.NumberCode1Index,
			NumberCode2 = itemDTO.NumberCode2,
			NumberCode1IndexDesignReview = itemDTO.NumberCode1IndexDesignReview,
			NumberCode3 = itemDTO.NumberCode3,
			OriginalWeight = itemDTO.OriginalWeight,
			Package = itemDTO.Package,
			QuantityForPackaging = itemDTO.QuantityForPackaging,
			Reserved = itemDTO.Reserved,
			ResourceSignImage = itemDTO.ResourceSignImage,
			ResourceSignJson = itemDTO.ResourceSignJson,
			SafetyStock = itemDTO.SafetyStock,
			SecondUnityOfMeasure = itemDTO.SecondUnityOfMeasure,
			UnitOfMeasure = itemDTO.UnitOfMeasure,
			UniversalProductCode = itemDTO.UniversalProductCode,
			Weight = itemDTO.Weight,
			Width = itemDTO.Width,
			WooCommerce_ID = itemDTO.WooCommerce_ID
		};
	}

	internal string GetSqlSelect() => @"SELECT	ID, IDInsertUser, DateInsert, IDModifyUser, DateUpdate, NumberCode1, NumberCode2, IDSociety, Reserved, SafetyStock, IDCategory,
												UnitOfMeasure, SecondUnityOfMeasure, Kit, ManifacturingLeadtime, IDMachineModel, IDFamily, Weight, Note, Package, Design,
												DesignReview, HSCode, IDPackaging, QuantityForPackaging, NumberCode3, Description1, Description2, Description3, OriginalWeight,
												Height, Width, Depth, UniversalProductCode, IDDefaultBom, NumberCode1Index, NumberCode1IndexDesignReview, IDVatType, IDItemType,
												ResourceSignImage, ResourceSignJson, IDBrand, MinimumProvisioningQuantity, idMaker, WooCommerce_ID
										FROM Items";

	internal string GetSqlInsert(IItemDTO itemDTO) => $@"	INSERT INTO Items (	IDInsertUser, DateInsert, IDModifyUser, DateUpdate, NumberCode1, NumberCode2, IDSociety, Reserved,
																				SafetyStock, IDCategory, UnitOfMeasure, SecondUnityOfMeasure, Kit, ManifacturingLeadtime,
																				IDMachineModel, IDFamily, Weight, Note, Package, Design, DesignReview, HSCode, IDPackaging,
																				QuantityForPackaging, NumberCode3, Description1, Description2, Description3, OriginalWeight, Height,
																				Width, Depth, UniversalProductCode, IDDefaultBom, NumberCode1Index, NumberCode1IndexDesignReview,
																				IDVatType, IDItemType, ResourceSignImage, ResourceSignJson, IDBrand, MinimumProvisioningQuantity,
																				idMaker, WooCommerce_ID)
															VALUES ({itemDTO.IDInsertUser}, {itemDTO.DateInsert}, {itemDTO.IDModifyUser}, {itemDTO.DateUpdate},
																	{itemDTO.NumberCode1}, {itemDTO.NumberCode2}, {itemDTO.IDSociety}, {itemDTO.Reserved}, {itemDTO.SafetyStock},
																	{itemDTO.IDCategory}, {itemDTO.UnitOfMeasure}, {itemDTO.SecondUnityOfMeasure}, {itemDTO.Kit},
																	{itemDTO.ManifacturingLeadtime}, {itemDTO.IDMachineModel}, {itemDTO.IDFamily}, {itemDTO.Weight}, {itemDTO.Note},
																	{itemDTO.Package}, {itemDTO.Design}, {itemDTO.DesignReview}, {itemDTO.HSCode}, {itemDTO.IDPackaging},
																	{itemDTO.QuantityForPackaging}, {itemDTO.NumberCode3}, {itemDTO.Description1}, {itemDTO.Description2},
																	{itemDTO.Description3}, {itemDTO.OriginalWeight}, {itemDTO.Height}, {itemDTO.Width}, {itemDTO.Depth},
																	{itemDTO.UniversalProductCode}, {itemDTO.IDDefaultBom}, {itemDTO.NumberCode1Index},
																	{itemDTO.NumberCode1IndexDesignReview}, {itemDTO.IDVatType}, {itemDTO.IDItemType}, {itemDTO.ResourceSignImage},
																	{itemDTO.ResourceSignJson}, {itemDTO.IDBrand}, {itemDTO.MinimumProvisioningQuantity}, {itemDTO.idMaker},
																	{itemDTO.WooCommerce_ID})";
	internal string GetSqlUpdate(IItemDTO itemDTO) => $@"	UPDATE Items
															SET IDInsertUser = {itemDTO.IDInsertUser}, DateInsert = {itemDTO.DateInsert}, IDModifyUser = {itemDTO.IDModifyUser},
																DateUpdate = {itemDTO.DateUpdate}, NumberCode1 = {itemDTO.NumberCode1}, NumberCode2 = {itemDTO.NumberCode2},
																IDSociety = {itemDTO.IDSociety}, Reserved = {itemDTO.Reserved}, SafetyStock = {itemDTO.SafetyStock},
																IDCategory = {itemDTO.IDCategory}, UnitOfMeasure = {itemDTO.UnitOfMeasure},
																SecondUnityOfMeasure = {itemDTO.SecondUnityOfMeasure}, Kit = {itemDTO.Kit},
																ManifacturingLeadtime = {itemDTO.ManifacturingLeadtime}, IDMachineModel = {itemDTO.IDMachineModel},
																IDFamily = {itemDTO.IDFamily}, Weight = {itemDTO.Weight}, Note = {itemDTO.Note}, Package = {itemDTO.Package},
																Design = {itemDTO.Design}, DesignReview = {itemDTO.DesignReview}, HSCode = {itemDTO.HSCode},
																IDPackaging = {itemDTO.IDPackaging}, QuantityForPackaging = {itemDTO.QuantityForPackaging},
																NumberCode3 = {itemDTO.NumberCode3}, Description1 = {itemDTO.Description1}, Description2 = {itemDTO.Description2},
																Description3 = {itemDTO.Description3}, OriginalWeight = {itemDTO.OriginalWeight}, Height = {itemDTO.Height},
																Width = {itemDTO.Width}, Depth = {itemDTO.Depth}, UniversalProductCode = {itemDTO.UniversalProductCode},
																IDDefaultBom = {itemDTO.IDDefaultBom}, NumberCode1Index = {itemDTO.NumberCode1Index}, 
																NumberCode1IndexDesignReview = {itemDTO.NumberCode1IndexDesignReview}, IDVatType = {itemDTO.IDVatType},
																IDItemType = {itemDTO.IDItemType}, ResourceSignImage = {itemDTO.ResourceSignImage},
																ResourceSignJson = {itemDTO.ResourceSignJson}, IDBrand = {itemDTO.IDBrand},
																MinimumProvisioningQuantity = {itemDTO.MinimumProvisioningQuantity}, idMaker = {itemDTO.idMaker},
																WooCommerce_ID = {itemDTO.WooCommerce_ID}
															WHERE ID = {itemDTO.ID}";

	internal string GetSqlDelete(IItemDTO itemDTO) => $"DELETE Items WHERE ID = {itemDTO.ID}";
}
