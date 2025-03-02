using FindATender.Libs.Models;
using FindATender.Libs;
internal class Program
{
    private static async Task Main(string[] args)
    {
        IFindATenderClient client = new FindATenderClient();

        TenderResponse response = await client.GetTendersAsync(
            new DateTime(2025, 02, 26, 8, 0, 0),
            new DateTime(2025, 02, 26, 11, 0, 0));

        TenderResponse filtered = FilterOnNoticeTypes(response);

        Console.WriteLine($"Found {filtered.Releases.Count} with filled Noticetypes");
    }

    private static TenderResponse FilterOnNoticeTypes(TenderResponse response)
    {
        List<Release> allFitlered = new List<Release>();

        allFitlered.AddRange(response.Releases
            .Where(release => release.Planning?.Documents?.Any(
                document => IsNoticeTypeFilled(release, document, "Releases.Planning.Documents")) == true)
            .ToList());

        allFitlered.AddRange(response.Releases
            .Where(release => release.Tender?.Documents?.Any(
                document => IsNoticeTypeFilled(release, document, "Releases.Tender.Documents")) == true)
            .ToList());

        allFitlered.AddRange(response.Releases
            .Where(release => release.Contracts?.Any(
                contract => contract.Documents?.Any(
                    document => IsNoticeTypeFilled(release, document, "Releases.Contracts[].Documents")) == true) == true)
            .ToList());

        return new TenderResponse() { Releases = allFitlered };
    }

    private static bool IsNoticeTypeFilled(Release release, Document document, string path)
    {
        bool noticeTypeFilled = !string.IsNullOrEmpty(document.NoticeType);

        if (noticeTypeFilled)
            Console.WriteLine($"Ocid: {release.Ocid}\n  Noticetype: {document.NoticeType}\n  Obj Path: {path}\n");

        return noticeTypeFilled;
    }
}