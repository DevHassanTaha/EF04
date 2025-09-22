using EF02_Demo.Contexts;
using EF02_Demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EF02_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext context = new CompanyDbContext();
            #region Add
            //Employee employee = new Employee
            //{
            //    Name = "Ahmed",
            //    Age = 30,
            //    Address = "Cairo",
            //    Email = "jdhfsjdgfhs@gmail.com",
            //    Test = 100,
            //};
            ////context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            //Console.WriteLine(context.Entry(employee).State);


            //context.Add(employee);
            ////context.Add<Employee>(employee);
            ////context.Employees.Add(employee);
            ////context.Set<Employee>().Add(employee);
            //Console.WriteLine(context.Entry(employee).State);
            //Console.WriteLine($"Employee Id is {employee.Id} Before saving");


            //context.SaveChanges();

            //Console.WriteLine(context.Entry(employee).State);
            //Console.WriteLine($"Employee Id is {employee.Id} after saving");

            #endregion

            #region Retrive
            //var employee = context. Employees. Where(employee => employee. Id == 1).FirstOrDefault();
            //var employee = context. Employees. FirstOrDefault(employee => employee. Id == 1);
            //context. ChangeTracker. QueryTrackingBehavior = QueryTrackingBehavior. NoTracking;

            //var employee = context.Employees.AsNoTracking().FirstOrDefault(e => e.Id == 1);
            //if (employee is not null)
            //{

            //    Console.WriteLine(context.Entry(employee).State);

            //    Console.WriteLine(employee.Name);

            //}
            #endregion

            #region Update
            //var employee = context.Employees.AsNoTracking().FirstOrDefault();
            //if (employee is not null)
            //{

            //    Console.WriteLine(context.Entry(employee).State);

            //    Console.WriteLine(employee.Name);

            //    employee.Name = "Hastsan";

            //    Console.WriteLine(context.Entry(employee).State);

            //    Console.WriteLine(employee.Name);

            //    context.SaveChanges();

            //    Console.WriteLine(context.Entry(employee).State);

            //}
            #endregion

            #region Delete
            //var employee = context.Employees.AsNoTracking().FirstOrDefault();
            //if (employee is not null)
            //{

            //    Console.WriteLine(context.Entry(employee).State);

            //    context.Remove(employee);
            //    //context.Remove<Employee>(employee);
            //    //context. Employees. Remove(employee);
            //    //context.Set<Employee>().Remove(employee);
            //    //context. Entry<Employee>(employee).State = EntityState.Deleted;

            //    Console.WriteLine(context.Entry(employee).State);

            //    context.SaveChanges();

            //    Console.WriteLine(context.Entry(employee).State);

            //}
            #endregion

            //List<Department> departmentList = new List<Department>()
            //{
            //    new Department {Name = "HR", DateOfCreation = DateTime.Now },
            //    new Department {Name = "PR", DateOfCreation = DateTime.Now },
            //    new Department {Name = "Sales", DateOfCreation = DateTime.Now }
            //};
            //context.Departments.AddRange(departmentList);
            //context.SaveChanges();

            //var employee = context.Employees.FirstOrDefault(x => x.Id == 3);

            //if (employee is not null)
            //{ 

            //    Console.WriteLine($"Id => {employee.Id}, Name => {employee.Name}, DeptName => {employee.Department?.Name}");

            //    var department = context.Departments.FirstOrDefault(x => x.DepId == employee.DepartmentId);

            //    Console.WriteLine($"DeptName => {department?.Name}");
            //}

            //var employee = context.Employees.Include(x => x.Department).ThenInclude(x => x.employees).FirstOrDefault(x => x.Id == 3);
            //if (employee is not null)
            //{
            //    Console.WriteLine($"Id => {employee.Id}, Name => {employee.Name}, DeptName => {employee.Department?.Name}");
            //    //    var department = context.Departments.FirstOrDefault(x => x.DepId == employee.DepartmentId);

            //    //    Console.WriteLine($"DeptName => {department?.Name}");
            //}

            //var employee = context.Employees.FirstOrDefault(x => x.Id == 3);

            //if (employee is not null)
            //{

            //    context.Entry(employee).Reference(x => x.Department).Load();
            //    var department = context.Departments.FirstOrDefault(x => x.DepId == 10);
            //    context.Entry(department).Collection(x => x.employees).Load();

            //    Console.WriteLine($"Id =>{employee.Id}, Name=> {employee.Name}, DeptName => {employee.Department?.Name}");
            //}




            //var employee = context.Employees.FirstOrDefault(x => x.Id == 3);

            //if (employee is not null)
            //{

            //    Console.WriteLine($"Id => {employee.Id}, Name => {employee.Name}");

            //    //var department = context.Departments.FirstOrDefault(x => x.DepId == employee.DepartmentId);
            //    Console.WriteLine($"DeptName => {employee.Department.Name}");
            //    //Console.WriteLine($"DeptName => {department?.Name}");
            //}



            //var query = (from employee in context.Employees.AsNoTracking()
            // join department in context.Departments.AsNoTracking()
            // on employee.DepartmentId equals department.DepId
            // where department.Name == "HR"
            // select new 
            // {

            //     EmployeeName = employee.Name,
            //     DepartmentName = department.Name
            // }). ToList();


            //var Query = context.Employees.Join(context.Departments,
            //    employee => employee.DepartmentId,
            //    department => department.DepId,
            //    (employee,department) => new
            //    {
            //        EmployeeName = employee.Name,
            //        DepartmentName = department.Name
            //    });

            //foreach (var item in query) 
            //{ 
            //    Console.WriteLine($"{item.EmployeeName} => {item.DepartmentName}");
            //} 

            #region Group Join
            //var Query = context.Departments.GroupJoin(context.Employees,
            //    department => department.DepId,
            //    employee => employee.DepartmentId,
            //    (department, employees) => new
            //    {
            //        Employees = employees,
            //        Department = department
            //    }).ToList();

            //var query = (from department in context.Departments
            //             join employee in context.Employees
            //             on department.DepId equals employee.DepartmentId into employees
            //             select new
            //             {
            //                 Employees = employees,
            //                 Department = department
            //             }into groupCount
            //             where groupCount.Employees.Count() >1
            //             select groupCount).ToList();

            //foreach (var item in query)
            //{
            //    Console.WriteLine($"{item.Department.DepId} - {item.Department.Name}");
            //    foreach (var employee in item.Employees)
            //    {
            //        Console.WriteLine($"{employee.Id} - {employee.Name}");
            //    }
            //    Console.WriteLine("=========== ");
            //}
            #endregion

            #region Left join
            //var Query = context.Departments.LeftJoin(context.Employees,
            //    department => department.DepId,
            //    employee => employee.DepartmentId,
            //    (department, employees) => new
            //    {
            //        Employees = employees,
            //        Department = department
            //    }).ToList();

            //var Query = context.Departments.GroupJoin(context.Employees,
            //    department => department.DepId,
            //    employee => employee.DepartmentId,
            //    (department, employees) => new
            //    {
            //        Employees = employees,
            //        Department = department
            //    }).SelectMany(x => x.Employees.DefaultIfEmpty(),(x,employee) => new
            //    {
            //        DeptId = x.Department.DepId,
            //        DeptName = x.Department.Name,
            //        EmployeeName = employee != null ? employee.Name : "No Employee"

            //    } ).ToList();

            //var query = (from department in context.Departments
            //             join employee in context.Employees
            //             on department.DepId equals employee.DepartmentId into employees
            //             select new
            //             {
            //                 Employees = employees.DefaultIfEmpty(),
            //                 Department = department
            //             } into groups
            //             from emp in groups.Employees 
            //             select new
            //             {
            //                 DeptId = groups.Department.DepId,
            //                 DeptName = groups.Department.Name,
            //                 EmployeeName = emp != null ? emp.Name : "No Employee"
            //             }).ToList();

            //foreach (var item in query)
            //{
            //    Console.WriteLine($"{item.DeptId} - {item.DeptName} - {item.EmployeeName}");
            //}
            #endregion

            #region Cross join
            //var Query = from department in context.Departments
            //            from employee in context.Employees
            //            select new
            //            {
            //                DeptName = department.Name,
            //                EmployeeName = employee.Name
            //            };
            //Query = context.Departments.SelectMany(department => context.Employees, (department, employee) => new
            //{
            //    DeptName = department.Name,
            //    EmployeeName = employee.Name
            //});
            //foreach (var item in Query)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

        }
    }
}
