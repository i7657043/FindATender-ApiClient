namespace FindATender.Libs.Models
{
    public class Tender
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string MainProcurementCategory { get; set; }
        public string Description { get; set; }
        public string ProcurementMethod { get; set; }
        public string ProcurementMethodDetails { get; set; }
        public string ProcurementMethodRationale { get; set; }
        public LegalBasis LegalBasis { get; set; }
        public Classification Classification { get; set; }
        public Lot[] Lots { get; set; }
        public Item[] Items { get; set; }
        public Classification[] ProcurementMethodRationaleClassifications { get; set; }
        public Document[] Documents { get; set; }
    }

    //public class Tender
    //{
    //    public InitiationType[] Id { get; set; }
    //    public InitiationType[] Title { get; set; }
    //    public InitiationType[] Status { get; set; }
    //    public InitiationType[] MainProcurementCategory { get; set; }
    //    public InitiationType[] Description { get; set; }
    //    public InitiationType[] ProcurementMethod { get; set; }
    //    public InitiationType[] ProcurementMethodDetails { get; set; }
    //    public InitiationType[] ProcurementMethodRationale { get; set; }
    //    public LegalBasis LegalBasis { get; set; }
    //    public Classification Classification { get; set; }
    //    public Lots[] Lots { get; set; }
    //    public Items[] Items { get; set; }
    //    public InitiationType[] ProcurementMethodRationaleClassifications { get; set; }
    //}
}
