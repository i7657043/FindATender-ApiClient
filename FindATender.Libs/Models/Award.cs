namespace FindATender.Libs.Models
{
    public class Award
    {
        public string Id { get; set; }
        public string[] RelatedLots { get; set; }
        public string Status { get; set; }
        public Supplier[] Suppliers { get; set; }
    }
}
