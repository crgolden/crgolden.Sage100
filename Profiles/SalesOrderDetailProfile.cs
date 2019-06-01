﻿namespace crgolden.Sage
{
    using System;
    using AutoMapper;

    public class SalesOrderDetailProfile : Profile
    {
        public SalesOrderDetailProfile()
        {
            ItemTypes itemType;
            Valuations valuation;
            CreateMap<string[], SalesOrderDetail>()
                .IncludeAllDerived()
                .ForMember(dest => dest.SalesOrderNo, opt => opt.MapFrom(src => src[0]))
                .ForMember(dest => dest.LineKey, opt => opt.MapFrom(src => src[1]))
                .ForMember(dest => dest.LineSeqNo, opt => opt.MapFrom(src => src[2]))
                .ForMember(dest => dest.ItemCode, opt => opt.MapFrom(src => src[3].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ItemType, opt => opt.MapFrom(src => Enum.TryParse(src[4], out itemType) ? (ItemTypes?)itemType : null))
                .ForMember(dest => dest.ItemCodeDesc, opt => opt.MapFrom(src => src[5].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ExtendedDescriptionKey, opt => opt.MapFrom(src => src[6].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.Discount, opt => opt.MapFrom(src => src[7].ToNullableBool()))
                .ForMember(dest => dest.Commissionable, opt => opt.MapFrom(src => src[8].ToNullableBool()))
                .ForMember(dest => dest.SubjectToExemption, opt => opt.MapFrom(src => src[9].ToNullableBool()))
                .ForMember(dest => dest.WarehouseCode, opt => opt.MapFrom(src => src[10].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.Valuation, opt => opt.MapFrom(src => Enum.TryParse(src[11], out valuation) ? (Valuations?)valuation : null))
                .ForMember(dest => dest.PriceLevel, opt => opt.MapFrom(src => src[12].ToNullableChar()))
                .ForMember(dest => dest.MasterOrderLineKey, opt => opt.MapFrom(src => src[13].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.UnitOfMeasure, opt => opt.MapFrom(src => src[14].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.DropShip, opt => opt.MapFrom(src => src[15].ToNullableBool()))
                .ForMember(dest => dest.LotSerialFullyDistributed, opt => opt.MapFrom(src => src[16].ToNullableBool()))
                .ForMember(dest => dest.PrintDropShipment, opt => opt.MapFrom(src => src[17].ToNullableChar()))
                .ForMember(dest => dest.SalesKitLineKey, opt => opt.MapFrom(src => src[18].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.CostOfGoodsSoldAcctKey, opt => opt.MapFrom(src => src[19].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.SalesAcctKey, opt => opt.MapFrom(src => src[20].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.PriceOverridden, opt => opt.MapFrom(src => src[21].ToNullableBool()))
                .ForMember(dest => dest.ExplodedKitItem, opt => opt.MapFrom(src => src[22].ToNullableBool()))
                .ForMember(dest => dest.StandardKitBill, opt => opt.MapFrom(src => src[23].ToNullableBool()))
                .ForMember(dest => dest.Revision, opt => opt.MapFrom(src => src[24].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.BillOption1, opt => opt.MapFrom(src => src[25].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.BillOption2, opt => opt.MapFrom(src => src[26].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.BillOption3, opt => opt.MapFrom(src => src[27].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.BillOption4, opt => opt.MapFrom(src => src[28].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.BillOption5, opt => opt.MapFrom(src => src[29].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.BillOption6, opt => opt.MapFrom(src => src[30].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.BillOption7, opt => opt.MapFrom(src => src[31].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.BillOption8, opt => opt.MapFrom(src => src[32].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.BillOption9, opt => opt.MapFrom(src => src[33].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.BackorderKitCompLine, opt => opt.MapFrom(src => src[34].ToNullableBool()))
                .ForMember(dest => dest.SkipPrintCompLine, opt => opt.MapFrom(src => src[35].ToNullableBool()))
                .ForMember(dest => dest.PromiseDate, opt => opt.MapFrom(src => src[36].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.AliasItemNo, opt => opt.MapFrom(src => src[37].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.SOHistoryDetlSeqNo, opt => opt.MapFrom(src => src[38].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.TaxClass, opt => opt.MapFrom(src => src[39].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.CustomerAction, opt => opt.MapFrom(src => src[40].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ItemAction, opt => opt.MapFrom(src => src[41].ToNullableChar()))
                .ForMember(dest => dest.WarrantyCode, opt => opt.MapFrom(src => src[42].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ExpirationDate, opt => opt.MapFrom(src => src[43].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ExpirationOverridden, opt => opt.MapFrom(src => src[44].ToNullableBool()))
                .ForMember(dest => dest.CostOverridden, opt => opt.MapFrom(src => src[45].ToNullableBool()))
                .ForMember(dest => dest.CostCode, opt => opt.MapFrom(src => src[46].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.CostType, opt => opt.MapFrom(src => src[47].ToNullableChar()))
                .ForMember(dest => dest.CommentText, opt => opt.MapFrom(src => src[48].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.APDivisionNo, opt => opt.MapFrom(src => src[49].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.VendorNo, opt => opt.MapFrom(src => src[50].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.PurchaseOrderNo, opt => opt.MapFrom(src => src[51].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.PurchaseOrderRequiredDate, opt => opt.MapFrom(src => src[52].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.QuantityOrdered, opt => opt.MapFrom(src => src[53].ToNullableDecimal()))
                .ForMember(dest => dest.QuantityShipped, opt => opt.MapFrom(src => src[54].ToNullableDecimal()))
                .ForMember(dest => dest.QuantityBackordered, opt => opt.MapFrom(src => src[55].ToNullableDecimal()))
                .ForMember(dest => dest.MasterOriginalQty, opt => opt.MapFrom(src => src[56].ToNullableDecimal()))
                .ForMember(dest => dest.MasterQtyBalance, opt => opt.MapFrom(src => src[57].ToNullableDecimal()))
                .ForMember(dest => dest.MasterQtyOrderedToDate, opt => opt.MapFrom(src => src[58].ToNullableDecimal()))
                .ForMember(dest => dest.RepeatingQtyShippedToDate, opt => opt.MapFrom(src => src[59].ToNullableDecimal()))
                .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src[60].ToNullableDecimal()))
                .ForMember(dest => dest.UnitCost, opt => opt.MapFrom(src => src[61].ToNullableDecimal()))
                .ForMember(dest => dest.ExtensionAmt, opt => opt.MapFrom(src => src[62].ToNullableDecimal()))
                .ForMember(dest => dest.UnitOfMeasureConvFactor, opt => opt.MapFrom(src => src[63].ToNullableDecimal()))
                .ForMember(dest => dest.QuantityPerBill, opt => opt.MapFrom(src => src[64].ToNullableDecimal()))
                .ForMember(dest => dest.LineDiscountPercent, opt => opt.MapFrom(src => src[65].ToNullableDecimal()))
                .ForMember(dest => dest.LineWeight, opt => opt.MapFrom(src => src[66].ToNullableDecimal()))
                .ForMember(dest => dest.CommodityCode, opt => opt.MapFrom(src => src[67].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.AlternateTaxIdentifier, opt => opt.MapFrom(src => src[68].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.TaxTypeApplied, opt => opt.MapFrom(src => src[69].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.NetGrossIndicator, opt => opt.MapFrom(src => src[70].ToNullableBool()))
                .ForMember(dest => dest.DebitCreditIndicator, opt => opt.MapFrom(src => src[71].ToNullableChar()))
                .ForMember(dest => dest.TaxAmt, opt => opt.MapFrom(src => src[72].ToNullableDecimal()))
                .ForMember(dest => dest.TaxRate, opt => opt.MapFrom(src => src[73].ToNullableDecimal()));
        }
    }
}
