using System;

namespace FindATender.Libs.Models
{
    public class InitiationType
    {
        public string ReleaseID { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string[] ReleaseTag { get; set; }
        public string Value { get; set; }
    }
}
