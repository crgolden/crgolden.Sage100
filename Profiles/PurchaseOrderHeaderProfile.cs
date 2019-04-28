﻿namespace Clarity.Sage
{
    public abstract class PurchaseOrderHeaderProfile<TLine> : RecordProfile
        where TLine : PurchaseOrderDetail
    {
        public PurchaseOrderHeaderProfile()
        {
            CreateMap<string[], PurchaseOrderHeader<TLine>>()
                .IncludeAllDerived()
                .ForMember(dest => dest.PurchaseOrderNo, opt => opt.MapFrom(src => src[6]))
                .ForMember(dest => dest.PurchaseOrderDate, opt => opt.MapFrom(src => src[7]))
                .ForMember(dest => dest.OrderType, opt => opt.MapFrom(src => char.Parse(src[8])))
                .ForMember(dest => dest.MasterRepeatingOrderNo, opt => opt.MapFrom(src => src[9].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.RequiredExpireDate, opt => opt.MapFrom(src => src[10].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.APDivisionNo, opt => opt.MapFrom(src => src[11].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.VendorNo, opt => opt.MapFrom(src => src[12].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.PurchaseName, opt => opt.MapFrom(src => src[13].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.PurchaseAddress1, opt => opt.MapFrom(src => src[14].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.PurchaseAddress2, opt => opt.MapFrom(src => src[15].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.PurchaseAddress3, opt => opt.MapFrom(src => src[16].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.PurchaseCity, opt => opt.MapFrom(src => src[17].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.PurchaseState, opt => opt.MapFrom(src => src[18].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.PurchaseZipCode, opt => opt.MapFrom(src => src[19].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.PurchaseCountryCode, opt => opt.MapFrom(src => src[20].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.PurchaseAddressCode, opt => opt.MapFrom(src => src[21].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ShipToCode, opt => opt.MapFrom(src => src[22].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ShipToName, opt => opt.MapFrom(src => src[23].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ShipToAddress1, opt => opt.MapFrom(src => src[24].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ShipToAddress2, opt => opt.MapFrom(src => src[25].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ShipToAddress3, opt => opt.MapFrom(src => src[26].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ShipToCity, opt => opt.MapFrom(src => src[27].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ShipToState, opt => opt.MapFrom(src => src[28].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ShipToZipCode, opt => opt.MapFrom(src => src[29].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ShipToCountryCode, opt => opt.MapFrom(src => src[30].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.OrderStatus, opt => opt.MapFrom(src => src[31].ToNullableChar()))
                .ForMember(dest => dest.UseTax, opt => opt.MapFrom(src => src[32].ToNullableBool()))
                .ForMember(dest => dest.PrintPurchaseOrders, opt => opt.MapFrom(src => src[33].ToNullableBool()))
                .ForMember(dest => dest.OnHold, opt => opt.MapFrom(src => src[34].ToNullableBool()))
                .ForMember(dest => dest.BatchFax, opt => opt.MapFrom(src => src[35].ToNullableBool()))
                .ForMember(dest => dest.BatchEmail, opt => opt.MapFrom(src => src[36].ToNullableBool()))
                .ForMember(dest => dest.EmailAddress, opt => opt.MapFrom(src => src[37].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.CompletionDate, opt => opt.MapFrom(src => src[38].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ShipVia, opt => opt.MapFrom(src => src[39].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.FOB, opt => opt.MapFrom(src => src[40].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.WarehouseCode, opt => opt.MapFrom(src => src[41].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ConfirmTo, opt => opt.MapFrom(src => src[42].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src[43].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ARDivisionNo, opt => opt.MapFrom(src => src[44].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.CustomerNo, opt => opt.MapFrom(src => src[45].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.TermsCode, opt => opt.MapFrom(src => src[46].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.LastInvoiceDate, opt => opt.MapFrom(src => src[47].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.LastInvoiceNo, opt => opt.MapFrom(src => src[48].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.Form1099, opt => opt.MapFrom(src => src[49].ToNullableChar()))
                .ForMember(dest => dest.Box1099, opt => opt.MapFrom(src => src[50].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.LastReceiptDate, opt => opt.MapFrom(src => src[51].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.LastIssueDate, opt => opt.MapFrom(src => src[52].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.LastPurchaseOrderDate, opt => opt.MapFrom(src => src[53].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.LastReceiptNo, opt => opt.MapFrom(src => src[54].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.LastIssueNo, opt => opt.MapFrom(src => src[55].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.LastPurchaseOrderNo, opt => opt.MapFrom(src => src[56].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.PrepaidCheckNo, opt => opt.MapFrom(src => src[57].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.FaxNo, opt => opt.MapFrom(src => src[58].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.TaxSchedule, opt => opt.MapFrom(src => src[59].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.InvalidTaxCalc, opt => opt.MapFrom(src => src[60].ToNullableBool()))
                .ForMember(dest => dest.SalesOrderNo, opt => opt.MapFrom(src => src[61].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.RequisitorName, opt => opt.MapFrom(src => src[62].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.RequisitorDepartment, opt => opt.MapFrom(src => src[63].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.PrepaidAmt, opt => opt.MapFrom(src => src[64].ToNullableDecimal()))
                .ForMember(dest => dest.TaxableAmt, opt => opt.MapFrom(src => src[65].ToNullableDecimal()))
                .ForMember(dest => dest.NonTaxableAmt, opt => opt.MapFrom(src => src[66].ToNullableDecimal()))
                .ForMember(dest => dest.SalesTaxAmt, opt => opt.MapFrom(src => src[67].ToNullableDecimal()))
                .ForMember(dest => dest.FreightAmt, opt => opt.MapFrom(src => src[68].ToNullableDecimal()))
                .ForMember(dest => dest.PrepaidFreightAmt, opt => opt.MapFrom(src => src[69].ToNullableDecimal()))
                .ForMember(dest => dest.InvoicedAmt, opt => opt.MapFrom(src => src[70].ToNullableDecimal()))
                .ForMember(dest => dest.ReceivedAmt, opt => opt.MapFrom(src => src[71].ToNullableDecimal()))
                .ForMember(dest => dest.FreightSalesTaxInvAmt, opt => opt.MapFrom(src => src[72].ToNullableDecimal()))
                .ForMember(dest => dest.BackOrderLostAmt, opt => opt.MapFrom(src => src[73].ToNullableDecimal()))
                .ForMember(dest => dest.Lines, opt => opt.Ignore());
        }
    }
}
