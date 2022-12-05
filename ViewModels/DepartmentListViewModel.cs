using Microsoft.EntityFrameworkCore;
using ВеселыйВодовоз.Models;
using ВеселыйВодовоз.Views;

namespace ВеселыйВодовоз.ViewModels
{
    public static class DepartmentListViewModel
    {
        public static void Init(DepartmentList page, DepartmentListModel departmentListModel)
        {
            departmentListModel.db.Database.EnsureCreated();
            departmentListModel.db.Departments.Load();
            page.DataContext = departmentListModel.db.Departments.Local.ToObservableCollection();
        }

        public static void Add(DepartmentList page, DepartmentListModel departmentListModel)
        {
            DepartmentWindow DepartmentWindow = new DepartmentWindow(new Department());
            if (DepartmentWindow.ShowDialog() == true)
            {
                Department Department = DepartmentWindow.Department;
                departmentListModel.db.Departments.Add(Department);
                departmentListModel.db.SaveChanges();
            }
        }
        public static void Edit(DepartmentList page, DepartmentListModel departmentListModel)
        {
            Department department = page.departmentsList.SelectedItem as Department;
            if (department is null) return;

            DepartmentWindow DepartmentWindow = new DepartmentWindow(new Department
            {
                Id = department.Id,
                Name = department.Name,
                Director = department.Director
            });

            if (DepartmentWindow.ShowDialog() == true)
            {
                department = departmentListModel.db.Departments.Find(DepartmentWindow.Department.Id);
                if (department != null)
                {
                    department.Director = DepartmentWindow.Department.Director;
                    department.Name = DepartmentWindow.Department.Name;
                    departmentListModel.db.SaveChanges();
                    page.departmentsList.Items.Refresh();
                }
            }
        }
        public static void Delete(DepartmentList page, DepartmentListModel departmentListModel)
        {
            Department department = page.departmentsList.SelectedItem as Department;
            if (department is null) return;
            departmentListModel.db.Departments.Remove(department);
            departmentListModel.db.SaveChanges();
        }
    }
}
