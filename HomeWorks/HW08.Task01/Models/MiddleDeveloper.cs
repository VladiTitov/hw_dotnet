using System.Collections.Generic;

namespace HW08.Task01.Models
{
    class MiddleDeveloper : Engineer
    {
        public override List<string> Responsibilities { get; set; } = new List<string>()
        {
            "Ability to independently perform tasks assigned to him",
            "Knowledge of projection patterns",
            "Possession of practical development experience"
        };
        public override List<string> Technologies { get; set; } = new List<string>()
        {
            "SOLID",
            "SCRUM",
            "Entity Framework/Core",
            "HTML,CSS,JS"
        };
        public MiddleDeveloper(string firstName, string secondName, int experience, string github) : base(firstName, secondName, experience, github) { }
    }
}
