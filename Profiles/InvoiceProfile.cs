namespace Clarity.Sage
{
    public abstract class InvoiceProfile<TLine> : HeaderProfile<TLine>
        where TLine : InvoiceLine
    {
        public InvoiceProfile()
        {
            CreateMap<string[], Invoice<TLine>>()
                .IncludeAllDerived()
                .ForMember(dest => dest.InvoiceNo, opt => opt.MapFrom(src => src[93]))
                .ForMember(dest => dest.InvoiceDate, opt => opt.MapFrom(src => src[94].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.InvoiceType, opt => opt.MapFrom(src => src[95].ToNullableChar()))
                .ForMember(dest => dest.ShipDate, opt => opt.MapFrom(src => src[96].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.PrintInvoice, opt => opt.MapFrom(src => src[97].ToNullableBool()))
                .ForMember(dest => dest.InvoicePrinted, opt => opt.MapFrom(src => src[98].ToNullableBool()))
                .ForMember(dest => dest.AcceptCashOnly, opt => opt.MapFrom(src => src[99].ToNullableBool()))
                .ForMember(dest => dest.CustomerType, opt => opt.MapFrom(src => src[100].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ApplyToInvoiceNo, opt => opt.MapFrom(src => src[101].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.InvoiceDueDate, opt => opt.MapFrom(src => src[102].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.DiscountDueDate, opt => opt.MapFrom(src => src[103].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.BatchNo, opt => opt.MapFrom(src => src[104].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.EMailUpdateFlagForRestart, opt => opt.MapFrom(src => src[105].ToNullableChar()))
                .ForMember(dest => dest.OrderChangedInShipping, opt => opt.MapFrom(src => src[106].ToNullableBool()))
                .ForMember(dest => dest.LinesChangedInShipping, opt => opt.MapFrom(src => src[107].ToNullableBool()))
                .ForMember(dest => dest.ShipperID, opt => opt.MapFrom(src => src[108].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ShipStatus, opt => opt.MapFrom(src => src[109].ToNullableChar()))
                .ForMember(dest => dest.StarshipFreightUsed, opt => opt.MapFrom(src => src[110].ToNullableBool()))
                .ForMember(dest => dest.StarshipRecordsCreated, opt => opt.MapFrom(src => src[111].ToNullableBool()))
                .ForMember(dest => dest.InvalidWarrantyCode, opt => opt.MapFrom(src => src[112].ToNullableBool()))
                .ForMember(dest => dest.RetentionAmt, opt => opt.MapFrom(src => src[113].ToNullableDecimal()))
                .ForMember(dest => dest.TotalSubjectToComm, opt => opt.MapFrom(src => src[114].ToNullableDecimal()))
                .ForMember(dest => dest.CommissionAmt, opt => opt.MapFrom(src => src[115].ToNullableDecimal()))
                .ForMember(dest => dest.OverrideCommAmt, opt => opt.MapFrom(src => src[116].ToNullableDecimal()))
                .ForMember(dest => dest.CostOfGoodsSoldAmt, opt => opt.MapFrom(src => src[117].ToNullableDecimal()))
                .ForMember(dest => dest.CostOfGoodsSoldSubjToComm, opt => opt.MapFrom(src => src[118].ToNullableDecimal()))
                .ForMember(dest => dest.SIShippedLinesCOGS, opt => opt.MapFrom(src => src[119].ToNullableDecimal()))
                .ForMember(dest => dest.NumberOfCODLabels, opt => opt.MapFrom(src => src[120].ToNullableInt()))
                .ForMember(dest => dest.NumberOfBackOrderLines, opt => opt.MapFrom(src => src[121].ToNullableInt()))
                .ForMember(dest => dest.NumberofPackages, opt => opt.MapFrom(src => src[122].ToNullableInt()));
        }
    }
}
