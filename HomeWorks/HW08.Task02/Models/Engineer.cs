using System;
using System.Collections.Generic;

namespace HW08.Task02.Models
{
    public abstract class Engineer
    {
        private Guid ID { get; }
        private string FirstName { get; }
        private string SecondName { get; }
        public int Experience { get; }
        public virtual List<string> Responsibilities { get; set; } = new List<string>();
        public virtual List<string> Technologies { get; set; } = new List<string>();
        private string GitHub { get; }

        protected Engineer(string firstName, string secondName, int experience, string github)
        {
            ID = Guid.NewGuid();
            FirstName = firstName;
            SecondName = secondName;
            Experience = experience;
            Technologies.AddRange(new List<string>() { "English", "C#", "Git" });
            GitHub = github;
        }

        public int GetSalary() => this switch
        {
            MiddleDeveloper _ => 500 * 3,
            SeniorDeveloper _ => 500 * 5 + 300,
            TeamOrTeachLeader _ => 500 * 8 + 500,
            Architect _ => 500 * 12 + 1000,
            _ => 500
        };

        public override string ToString() =>
            $"Full Name: {FirstName} {SecondName}, Experience: {Experience}, Title: {this.GetType().Name}, Salary: {GetSalary()}, GitHub: {GitHub}";
    }
}
