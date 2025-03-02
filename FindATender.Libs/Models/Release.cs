using System;

namespace FindATender.Libs.Models
{
    public class Release
    {
        public string Ocid { get; set; }
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string[] Tag { get; set; }
        public string InitiationType { get; set; }
        public string Language { get; set; }
        public Tender Tender { get; set; }
        public Award[] Awards { get; set; }
        public Party[] Parties { get; set; }
        public Supplier Buyer { get; set; }
        public Planning Planning { get; set; }
        public Contract[] Contracts { get; set; }
        public Bid Bids { get; set; }
    }
}
