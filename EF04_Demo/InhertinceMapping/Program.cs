using Azure;
using EF02_Demo.Contexts;
using InhertinceMapping.Models;
using System.Net;

using EmployeeDbContext context = new EmployeeDbContext();

FulltimeEmployee fulltimeEmployee = new FulltimeEmployee()
{
    Name = "John Doe",
    Salary = 60000,
    StartDate = DateTime.Now,
    Address = "123 Main St",
    Age = 30
};

ParttimeEmployee parttimeEmployee = new ParttimeEmployee()
{
    Name = "Jane Smith",
    HourlyRate = 20,
    HoursWorked = 120,
    Address = "456 Elm St",
    Age = 25
};

//context.Employees.Add(fulltimeEmployee);
//context.Employees.Add(parttimeEmployee);
////context.FulltimeEmployees.Add(fulltimeEmployee);
////context.ParttimeEmployees.Add(parttimeEmployee);
//context.SaveChanges();



#region TPCT
//var ftEmployees = context.FulltimeEmployees.FirstOrDefault();
//var ptEmployees = context.ParttimeEmployees.FirstOrDefault();

//if (ftEmployees != null)
//{
//    Console.WriteLine($"Fulltime Employee: {ftEmployees.Name}, Salary: {ftEmployees.Salary}, Start Date: {ftEmployees.StartDate}, Address: {ftEmployees.Address}, Age: {ftEmployees.Age}");
//}
//if (ptEmployees != null)
//{
//    Console.WriteLine($"Parttime Employee: {ptEmployees.Name}, Hourly Rate: {ptEmployees.HourlyRate}, Hours Worked: {ptEmployees.HoursWorked}, Address: {ptEmployees.Address}, Age: {ptEmployees.Age}");
//} 
#endregion

#region TPH
//var employees = from e in context.Employees.OfType<ParttimeEmployee>()
//                select e;
//foreach (var emp in employees)
//{
//    Console.WriteLine($"Parttime Employee: {emp.Name}, Hourly Rate: {emp.HourlyRate}, Hours Worked: {emp.HoursWorked}, Address: {emp.Address}, Age: {emp.Age}");
//}

#endregion

#region TPT
//var employees = from employee in context. FulltimeEmployees
//                select employee;

//foreach (var emp in employees)
//    Console.WriteLine($"{emp.Id} , {emp.Name}");
#endregion
