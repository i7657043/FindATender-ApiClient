using FindATender.Libs;
using FindATender.Libs.Models;

internal class Program
{
    private static async Task Main(string[] args)
    {
        IFindATenderClient client = new FindATenderClient();

        TenderResponse response = await client.GetTendersAsync(
            new DateTime(2025, 02, 20, 8, 0, 0),
            new DateTime(2025, 02, 21, 8, 0, 0));

        //TenderResponse filteredResponse = response.Filter()
    }
}