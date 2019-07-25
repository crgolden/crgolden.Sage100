namespace crgolden.Sage100
{
    public static class StringExtensions
    {
        public static string ToNonEmptyStringOrNull(this string value)
        {
            return string.IsNullOrEmpty(value) ? null : value;
        }

        public static decimal? ToNullableDecimal(this string value)
        {
            return decimal.TryParse(value, out var retVal) ? (decimal?)retVal : null;
        }

        public static int? ToNullableInt(this string value)
        {
            return int.TryParse(value, out var retVal) ? (int?)retVal : null;
        }
    }
}
