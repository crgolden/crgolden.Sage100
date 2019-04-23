﻿namespace Clarity.Sage
{
    using AutoMapper;

    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<string[], Customer>()
                .IncludeAllDerived()
                .ForMember(dest => dest.ARDivisionNo, opt => opt.MapFrom(src => src[6]))
                .ForMember(dest => dest.CustomerNo, opt => opt.MapFrom(src => src[7]))
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src[8].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.AddressLine1, opt => opt.MapFrom(src => src[9].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.AddressLine2, opt => opt.MapFrom(src => src[10].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.AddressLine3, opt => opt.MapFrom(src => src[11].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src[12].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.State, opt => opt.MapFrom(src => src[13].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ZipCode, opt => opt.MapFrom(src => src[14].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.CountryCode, opt => opt.MapFrom(src => src[15].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.TelephoneNo, opt => opt.MapFrom(src => src[16].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.TelephoneExt, opt => opt.MapFrom(src => src[17].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.FaxNo, opt => opt.MapFrom(src => src[18].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.EmailAddress, opt => opt.MapFrom(src => src[19].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.URLAddress, opt => opt.MapFrom(src => src[20].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.EBMEnabled, opt => opt.MapFrom(src => src[21].ToNullableBool()))
                .ForMember(dest => dest.EBMConsumerUserID, opt => opt.MapFrom(src => src[22].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.BatchFax, opt => opt.MapFrom(src => src[23].ToNullableBool()))
                .ForMember(dest => dest.DefaultCreditCardPmtType, opt => opt.MapFrom(src => src[24].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ContactCode, opt => opt.MapFrom(src => src[25].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.ShipMethod, opt => opt.MapFrom(src => src[26].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.TaxSchedule, opt => opt.MapFrom(src => src[27].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.TaxExemptNo, opt => opt.MapFrom(src => src[28].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.TermsCode, opt => opt.MapFrom(src => src[29].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.SalespersonDivisionNo, opt => opt.MapFrom(src => src[30].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.SalespersonNo, opt => opt.MapFrom(src => src[31].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.SalespersonDivisionNo2, opt => opt.MapFrom(src => src[32].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.SalespersonNo2, opt => opt.MapFrom(src => src[33].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.SalespersonDivisionNo3, opt => opt.MapFrom(src => src[34].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.SalespersonNo3, opt => opt.MapFrom(src => src[35].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.SalespersonDivisionNo4, opt => opt.MapFrom(src => src[36].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.SalespersonNo4, opt => opt.MapFrom(src => src[37].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.SalespersonDivisionNo5, opt => opt.MapFrom(src => src[38].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.SalespersonNo5, opt => opt.MapFrom(src => src[39].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src[40].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.SortField, opt => opt.MapFrom(src => src[41].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.TemporaryCustomer, opt => opt.MapFrom(src => src[42].ToNullableChar()))
                .ForMember(dest => dest.CustomerStatus, opt => opt.MapFrom(src => char.Parse(src[43])))
                .ForMember(dest => dest.InactiveReasonCode, opt => opt.MapFrom(src => src[44].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.OpenItemCustomer, opt => opt.MapFrom(src => src[45].ToNullableBool()))
                .ForMember(dest => dest.ResidentialAddress, opt => opt.MapFrom(src => src[46].ToNullableBool()))
                .ForMember(dest => dest.StatementCycle, opt => opt.MapFrom(src => src[47].ToNullableChar()))
                .ForMember(dest => dest.PrintDunningMessage, opt => opt.MapFrom(src => src[48].ToNullableBool()))
                .ForMember(dest => dest.CustomerType, opt => opt.MapFrom(src => src[49].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.PriceLevel, opt => opt.MapFrom(src => src[50].ToNullableChar()))
                .ForMember(dest => dest.DateLastActivity, opt => opt.MapFrom(src => src[51].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.DateLastPayment, opt => opt.MapFrom(src => src[52].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.DateLastStatement, opt => opt.MapFrom(src => src[53].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.DateLastFinanceChrg, opt => opt.MapFrom(src => src[54].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.DateLastAging, opt => opt.MapFrom(src => src[55].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.DefaultItemCode, opt => opt.MapFrom(src => src[56].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.DefaultCostCode, opt => opt.MapFrom(src => src[57].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.DefaultCostType, opt => opt.MapFrom(src => src[58].ToNullableChar()))
                .ForMember(dest => dest.CreditHold, opt => opt.MapFrom(src => src[59].ToNullableBool()))
                .ForMember(dest => dest.PrimaryShipToCode, opt => opt.MapFrom(src => src[60].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.DateEstablished, opt => opt.MapFrom(src => src[61].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.CreditCardGUID, opt => opt.MapFrom(src => src[62].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.DefaultPaymentType, opt => opt.MapFrom(src => src[63].ToNonEmptyStringOrNull()))
                .ForMember(dest => dest.EmailStatements, opt => opt.MapFrom(src => src[64].ToNullableBool()))
                .ForMember(dest => dest.NumberOfInvToUseInCalc, opt => opt.MapFrom(src => src[65].ToNullableInt()))
                .ForMember(dest => dest.AvgDaysPaymentInvoice, opt => opt.MapFrom(src => src[66].ToNullableInt()))
                .ForMember(dest => dest.AvgDaysOverDue, opt => opt.MapFrom(src => src[67].ToNullableInt()))
                .ForMember(dest => dest.CustomerDiscountRate, opt => opt.MapFrom(src => src[68].ToNullableDecimal()))
                .ForMember(dest => dest.ServiceChargeRate, opt => opt.MapFrom(src => src[69].ToNullableDecimal()))
                .ForMember(dest => dest.CreditLimit, opt => opt.MapFrom(src => src[70].ToNullableDecimal()))
                .ForMember(dest => dest.LastPaymentAmt, opt => opt.MapFrom(src => src[71].ToNullableDecimal()))
                .ForMember(dest => dest.HighestStmntBalance, opt => opt.MapFrom(src => src[72].ToNullableDecimal()))
                .ForMember(dest => dest.UnpaidServiceChrg, opt => opt.MapFrom(src => src[73].ToNullableDecimal()))
                .ForMember(dest => dest.BalanceForward, opt => opt.MapFrom(src => src[74].ToNullableDecimal()))
                .ForMember(dest => dest.CurrentBalance, opt => opt.MapFrom(src => src[75].ToNullableDecimal()))
                .ForMember(dest => dest.AgingCategory1, opt => opt.MapFrom(src => src[76].ToNullableDecimal()))
                .ForMember(dest => dest.AgingCategory2, opt => opt.MapFrom(src => src[77].ToNullableDecimal()))
                .ForMember(dest => dest.AgingCategory3, opt => opt.MapFrom(src => src[78].ToNullableDecimal()))
                .ForMember(dest => dest.AgingCategory4, opt => opt.MapFrom(src => src[79].ToNullableDecimal()))
                .ForMember(dest => dest.OpenOrderAmt, opt => opt.MapFrom(src => src[80].ToNullableDecimal()))
                .ForMember(dest => dest.RetentionCurrent, opt => opt.MapFrom(src => src[81].ToNullableDecimal()))
                .ForMember(dest => dest.RetentionAging1, opt => opt.MapFrom(src => src[82].ToNullableDecimal()))
                .ForMember(dest => dest.RetentionAging2, opt => opt.MapFrom(src => src[83].ToNullableDecimal()))
                .ForMember(dest => dest.RetentionAging3, opt => opt.MapFrom(src => src[84].ToNullableDecimal()))
                .ForMember(dest => dest.RetentionAging4, opt => opt.MapFrom(src => src[85].ToNullableDecimal()))
                .ForMember(dest => dest.SplitCommRate2, opt => opt.MapFrom(src => src[86].ToNullableDecimal()))
                .ForMember(dest => dest.SplitCommRate3, opt => opt.MapFrom(src => src[87].ToNullableDecimal()))
                .ForMember(dest => dest.SplitCommRate4, opt => opt.MapFrom(src => src[88].ToNullableDecimal()))
                .ForMember(dest => dest.SplitCommRate5, opt => opt.MapFrom(src => src[89].ToNullableDecimal()))
                .ForMember(dest => dest.UseSageCloudForInvPrinting, opt => opt.MapFrom(src => src[90].ToNullableBool()));
        }
    }
}
