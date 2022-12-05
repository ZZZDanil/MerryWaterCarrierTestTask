using Microsoft.EntityFrameworkCore;
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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ВеселыйВодовоз.Models;
using ВеселыйВодовоз.ViewModels;

namespace ВеселыйВодовоз.Views
{
    /// <summary>
    /// Логика взаимодействия для DepartmentList.xaml
    /// </summary>
    public partial class DepartmentList : Page
    {
        DepartmentListModel DepartmentListModel;
        public DepartmentList()
        {
            InitializeComponent();
            DepartmentListModel = new DepartmentListModel();
            DepartmentListViewModel.Init(this, DepartmentListModel);
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            DepartmentListViewModel.Add(this, DepartmentListModel);
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            DepartmentListViewModel.Edit(this, DepartmentListModel);
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            DepartmentListViewModel.Delete(this, DepartmentListModel);
        }
    }
}
