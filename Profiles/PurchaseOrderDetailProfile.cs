namespace crgolden.Sage
{
    using System;
    using AutoMapper;

    public class PurchaseOrderDetailProfile : Profile
    {
        public PurchaseOrderDetailProfile()
        {
            ItemTypes itemType;
            Valuations valuation;
            CreateMap<string[], PurchaseOrderDetail>()
                .IncludeAllDerived()
                .ForMember(dest => dest.PurchaseOrderNo, opt => opt.MapFrom(src => src[0]))
                .ForMember(dest => dest.LineKey, opt => opt.MapFrom(src => src[1]))
                .ForMember(dest => dest.LineSeqNo, opt => opt.MapFrom(src => src[2]))
                .ForMember(dest => dest.ItemCode, opt => opt.MapFrom(src => src[3].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ExtendedDescriptionKey, opt => opt.MapFrom(src => src[4].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ItemType, opt => opt.MapFrom(src => Enum.TryParse(src[5], out itemType) ? (ItemTypes?)itemType : null))
                .ForMember(dest => dest.ItemCodeDesc, opt => opt.MapFrom(src => src[6].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.UseTax, opt => opt.MapFrom(src => src[7].ToNullableBool()))
                .ForMember(dest => dest.RequiredDate, opt => opt.MapFrom(src => src[8].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.VendorPriceCode, opt => opt.MapFrom(src => src[9].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.PurchasesAcctKey, opt => opt.MapFrom(src => src[10].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.Valuation, opt => opt.MapFrom(src => Enum.TryParse(src[11], out valuation) ? (Valuations?)valuation : null))
                .ForMember(dest => dest.UnitOfMeasure, opt => opt.MapFrom(src => src[12].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.WarehouseCode, opt => opt.MapFrom(src => src[13].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ProductLine, opt => opt.MapFrom(src => src[14].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.MasterLineKey, opt => opt.MapFrom(src => src[15].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.Reschedule, opt => opt.MapFrom(src => src[16].ToNullableBool()))
                .ForMember(dest => dest.JobNo, opt => opt.MapFrom(src => src[17].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.CostCode, opt => opt.MapFrom(src => src[18].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.CostType, opt => opt.MapFrom(src => src[19].ToNullableChar()))
                .ForMember(dest => dest.ReceiptOfGoodsUpdated, opt => opt.MapFrom(src => src[20].ToNullableBool()))
                .ForMember(dest => dest.WorkOrderNo, opt => opt.MapFrom(src => src[21].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.StepNo, opt => opt.MapFrom(src => src[22].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.SubStepPrefix, opt => opt.MapFrom(src => src[23].ToNullableChar()))
                .ForMember(dest => dest.SubStepSuffix, opt => opt.MapFrom(src => src[24].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.WorkOrderType, opt => opt.MapFrom(src => src[25].ToNullableChar()))
                .ForMember(dest => dest.AllocateLandedCost, opt => opt.MapFrom(src => src[26].ToNullableBool()))
                .ForMember(dest => dest.VendorAliasItemNo, opt => opt.MapFrom(src => src[27].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.TaxClass, opt => opt.MapFrom(src => src[28].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.CommentText, opt => opt.MapFrom(src => src[29].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.AssetAccount, opt => opt.MapFrom(src => src[30].ToNullableBool()))
                .ForMember(dest => dest.AssetTemplate, opt => opt.MapFrom(src => src[31].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.WeightReference, opt => opt.MapFrom(src => src[32].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.SalesOrderNo, opt => opt.MapFrom(src => src[33].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.CustomerPONo, opt => opt.MapFrom(src => src[34].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.Weight, opt => opt.MapFrom(src => src[35].ToNullableDecimal()))
                .ForMember(dest => dest.QuantityOrdered, opt => opt.MapFrom(src => src[36].ToNullableDecimal()))
                .ForMember(dest => dest.QuantityReceived, opt => opt.MapFrom(src => src[37].ToNullableDecimal()))
                .ForMember(dest => dest.QuantityBackordered, opt => opt.MapFrom(src => src[38].ToNullableDecimal()))
                .ForMember(dest => dest.MasterOriginalQty, opt => opt.MapFrom(src => src[39].ToNullableDecimal()))
                .ForMember(dest => dest.MasterQtyBalance, opt => opt.MapFrom(src => src[40].ToNullableDecimal()))
                .ForMember(dest => dest.MasterQtyOrderedToDate, opt => opt.MapFrom(src => src[41].ToNullableDecimal()))
                .ForMember(dest => dest.QuantityInvoiced, opt => opt.MapFrom(src => src[42].ToNullableDecimal()))
                .ForMember(dest => dest.UnitCost, opt => opt.MapFrom(src => src[43].ToNullableDecimal()))
                .ForMember(dest => dest.OriginalUnitCost, opt => opt.MapFrom(src => src[44].ToNullableDecimal()))
                .ForMember(dest => dest.ExtensionAmt, opt => opt.MapFrom(src => src[45].ToNullableDecimal()))
                .ForMember(dest => dest.ReceivedAmt, opt => opt.MapFrom(src => src[46].ToNullableDecimal()))
                .ForMember(dest => dest.InvoicedAmt, opt => opt.MapFrom(src => src[47].ToNullableDecimal()))
                .ForMember(dest => dest.UnitOfMeasureConvFactor, opt => opt.MapFrom(src => src[48].ToNullableDecimal()))
                .ForMember(dest => dest.ReceivedAllocatedAmt, opt => opt.MapFrom(src => src[49].ToNullableDecimal()))
                .ForMember(dest => dest.InvoicedAllocatedAmt, opt => opt.MapFrom(src => src[50].ToNullableDecimal()));
        }
    }
}
