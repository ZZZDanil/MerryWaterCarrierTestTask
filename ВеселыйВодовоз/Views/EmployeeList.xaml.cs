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
using ВеселыйВодовоз.Models;
using ВеселыйВодовоз.ViewModels;

namespace ВеселыйВодовоз.Views
{
    /// <summary>
    /// Логика взаимодействия для EmployeeList.xaml
    /// </summary>
    public partial class EmployeeList : Page
    {
        EmployeeListModel EmployeeListModel;
        public EmployeeList()
        {
            InitializeComponent();
            EmployeeListModel = new EmployeeListModel();
            EmployeeListViewModel.Init(this, EmployeeListModel);
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            EmployeeListViewModel.Add(this, EmployeeListModel);
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            EmployeeListViewModel.Edit(this, EmployeeListModel);
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            EmployeeListViewModel.Delete(this, EmployeeListModel);
        }

    }
}
