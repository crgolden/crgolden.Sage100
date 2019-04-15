namespace Clarity.Sage
{
    public abstract class Account : Record
    {
        /// <summary>
        /// Account Number
        /// Read Only: Y
        /// </summary>
        public string AccountKey { get; set; }

        /// <summary>
        /// Account Description
        /// </summary>
        public string AccountDesc { get; set; }

        /// <summary>
        /// Fully Formatted Account Number
        /// </summary>
        public string FormattedAccount { get; set; }

        /// <summary>
        /// Unformatted Account Number
        /// Read Only: Y
        /// </summary>
        public string RawAccount { get; set; }

        /// <summary>
        /// Main Account
        /// Read Only: Y
        /// FmtType: ALPHANUM
        /// Notes: Validated against GL_MainAccount
        /// </summary>
        public string MainAccountCode { get; set; }

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
        /// Status
        /// DfltVal: A
        /// Valid: A, I, D
        /// Notes: A = Active, I = Inactive, D = Deleted
        /// </summary>
        public char Status { get; set; }

        /// <summary>
        /// Clear Balance
        /// DfltVal: N
        /// Valid: Y, N
        /// Notes: Y = Year end, N = Never *
        /// </summary>
        public char ClearBalance { get; set; }

        /// <summary>
        /// Account Type
        /// Read Only: Y
        /// Mask: 00
        /// FmtType: ZEROFILL
        /// Notes: from GL_MainAccount
        /// </summary>
        public string AccountType { get; set; }

        /// <summary>
        /// Cash Flows Type
        /// DfltVal: N
        /// Valid: C, F, I, N, O
        /// Notes: Defaults from GL_MainAccount.
        /// C = Cash, F = Financing, I = Investment,
        /// N = None * , O = Operations
        /// </summary>
        public char CashFlowsType { get; set; }

        /// <summary>
        /// Rollup Code 1
        /// Notes: Validated against GL_Rollup.
        /// Key: "1"+RollupCode1
        /// </summary>
        public string RollupCode1 { get; set; }

        /// <summary>
        /// Rollup Code 2
        /// Notes: Validated against GL_Rollup.
        /// Key: "2"+RollupCode2
        /// </summary>
        public string RollupCode2 { get; set; }

        /// <summary>
        /// Rollup Code 3
        /// Notes: Validated against GL_Rollup.
        /// Key: "3"+RollupCode3
        /// </summary>
        public string RollupCode3 { get; set; }

        /// <summary>
        /// Rollup Code 4
        /// Notes: Validated against GL_Rollup.
        /// Key: "4"+RollupCode4
        /// </summary>
        public string RollupCode4 { get; set; }

        /// <summary>
        /// Account Group
        /// Read Only: Y
        /// Notes: from GL_MainAccount
        /// </summary>
        public string AccountGroup { get; set; }

        /// <summary>
        /// Account Category
        /// Read Only: Y
        /// Notes: from GL_MainAccount
        /// </summary>
        public char AccountCategory { get; set; }

        /// <summary>
        /// Company Code
        /// DfltVal:
        /// Notes: Used to "join" Crystal Tables.
        /// </summary>
        public string CompanyCode { get; set; }

        public new const string DefaultDesc = Record.DefaultDesc +
            "+\"" + Sep + "\"+" +
            "AccountKey$+\"" + Sep + "\"+" +        // 06
            "AccountDesc$+\"" + Sep + "\"+" +       // 07
            "Account$+\"" + Sep + "\"+" +           // 08
            "RawAccount$+\"" + Sep + "\"+" +        // 09
            "MainAccountCode$+\"" + Sep + "\"+" +   // 10
            "DateStart$+\"" + Sep + "\"+" +         // 11
            "DateEnd$+\"" + Sep + "\"+" +           // 12
            "Status$+\"" + Sep + "\"+" +            // 13
            "ClearBalance$+\"" + Sep + "\"+" +      // 14
            "AccountType$+\"" + Sep + "\"+" +       // 15
            "CashFlowsType$+\"" + Sep + "\"+" +     // 16
            "RollupCode1$+\"" + Sep + "\"+" +       // 17
            "RollupCode2$+\"" + Sep + "\"+" +       // 18
            "RollupCode3$+\"" + Sep + "\"+" +       // 19
            "RollupCode4$+\"" + Sep + "\"+" +       // 20
            "AccountGroup$+\"" + Sep + "\"+" +      // 21
            "AccountCategory$+\"" + Sep + "\"+" +   // 22
            "CompanyCode$";                         // 23
    }
}
