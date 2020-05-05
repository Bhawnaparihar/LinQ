using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LinqAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> basic =Employee.GetEmployees().ToList();
            foreach(Employee emp in basic)
            {
                Console.WriteLine($"ID : {emp.Employee_Id} Name : {emp.First_Name} {emp.Last_Name} Salary : {emp.Salary} Joining Date : {emp.Joining_Date} Department : {emp.Department}");

            }
            List<Employee> select = Employee.GetEmployees().Select(emp => new Employee() { First_Name = emp.First_Name, Last_Name = emp.Last_Name }).ToList();
            foreach(Employee emp in select)
            {
                Console.WriteLine($" Name : {emp.First_Name} {emp.Last_Name}  ");
            }
            List<Employee> alias = Employee.GetEmployees().Select(emp => new Employee() { First_Name = emp.First_Name }).ToList();
            foreach (var emp in alias)
            {
                Console.WriteLine($" Employee Name : {emp.First_Name}  ");
            }
            string[] Upper=Employee.GetEmployees().Select(emp => emp.First_Name.ToUpper()).ToArray();
            foreach (var emp in Upper)
            {
                Console.WriteLine($" Employee Name : {emp}  ");
            }
            string[] Lower = Employee.GetEmployees().Select(emp => emp.First_Name.ToLower()).ToArray();
            foreach (var emp in Lower)
            {
                Console.WriteLine($" Employee Name : {emp}  ");
            }
            var unique = Employee.GetEmployees().Select(emp => emp.Department).Distinct().ToList();
            foreach (var dept in unique)
            {
                Console.WriteLine($" Department : {dept}  ");
            }
           
            string n = "John";
            char[] textarray = n.ToCharArray();

            for (int i = 1; i < n.Length; i++)
            {
                if (textarray[i].Equals('o'))
                {
                    Console.WriteLine("The letter is present in " + (i + 1) + "th position");
                    break;
                }

            }
            var trim = Employee.GetEmployees().Select(e => e.First_Name.TrimEnd()).ToList();
            foreach (var emp in trim)
            {
                Console.WriteLine($" Employee Name : {emp}  ");
            }
            var triml = Employee.GetEmployees().Select(emp => emp.First_Name.TrimStart()).ToList();
            foreach (var emp in triml)
            {
                Console.WriteLine($" Employee Name : {emp}  ");
            }
            var length = Employee.GetEmployees().Select(emp => emp.First_Name.Length).ToList();
            foreach (var emp in length)
            {
                Console.WriteLine($" Employee Name : {emp}  ");
            }
            var relplace = Employee.GetEmployees().Select(emp => emp.First_Name.Replace("o", "$")).ToList();
            foreach (var emp in relplace)
            {
                Console.WriteLine($" Employee Name : {emp}  ");
            }
            List<Employee> name = Employee.GetEmployees().Select(emp => new Employee() { First_Name = emp.First_Name, Last_Name = emp.Last_Name }).ToList();
            foreach (var emp in name)
            {
                Console.WriteLine($" Name : {emp.First_Name}_{emp.Last_Name}  ");
            }
            var join = Employee.GetEmployees().Select(e => new { First_Name = e.First_Name, Joining_Year = e.Joining_Date.Year, Joining_Month = e.Joining_Date.Month, Joining_Date = e.Joining_Date.Day });
            foreach (var emp in join)
            {
                Console.WriteLine($" Name : {emp.First_Name}  Joining Year : {emp.Joining_Year}  Joining Month : {emp.Joining_Month} Joining Day : {emp.Joining_Date}");
            }
            var asc = Employee.GetEmployees().OrderBy(emp => emp.First_Name).ToList();
            foreach (var emp in asc)
            {
                Console.WriteLine($"Name : {emp.First_Name}");
            }
            var de = Employee.GetEmployees().OrderByDescending(emp => emp.First_Name).ToList();
            foreach (var emp in de)
            {
                Console.WriteLine($"Name : {emp.First_Name}");
            }
            var all = Employee.GetEmployees().OrderBy(emp => emp.First_Name).ThenByDescending(s => s.Salary).ToList();
            foreach (var emp in all)
            {
                Console.WriteLine($"Name : {emp.First_Name}  Salary : {emp.Salary}");
            }
            var ename = Employee.GetEmployees().Select(e => e.First_Name = "John");
            foreach (var e in ename)
            {
                Console.WriteLine($"Name : {e}");
            }
            var ename2 = Employee.GetEmployees().Select(e => e.First_Name == "John" || e.First_Name == "Roy");
            foreach (var e in ename2)
            {
                Console.WriteLine($"Name : {e}");
            }
            var ename3 = Employee.GetEmployees().Select(e => e.First_Name != "John" || e.First_Name != "Roy");
            foreach (var e in ename3)
            {
                Console.WriteLine($"Name : {e}");
            }
            var ename4 = Employee.GetEmployees().Select(e => e.First_Name.StartsWith("J"));
            foreach (var e in ename4)
            {
                Console.WriteLine($"Name : {e}");
            }
            var ename5 = Employee.GetEmployees().Select(e => e.First_Name.Contains("o"));
            foreach (var e in ename5)
            {
                Console.WriteLine($"Name : {e}");
            }
            var ename6 = Employee.GetEmployees().Select(e => e.First_Name.EndsWith("n"));
            foreach (var e in ename6)
            {
                Console.WriteLine($"Name : {e}");
            }
            var q = Employee.GetEmployees().Where(e => e.Salary > 600000).ToList();
            foreach (var emp in q)
            {
                Console.WriteLine($"ID : {emp.Employee_Id} Name : {emp.First_Name} {emp.Last_Name} Salary : {emp.Salary} Joining Date : {emp.Joining_Date} Department : {emp.Department}");
            }
            var s = Employee.GetEmployees().Where(e => e.Salary < 800000).ToList();
            foreach (var emp in s)
            {
                Console.WriteLine($"ID : {emp.Employee_Id} Name : {emp.First_Name} {emp.Last_Name} Salary : {emp.Salary} Joining Date : {emp.Joining_Date} Department : {emp.Department}");
            }
            var sa = Employee.GetEmployees().Where(e => e.Salary >= 500000 && e.Salary <= 800000);
            foreach (var emp in q)
            {
                Console.WriteLine($"ID : {emp.Employee_Id} Name : {emp.First_Name} {emp.Last_Name} Salary : {emp.Salary} Joining Date : {emp.Joining_Date} Department : {emp.Department}");
            }
            Console.ReadKey();
        }
    }
}
