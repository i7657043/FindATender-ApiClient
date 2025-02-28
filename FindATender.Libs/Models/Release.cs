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

    public class Planning
    {
        public Documents[] Documents { get; set; }
        public Milestones[] Milestones { get; set; }
    }

    public class Documents
    {
        public string Id { get; set; }
        public string DocumentType { get; set; }
        public string NoticeType { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string DatePublished { get; set; }
        public string Format { get; set; }
    }

    public class Milestones
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public string Status { get; set; }
    }
}
