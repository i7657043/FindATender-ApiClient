using FindATender.Libs.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace FindATender.Libs
{
    public class FindATenderClient
    {
        private readonly string _baseUrl = "https://www.find-tender.service.gov.uk/api/1.0/ocdsReleasePackages";

        private readonly HttpClient _httpClient;

        public FindATenderClient()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri(_baseUrl)
            };
        }

        public async Task<TenderResponse> GetTenderAsync(string urlPostfix)
        {            
            try
            {
                HttpResponseMessage httpResponse = await _httpClient.GetAsync(urlPostfix);
                //httpResponse.EnsureSuccessStatusCode();

                //We need to get the links.next url and parse response until theres none left, then return

                string content = await httpResponse.Content.ReadAsStringAsync();

                TenderResponse tenderResponse = JsonConvert.DeserializeObject<TenderResponse>(content);

                return tenderResponse;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
