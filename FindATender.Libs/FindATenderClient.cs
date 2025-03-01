using FindATender.Libs.Extensions;
using FindATender.Libs.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace FindATender.Libs
{
    public class FindATenderClient : IFindATenderClient
    {
        private readonly string _baseUrl = "https://www.find-tender.service.gov.uk/api/1.0/ocdsReleasePackages";
        private readonly string _tokenisedQueryString = "?updatedFrom={FromDate}&updatedTo={ToDate}";
        private readonly string _dateTimeFormat = "yyyy-MM-ddThh:mm:ss";

        private readonly HttpClient _httpClient;

        public FindATenderClient()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri(_baseUrl)
            };
        }

        public async Task<TenderResponse> GetTendersAsync(DateTime fromDate, DateTime toDate, int pagesRequestWaitMillisecs = 1000)
        {
            Console.WriteLine("Fetching tenders...");

            string queryString = _tokenisedQueryString.ReplaceTokensInQueryString(
                fromDate.ToString(_dateTimeFormat),
                toDate.ToString(_dateTimeFormat));

            TenderResponse tenderResponse = await GetAllTenderPages(pagesRequestWaitMillisecs, queryString);

            Console.WriteLine($"Found {tenderResponse.Releases.Count} tenders");

            return tenderResponse;
        }

        private async Task<TenderResponse> GetAllTenderPages(int pagesRequestWaitMillisecs, string queryString)
        {
            TenderResponse tenderResponse = await GetPage($"{_baseUrl}{queryString}");

            if (string.IsNullOrEmpty(tenderResponse.Links?.Next))
                return tenderResponse;

            string nextLink = tenderResponse.Links.Next;

            while (!string.IsNullOrEmpty(nextLink))
            {
                await Task.Delay(pagesRequestWaitMillisecs);

                TenderResponse nextPage = await GetPage(nextLink);
                tenderResponse.Releases.AddRange(nextPage.Releases);

                nextLink = nextPage.Links?.Next;
            }

            return tenderResponse;
        }

        private async Task<TenderResponse> GetPage(string urlPostfix)
        {
            HttpResponseMessage httpResponse = await _httpClient.GetAsync(urlPostfix);

            string content = await httpResponse.EnsureSuccessStatusCode().Content.ReadAsStringAsync();

            TenderResponse tenderResponse = JsonConvert.DeserializeObject<TenderResponse>(content);

            return tenderResponse;
        }
    }
}
