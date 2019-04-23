namespace Clarity.Sage
{
    public abstract class OrderProfile<TLine> : HeaderProfile<TLine>
        where TLine : OrderLine
    {
        public OrderProfile()
        {
            CreateMap<string[], Order<TLine>>()
                .IncludeAllDerived()
                .ForMember(dest => dest.MasterRepeatingOrderNo, opt => opt.MapFrom(src => src[93].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ShipExpireDate, opt => opt.MapFrom(src => src[94].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.PrintSalesOrders, opt => opt.MapFrom(src => src[95].ToNullableBool()))
                .ForMember(dest => dest.SalesOrderPrinted, opt => opt.MapFrom(src => src[96].ToNullableBool()))
                .ForMember(dest => dest.PrintPickingSheets, opt => opt.MapFrom(src => src[97].ToNullableBool()))
                .ForMember(dest => dest.PickingSheetPrinted, opt => opt.MapFrom(src => src[98].ToNullableBool()))
                .ForMember(dest => dest.LastInvoiceOrderDate, opt => opt.MapFrom(src => src[99].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.LastInvoiceOrderNo, opt => opt.MapFrom(src => src[100].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.CurrentInvoiceNo, opt => opt.MapFrom(src => src[101].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.CycleCode, opt => opt.MapFrom(src => src[102].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.CancelReasonCode, opt => opt.MapFrom(src => src[103].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.CRMProspectID, opt => opt.MapFrom(src => src[104].ToNonEmptyStringOrNull()));
        }
    }
}
