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
    /// Логика взаимодействия для OrderList.xaml
    /// </summary>
    public partial class OrderList : Page
    {
        OrderListModel OrderListModel;
        public OrderList()
        {
            InitializeComponent();
            OrderListModel = new OrderListModel();
            OrderListViewModel.Init(this, OrderListModel);
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            OrderListViewModel.Add(this, OrderListModel);
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            OrderListViewModel.Edit(this, OrderListModel);
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            OrderListViewModel.Delete(this, OrderListModel);
        }

    }
}
