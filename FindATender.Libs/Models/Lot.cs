namespace FindATender.Libs.Models
{
    public class Lot
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public bool HasOptions { get; set; }
        public string Status { get; set; }
        public AwardCriteria AwardCriteria { get; set; }
    }

    //public class Lots
    //{
    //    public string Id { get; set; }
    //    public InitiationType[] Description { get; set; }
    //    public AwardCriteria AwardCriteria { get; set; }
    //    public InitiationType[] HasOptions { get; set; }
    //    public InitiationType[] Status { get; set; }
    //}
}
