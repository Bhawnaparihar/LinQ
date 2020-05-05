using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    class Employee
    {
        public int Employee_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public double Salary { get; set; }
        public System.DateTime Joining_Date { get; set; }
        public string Department { get; set; }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
            new Employee() {Employee_Id=1,First_Name="John",Last_Name="Abraham",Salary=1000000,Joining_Date= new DateTime(2013/01/1),Department="Banking"},
            new Employee() {Employee_Id=2,First_Name="Michael",Last_Name="Clarke",Salary=800000,Joining_Date= new DateTime(2013/01/1),Department="Insurance"},
            new Employee() {Employee_Id=3,First_Name="Roy",Last_Name="Thomas",Salary=700000,Joining_Date= new DateTime(2013/02/1),Department="Banking"},
            new Employee() {Employee_Id=4,First_Name="Tom",Last_Name="Jose",Salary=600000,Joining_Date= new DateTime(2013/02/1),Department="Insurance"},
            new Employee() {Employee_Id=5,First_Name="Jerry",Last_Name="Pinto",Salary=650000,Joining_Date= new DateTime(2013/02/1),Department="Insurance"},
            new Employee() {Employee_Id=6,First_Name="Philip",Last_Name="Mathew",Salary=750000,Joining_Date= new DateTime(2013/01/1),Department="Services"},
            new Employee() {Employee_Id=7,First_Name="TestName1",Last_Name="123",Salary=650000,Joining_Date= new DateTime(2013/01/1),Department="Services"},
            new Employee() {Employee_Id=8,First_Name="TestName2",Last_Name="Lname%",Salary=600000,Joining_Date= new DateTime(2013/02/1),Department="Insurance"}
            };
            return employees;
        }

    }
}
