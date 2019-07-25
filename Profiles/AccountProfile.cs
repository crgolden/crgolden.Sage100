namespace crgolden.Sage100
{
    using AutoMapper;

    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<string[], Account>()
                .IncludeAllDerived()
                .ForMember(dest => dest.AccountKey, opt => opt.MapFrom(src => src[6]))
                .ForMember(dest => dest.AccountDesc, opt => opt.MapFrom(src => src[7].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.FormattedAccount, opt => opt.MapFrom(src => src[8]))
                .ForMember(dest => dest.RawAccount, opt => opt.MapFrom(src => src[9]))
                .ForMember(dest => dest.MainAccountCode, opt => opt.MapFrom(src => src[10]))
                .ForMember(dest => dest.DateStart, opt => opt.MapFrom(src => src[11].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.DateEnd, opt => opt.MapFrom(src => src[12].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src[13]))
                .ForMember(dest => dest.ClearBalance, opt => opt.MapFrom(src => src[14]))
                .ForMember(dest => dest.AccountType, opt => opt.MapFrom(src => src[15]))
                .ForMember(dest => dest.CashFlowsType, opt => opt.MapFrom(src => src[16]))
                .ForMember(dest => dest.RollupCode1, opt => opt.MapFrom(src => src[17].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.RollupCode2, opt => opt.MapFrom(src => src[18].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.RollupCode3, opt => opt.MapFrom(src => src[19].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.RollupCode4, opt => opt.MapFrom(src => src[20].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.AccountGroup, opt => opt.MapFrom(src => src[21]))
                .ForMember(dest => dest.AccountCategory, opt => opt.MapFrom(src => src[22]))
                .ForMember(dest => dest.CompanyCode, opt => opt.MapFrom(src => src[23]));
        }
    }
}
