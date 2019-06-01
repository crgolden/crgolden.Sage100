namespace crgolden.Sage
{
    using Abstractions;

    public abstract class Record : Entity
    {
        /// <summary>
        /// Creation Date
        /// Read Only: Y
        /// Notes: YYYYMMDD
        /// </summary>
        public string DateCreated { get; set; }

        /// <summary>
        /// Creation Time
        /// Read Only: Y
        /// </summary>
        public string TimeCreated { get; set; }

        /// <summary>
        /// Creation User ID
        /// Read Only: Y
        /// Mask: 0000000000
        /// FmtType: ZEROFILL
        /// </summary>
        public string UserCreatedKey { get; set; }

        /// <summary>
        /// Last Update Date
        /// Read Only: Y
        /// Notes: YYYYMMDD
        /// </summary>
        public string DateUpdated { get; set; }

        /// <summary>
        /// Last Update Time
        /// Read Only: Y
        /// </summary>
        public string TimeUpdated { get; set; }

        /// <summary>
        /// Last Update User ID
        /// Read Only: Y
        /// Mask: 0000000000
        /// FmtType: ZEROFILL
        /// </summary>
        public string UserUpdatedKey { get; set; }

        public const string Sep = "_,_";

        public const string DefaultDesc =
            "DateCreated$+\"" + Sep + "\"+" +       // 00
            "TimeCreated$+\"" + Sep + "\"+" +       // 01
            "UserCreatedKey$+\"" + Sep + "\"+" +    // 02
            "DateUpdated$+\"" + Sep + "\"+" +       // 03
            "TimeUpdated$+\"" + Sep + "\"+" +       // 04
            "UserUpdatedKey$";                      // 05
    }
}
