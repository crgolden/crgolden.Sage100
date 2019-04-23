namespace Clarity.Sage
{
    public class InvoiceLineProfile : LineProfile
    {
        public InvoiceLineProfile()
        {
            CreateMap<string[], InvoiceLine>()
                .IncludeAllDerived()
                .ForMember(dest => dest.InvoiceNo, opt => opt.MapFrom(src => src[67]))
                .ForMember(dest => dest.ProductLine, opt => opt.MapFrom(src => src[68].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.OrderWarehouse, opt => opt.MapFrom(src => src[69].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.OrderLineKey, opt => opt.MapFrom(src => src[70].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ExtendedCost, opt => opt.MapFrom(src => src[71].ToNullableDecimal()))
                .ForMember(dest => dest.ExtendedNegQtyAdj, opt => opt.MapFrom(src => src[72].ToNullableDecimal()))
                .ForMember(dest => dest.CommissionAmt, opt => opt.MapFrom(src => src[73].ToNullableDecimal()));
        }
    }
}
