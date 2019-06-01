namespace crgolden.Sage
{
    public abstract class MainAccount : Record
    {
        /// <summary>
        /// Segment Number
        /// DfltVal: 01
        /// Mask: 00
        /// Valid: 01
        /// FmtType: ZEROFILL
        /// Notes: Validated against GL_AccountStructure
        /// </summary>
        public string SegmentNo { get; set; } = "01";

        /// <summary>
        /// Main Account Code
        /// FmtType: ALPHANUM
        /// </summary>
        public string MainAccountCode { get; set; }

        /// <summary>
        /// Main Account Description
        /// </summary>
        public string MainAccountDesc { get; set; }

        /// <summary>
        /// Main Account Short Description
        /// </summary>
        public string MainAccountShortDesc { get; set; }

        /// <summary>
        /// Start Date
        /// Notes: YYYYMMDD
        /// </summary>
        public string DateStart { get; set; }

        /// <summary>
        /// End Date
        /// Notes: YYYYMMDD
        /// </summary>
        public string DateEnd { get; set; }

        /// <summary>
        /// Status.
        /// DfltVal: A
        /// Valid: A, I, D
        /// Notes: A = Active *, I = Inactive, D = Deleted
        /// </summary>
        public char Status { get; set; } = 'A';

        /// <summary>
        /// Clear Balance
        /// DfltVal: N
        /// Valid: Y, N
        /// Notes: Y = Year end, N = Never *
        /// </summary>
        public char ClearBalance { get; set; } = 'N';

        /// <summary>
        /// Account Group
        /// Notes: Validated against GL_AccountGroup
        /// </summary>
        public string AccountGroup { get; set; }

        /// <summary>
        /// Account Category
        /// Read Only: Y
        /// Notes: from GL_AccountGroup
        /// </summary>
        public char AccountCategory { get; set; }

        /// <summary>
        /// Account Type
        /// Mask: 00
        /// FmtType: ZEROFILL
        /// Notes: Validated against GL_AccountType
        /// </summary>
        public string AccountType { get; set; }

        /// <summary>
        /// Cash Flows Type
        /// DfltVal: N
        /// Valid: C, F, N, I, O
        /// Notes: C = Cash, F = Financing, I = Investment, N = None *, O = Operations
        /// </summary>
        public char CashFlowsType { get; set; } = 'N';

        /// <summary>
        /// Rollup Code 1
        /// Notes: Validated against GL_Rollup.Key: "1"+RollupCode1
        /// </summary>
        public string RollupCode1 { get; set; }

        /// <summary>
        /// Rollup Code 2
        /// Notes: Validated against GL_Rollup.Key: "2"+RollupCode2
        /// </summary>
        public string RollupCode2 { get; set; }

        /// <summary>
        /// Rollup Code 3
        /// Notes: Validated against GL_Rollup.Key: "3"+RollupCode3
        /// </summary>
        public string RollupCode3 { get; set; }

        /// <summary>
        /// Rollup Code 4
        /// Notes: Validated againstGL_Rollup.Key: "4"+RollupCode4
        /// </summary>
        public string RollupCode4 { get; set; }

        /// <summary>
        /// Company Code
        /// DfltVal:
        /// Notes: Used to "join" Crystal Tables.
        /// </summary>
        public string CompanyCode { get; set; }

        public new const string DefaultDesc = Record.DefaultDesc +
            "+\"" + Sep + "\"+" +
            "SegmentNo$+\"" + Sep + "\"+" +             // 06
            "MainAccountCode$+\"" + Sep + "\"+" +       // 07
            "MainAccountDesc$+\"" + Sep + "\"+" +       // 08
            "MainAccountShortDesc$+\"" + Sep + "\"+" +  // 09
            "DateStart$+\"" + Sep + "\"+" +             // 10
            "DateEnd$+\"" + Sep + "\"+" +               // 11
            "Status$+\"" + Sep + "\"+" +                // 12
            "ClearBalance$+\"" + Sep + "\"+" +          // 13
            "AccountGroup$+\"" + Sep + "\"+" +          // 14
            "AccountCategory$+\"" + Sep + "\"+" +       // 15
            "AccountType$+\"" + Sep + "\"+" +           // 16
            "CashFlowsType$+\"" + Sep + "\"+" +         // 17
            "RollupCode1$+\"" + Sep + "\"+" +           // 18
            "RollupCode2$+\"" + Sep + "\"+" +           // 19
            "RollupCode3$+\"" + Sep + "\"+" +           // 20
            "RollupCode4$+\"" + Sep + "\"+" +           // 21
            "CompanyCode$";                             // 22
    }
}
