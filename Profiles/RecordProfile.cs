namespace crgolden.Sage
{
    using AutoMapper;

    public class RecordProfile : Profile
    {
        public RecordProfile()
        {
            CreateMap<string[], Record>()
                .IncludeAllDerived()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.Updated, opt => opt.Ignore())
                .ForMember(dest => dest.DateCreated, opt => opt.MapFrom(src => src[0]))
                .ForMember(dest => dest.TimeCreated, opt => opt.MapFrom(src => src[1]))
                .ForMember(dest => dest.UserCreatedKey, opt => opt.MapFrom(src => src[2]))
                .ForMember(dest => dest.DateUpdated, opt => opt.MapFrom(src => src[3]))
                .ForMember(dest => dest.TimeUpdated, opt => opt.MapFrom(src => src[4]))
                .ForMember(dest => dest.UserUpdatedKey, opt => opt.MapFrom(src => src[5]));
        }
    }
}
