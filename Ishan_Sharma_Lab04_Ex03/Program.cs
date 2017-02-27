using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishan_Sharma_Lab04_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {

                var employees = new[]
                {
                new Employee("Ishan", 100000),
                new Employee("Jatin", 35000),
                new Employee("Brown", 45000),
                new Employee("Smith", 55000),
                new Employee("Tommy", 65000)
                };

                var employeeDict = new SortedDictionary<int, Employee>();
                
            //Add Employees to SortedDictionary
                AddDictionaryItem(employees, employeeDict);
                
            //Print the Employee SortedDictionary
                PrintDictionary(employees, employeeDict);
                
            //Remove a item from Employee SortedDictionary
                RemoveDictionaryItem(employees, employeeDict);
                PrintDictionary(employees, employeeDict);
                
            //Search an employee in SortedDictionary
                SearchDictionaryItem(employees, employeeDict);
                
            //Find the employee with higest Salary
                MaxDictionaryItem(employees, employeeDict);
            }


        private static void AddDictionaryItem(Employee[] employees, SortedDictionary<int, Employee> employeeDict)
        {
            Console.WriteLine("\nAdd Employees to Employee Dictionary");
            for (int i = 0; i < employees.Length; ++i)
            {
                employeeDict.Add(i + 1, employees[i]);
            }
        }

        private static void PrintDictionary(Employee[] employees, SortedDictionary<int, Employee> employeeDict)
        {
            foreach (var key in employeeDict.Keys)
            {
                Console.WriteLine($" Key:{key} , Value:{employeeDict[key]}");
                //Console.WriteLine($" Key:{key} , Value:{employeeDict[key].Name}");
                //Console.WriteLine($" Key:{key} , Value:{employeeDict[key].Price}");
            }
        }

        private static void RemoveDictionaryItem(Employee[] employees, SortedDictionary<int, Employee> employeeDict)
        {
            Console.WriteLine("\nRemoved Third Employee from the list");
            employeeDict.Remove(3);
        }

        private static void SearchDictionaryItem(Employee[] employees, SortedDictionary<int, Employee> employeeDict)
        {
            Console.WriteLine("\nEnter the employee key you want to search");
            int key = Convert.ToInt32(Console.ReadLine());
            if (employeeDict.ContainsKey(key))
                Console.WriteLine("Value : {0}", employeeDict[key]);
            else
                Console.WriteLine("Employee not present");
        }

        private static void MaxDictionaryItem(Employee[] employees, SortedDictionary<int, Employee> employeeDict)
        {
            Console.WriteLine("\nThe Employee with Highest Salary: ");
            Employee max = employees[0];
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Salary > max.Salary)
                {
                    max = employees[i];
                }
            }
            Console.WriteLine($"Name: {max.Name}, Salary: {max.Salary}");
        }
    }
    
}
