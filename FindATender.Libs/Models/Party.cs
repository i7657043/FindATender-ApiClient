namespace FindATender.Libs.Models
{
    public class Party
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string[] Roles { get; set; }
        public Identifier Identifier { get; set; }
        public Address Address { get; set; }
        public ContactPoint ContactPoint { get; set; }
        public Details Details { get; set; }
    }

    //public class Parties
    //{
    //    public string Id { get; set; }
    //    public InitiationType[] Name { get; set; }
    //    public string[] Roles { get; set; }
    //    public Identifier Identifier { get; set; }
    //    public Address Address { get; set; }
    //    public ContactPoint ContactPoint { get; set; }
    //    public InitiationType[] Roles { get; set; }
    //    public Details Details { get; set; }
    //}
}
