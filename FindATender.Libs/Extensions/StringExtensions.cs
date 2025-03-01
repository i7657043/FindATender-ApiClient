namespace FindATender.Libs.Extensions
{
    public static class StringExtensions
    {
        public static string ReplaceTokensInQueryString(this string tokenisedQueryString, string fromDate, string toDate) =>
            tokenisedQueryString.Replace("{FromDate}", fromDate).Replace("{ToDate}", toDate);
    }
}
