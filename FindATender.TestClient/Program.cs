using FindATender.Libs;
using FindATender.Libs.Models;
using Newtonsoft.Json;

internal class Program
{
    private static async Task Main(string[] args)
    {
        FindATenderClient client = new FindATenderClient();

        //TenderResponse response = await client.GetTenderAsync("/ocds-h6vhtk-04e877");

        Console.WriteLine("Fetching API response...");

        TenderResponse response = await client.GetTenderAsync("?updatedFrom=2025-02-20T08:00:00&updatedTo=2025-02-22T10:00:00"); //&cursor=MTAwM==

        //TenderResponse filteredResponse = response.Filter()

        Console.WriteLine(
            $"{JsonConvert.SerializeObject(response, Formatting.Indented)}\n\n" +
            $"Found {response.Releases.Count()} notices");

        //In the scraper we have custom filtering, we need to apply that to the response
    }
}

internal static class Extensions
{
    private static IEnumerable<Release> Filter(this TenderResponse tenders, string[] noticeTypes) =>
        tenders.Releases.Where(release => release.Planning.Documents.Any(doc => doc.NoticeType == ""));
}