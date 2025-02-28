using System;

namespace FindATender.Libs.Models
{
    public class TenderResponse
    {
        public string Uri { get; set; }
        public DateTime PublishedDate { get; set; }
        public string License { get; set; }
        public string PublicationPolicy { get; set; }
        public DateTime Version { get; set; }
        public string[] Extensions { get; set; }
        public string[] Packages { get; set; }
        public Publisher Publisher { get; set; }
        public Release[] Releases { get; set; }
    }
}
