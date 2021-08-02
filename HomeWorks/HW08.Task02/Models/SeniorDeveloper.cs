using System.Collections.Generic;

namespace HW08.Task02.Models
{
    class SeniorDeveloper : Engineer
    {
        public override List<string> Responsibilities { get; set; } = new List<string>()
        {
            "Possession of practical development experience",
            "Ability to make the right technological decisions in a project",
            "Ability to solve slightly more complex problems, to do it faster or better"
        };
        public override List<string> Technologies { get; set; } = new List<string>()
        {
            "Design patterns",
            "Managment skills",
            "SOLID",
            "HTML,CSS,JS"
        };
        public SeniorDeveloper(string firstName, string secondName, int experience, string github) : base(firstName, secondName, experience, github) { }
    }
}
