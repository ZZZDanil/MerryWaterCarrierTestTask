using Microsoft.EntityFrameworkCore;
using ВеселыйВодовоз.Models;
using ВеселыйВодовоз.Views;

namespace ВеселыйВодовоз.ViewModels
{
    public static class EmployeeListViewModel
    {

        public static void Init(EmployeeList page, EmployeeListModel employeeListModel)
        {
            employeeListModel.db.Database.EnsureCreated();
            employeeListModel.db.Employees.Load();
            page.DataContext = employeeListModel.db.Employees.Local.ToObservableCollection();
        }

        public static void Add(EmployeeList page, EmployeeListModel employeeListModel)
        {
            EmployeeWindow EmployeeWindow = new EmployeeWindow(new Employee());
            if (EmployeeWindow.ShowDialog() == true)
            {
                Employee Employee = EmployeeWindow.Employee;
                employeeListModel.db.Employees.Add(Employee);
                employeeListModel.db.SaveChanges();
            }
        }
        public static void Edit(EmployeeList page, EmployeeListModel employeeListModel)
        {
            Employee employee = page.employeeList.SelectedItem as Employee;
            if (employee is null) return;

            EmployeeWindow EmployeeWindow = new EmployeeWindow(new Employee
            {
                Id = employee.Id,
                Name = employee.Name,
                Birthday = employee.Birthday,
                Department = employee.Department,
                Lastname = employee.Lastname,
                Middlename = employee.Middlename,
                Sex = employee.Sex
            });

            if (EmployeeWindow.ShowDialog() == true)
            {
                employee = employeeListModel.db.Employees.Find(EmployeeWindow.Employee.Id);
                if (employee != null)
                {
                    employee.Name = EmployeeWindow.Employee.Name;
                    employee.Birthday = EmployeeWindow.Employee.Birthday;
                    employee.Department = EmployeeWindow.Employee.Department;
                    employee.Lastname = EmployeeWindow.Employee.Lastname;
                    employee.Middlename = EmployeeWindow.Employee.Middlename;
                    employee.Sex = EmployeeWindow.Employee.Sex;
                    employeeListModel.db.SaveChanges();
                    page.employeeList.Items.Refresh();
                }
            }
        }
        public static void Delete(EmployeeList page, EmployeeListModel employeeListModel)
        {
            Employee employee = page.employeeList.SelectedItem as Employee;
            if (employee is null) return;
            employeeListModel.db.Employees.Remove(employee);
            employeeListModel.db.SaveChanges();
        }
    }
}
