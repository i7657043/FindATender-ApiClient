namespace FindATender.Libs.Models
{
    public class VersionedRelease
    {
        public string Ocid { get; set; }
        public InitiationType[] InitiationType { get; set; }
        public Tender Tender { get; set; }
        public Award[] Awards { get; set; }
        public Party[] Parties { get; set; }
        public Supplier Buyer { get; set; }
        public Contract[] Contracts { get; set; }
        public Bid Bids { get; set; }
        public InitiationType[] Language { get; set; }
    }
}
