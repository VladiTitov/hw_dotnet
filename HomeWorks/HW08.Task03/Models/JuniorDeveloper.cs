using System.Collections.Generic;

namespace HW08.Task03.Models
{
    class JuniorDeveloper : Engineer
    {
        public override List<string> Responsibilities { get; set; } = new List<string>()
        {
            "Ability to independently perform technical tasks",
            "Ability to implement another piece of typical application logic",
            "Desire to develop and learn"
        };
        public override List<string> Technologies { get; set; } = new List<string>()
        {
            "Entity Framework/Core",
            "SQL",
            "HTML,CSS,JS"
        };
        public JuniorDeveloper(string firstName, string secondName, int experience, string github) : base(firstName, secondName, experience, github) { }
    }
}
