namespace FindATender.Libs.Models
{
    public class Item
    {
        public string Id { get; set; }
        public InitiationType[] DeliveryAddresses { get; set; }
        public DeliveryLocation DeliveryLocation { get; set; }
        public string RelatedLot { get; set; }
    }
}
