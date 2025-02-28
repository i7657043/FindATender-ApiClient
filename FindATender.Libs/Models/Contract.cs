using System;

namespace FindATender.Libs.Models
{
    public class Contract
    {
        public string Id { get; set; }
        public string AwardID { get; set; }
        public string Status { get; set; }
        public DateTime DateSigned { get; set; }
    }
}
