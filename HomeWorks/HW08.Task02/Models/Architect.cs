using System.Collections.Generic;

namespace HW08.Task02.Models
{
    class Architect : Engineer
    {
        public override List<string> Responsibilities { get; set; } = new List<string>()
        {
            "Understanding the client's business",
            "The ability to analyze complex technical systems, and then convey this understanding to the customer and developers",
            "Broad outlook in terms of platforms and components available on the market from which a solution can be synthesized"
        };
        public override List<string> Technologies { get; set; } = new List<string>()
        {
            "TCP/IP",
            "CI/CD processes",
            "SCRUM",
            "Azure",
            "TFS"
        };
        public Architect(string firstName, string secondName, int experience, string github) : base(firstName, secondName, experience, github) { }
    }
}
