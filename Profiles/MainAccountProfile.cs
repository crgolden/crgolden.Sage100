namespace crgolden.Sage
{
    using AutoMapper;

    public class MainAccountProfile : Profile
    {
        public MainAccountProfile()
        {
            CreateMap<string[], MainAccount>()
                .IncludeAllDerived()
                .ForMember(dest => dest.SegmentNo, opt => opt.MapFrom(src => src[6]))
                .ForMember(dest => dest.MainAccountCode, opt => opt.MapFrom(src => src[7]))
                .ForMember(dest => dest.MainAccountDesc, opt => opt.MapFrom(src => src[8].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.MainAccountShortDesc, opt => opt.MapFrom(src => src[9].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src[10].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.DateEnd, opt => opt.MapFrom(src => src[11].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => char.Parse(src[12])))
                .ForMember(dest => dest.ClearBalance, opt => opt.MapFrom(src => char.Parse(src[13])))
                .ForMember(dest => dest.AccountGroup, opt => opt.MapFrom(src => src[14]))
                .ForMember(dest => dest.AccountCategory, opt => opt.MapFrom(src => char.Parse(src[15])))
                .ForMember(dest => dest.AccountType, opt => opt.MapFrom(src => src[16]))
                .ForMember(dest => dest.CashFlowsType, opt => opt.MapFrom(src => char.Parse(src[17])))
                .ForMember(dest => dest.RollupCode1, opt => opt.MapFrom(src => src[18].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.RollupCode2, opt => opt.MapFrom(src => src[19].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.RollupCode3, opt => opt.MapFrom(src => src[20].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.RollupCode4, opt => opt.MapFrom(src => src[21].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.CompanyCode, opt => opt.MapFrom(src => src[22]));
        }
    }
}
