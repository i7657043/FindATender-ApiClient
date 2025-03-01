using FindATender.Libs.Models;
using System;
using System.Threading.Tasks;

namespace FindATender.Libs
{
    public interface IFindATenderClient
    {
        Task<TenderResponse> GetTendersAsync(DateTime fromDate, DateTime toDate, int pagesRequestWaitMillisecs = 1000);
    }
}
