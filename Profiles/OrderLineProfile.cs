namespace Clarity.Sage
{
    public class OrderLineProfile : LineProfile
    {
        public OrderLineProfile()
        {
            CreateMap<string[], OrderLine>()
                .IncludeAllDerived()
                .ForMember(dest => dest.SalesOrderNo, opt => opt.MapFrom(src => src[67]))
                .ForMember(dest => dest.MasterOrderLineKey, opt => opt.MapFrom(src => src[68].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.PrintDropShipment, opt => opt.MapFrom(src => src[69].ToNullableChar()))
                .ForMember(dest => dest.MasterOriginalQty, opt => opt.MapFrom(src => src[70].ToNullableDecimal()))
                .ForMember(dest => dest.MasterQtyBalance, opt => opt.MapFrom(src => src[71].ToNullableDecimal()))
                .ForMember(dest => dest.MasterQtyOrderedToDate, opt => opt.MapFrom(src => src[72].ToNullableDecimal()))
                .ForMember(dest => dest.RepeatingQtyShippedToDate, opt => opt.MapFrom(src => src[73].ToNullableDecimal()));
        }
    }
}
