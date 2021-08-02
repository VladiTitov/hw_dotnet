using System;

namespace HW08.Task03.Models.Interfaces
{
    interface IEngineer
    {
        Guid ID { get; }
        string FirstName { get; }
        string SecondName { get; }
        int Experience { get; }
        string GitHub { get; }

        int GetSalary();
    }
}
