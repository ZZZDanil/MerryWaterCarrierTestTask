using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ВеселыйВодовоз.Views;

namespace ВеселыйВодовоз
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DepartmentList departmentList;
        private EmployeeList employeeList;
        private OrderList orderList;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void GoToDepartment(object sender, RoutedEventArgs e)
        {
            if (departmentList == null)
            {
                departmentList = new DepartmentList();
            }
            ListViewPage.Content = departmentList;
        }
        private void GoToEmployee(object sender, RoutedEventArgs e)
        {
            if (employeeList == null)
            {
                employeeList = new EmployeeList();
            }
            ListViewPage.Content = employeeList;
        }
        private void GoToOrder(object sender, RoutedEventArgs e)
        {
            if (orderList == null)
            {
                orderList = new OrderList();
            }
            ListViewPage.Content = orderList;
        }
    }
}
