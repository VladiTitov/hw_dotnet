using System;
using System.Collections.Generic;
using System.Text;

namespace HW08.Task03.Models
{
    class TeamOrTeachLeader : Engineer
    {
        public override List<string> Responsibilities { get; set; } = new List<string>()
        {
            "Ability to combine technically competent solutions with quality development processes"
        };
        public override List<string> Technologies { get; set; } = new List<string>()
        {
            "Design patterns",
            "Managment skills",
            "SOLID",
        };

        public TeamOrTeachLeader(string firstName, string secondName, int experience, string github) : base(firstName, secondName, experience, github) { }
    }
}
