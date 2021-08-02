using System;
using System.Collections.Generic;
using System.Linq;
using HW08.Task03.Constants;
using HW08.Task03.Models;
using HW08.Task03.Models.Interfaces;

namespace HW08.Task03.Services
{
    class CompanyCreatorService
    {
        private readonly Random _random = new Random();

        private Dictionary<string, List<IEngineer>> _companyAndEmployeesDictionary = new Dictionary<string, List<IEngineer>>();

        private Dictionary<int, string> _companyMenu;

        public void Start()
        {
            CreateDictionary(_random.Next(2, 15), ref _companyAndEmployeesDictionary);
            _companyMenu = GetCompaniesList();

            Console.WriteLine($"{new string('.', 30)}\nSelect company [1-{_companyMenu.Count}]:\n{new string('.', 30)}");
            ShowMenu(_companyMenu);
            ShowEmployees(MenuEvents());
        }

        private string MenuEvents()
        {
            int key = StepValidation();
            while (!_companyMenu.ContainsKey(key))
            {
                Console.WriteLine("Companies with such a serial number were not found, try again");
                key = StepValidation();
            }
            return _companyMenu[key];
        }

        private void ShowEmployees(string company)
        {
            foreach (var engineer in _companyAndEmployeesDictionary[company])
                Console.WriteLine($"Company: {company}, {engineer}");
        }

        private void CreateDictionary(int n, ref Dictionary<string, List<IEngineer>> dictionary)
        {
            int maxValue = ConstantArrays.Companies.Length - 1;

            for (int i = 0; i < n; i++)
            {
                string company = ConstantArrays.Companies[_random.Next(maxValue)];
                while (dictionary.ContainsKey(company))
                {
                    company = ConstantArrays.Companies[_random.Next(maxValue)];
                }
                dictionary.Add(company, new EngineerCreatorService().GetEngineers());
            }
        }

        private Dictionary<int, string> GetCompaniesList()
        {
            Dictionary<int, string> keysAndCompanies = new Dictionary<int, string>();
            string[] companies = _companyAndEmployeesDictionary.Keys.ToArray();

            for (int i = 0; i < companies.Length; i++)
            {
                keysAndCompanies.Add(i + 1, companies[i]);
            }
            return keysAndCompanies;
        }

        private void ShowMenu(Dictionary<int, string> menu)
        {
            foreach (var item in menu)
            {
                Console.WriteLine($"[{item.Key}] {item.Value}");
            }
        }

        private int StepValidation()
        {
            int step;
            while (!int.TryParse(Console.ReadLine(), out step)) Console.WriteLine("Error! Please enter an integer");
            return step;
        }
    }
}
