using System;
using System.Collections.Generic;
using HW08.Task02.Constants;
using HW08.Task02.Models;

namespace HW08.Task02.Services
{
    class EngineerCreatorService
    {
        private readonly Random _random = new Random();

        public List<Engineer> GetEngineers()
        {
            int magicCoefficient = 3;
            List<Engineer> engineers = new List<Engineer>();

            int architectCount = _random.Next(1, magicCoefficient);
            int teamOrTeachLeaderCount = architectCount * _random.Next(1, magicCoefficient);
            int seniorDeveloperCount = teamOrTeachLeaderCount * _random.Next(1, magicCoefficient);
            int middleDeveloperCount = seniorDeveloperCount * _random.Next(1, magicCoefficient);
            int juniorDeveloperCount = middleDeveloperCount * _random.Next(1, magicCoefficient);

            engineers.AddRange(GetEngineersOneCategory<Architect>(architectCount));
            engineers.AddRange(GetEngineersOneCategory<TeamOrTeachLeader>(teamOrTeachLeaderCount));
            engineers.AddRange(GetEngineersOneCategory<SeniorDeveloper>(seniorDeveloperCount));
            engineers.AddRange(GetEngineersOneCategory<MiddleDeveloper>(middleDeveloperCount));
            engineers.AddRange(GetEngineersOneCategory<JuniorDeveloper>(juniorDeveloperCount));
            return engineers;
        }

        private List<T> GetEngineersOneCategory<T>(int count)
        {
            List<T> engineers = new List<T>();
            for (int i = 0; i < count; i++)
            {
                string firstName = ConstantArrays.FirstName[_random.Next(0, 9)];
                string secondName = ConstantArrays.SecondName[_random.Next(0, 9)];

                var item = (T)Activator.CreateInstance(typeof(T), new object[]
                {
                    firstName,
                    secondName,
                    _random.Next(1,10),
                    "https://github.com/"+$"{firstName}{secondName}"
                });
                engineers.Add(item);
            }
            return engineers;
        }
    }
}
