using Microsoft.EntityFrameworkCore;
using System.Windows.Controls;
using ВеселыйВодовоз.Models;
using ВеселыйВодовоз.Views;

namespace ВеселыйВодовоз.ViewModels
{
    public static class OrderListViewModel
    {

        public static void Init(OrderList page, OrderListModel orderListModel)
        {
            orderListModel.db.Database.EnsureCreated();
            orderListModel.db.Orders.Load();
            page.DataContext = orderListModel.db.Orders.Local.ToObservableCollection();
        }

        public static void Add(OrderList page, OrderListModel orderListModel)
        {
            OrderWindow OrderWindow = new OrderWindow(new Order());
            if (OrderWindow.ShowDialog() == true)
            {
                Order Order = OrderWindow.Order;
                orderListModel.db.Orders.Add(Order);
                orderListModel.db.SaveChanges();
            }
        }
        public static void Edit(OrderList page, OrderListModel orderListModel)
        {
            Order order = page.orderList.SelectedItem as Order;
            if (order is null) return;

            OrderWindow OrderWindow = new OrderWindow(new Order
            {
                Id = order.Id,
                Name = order.Name,
                Employee = order.Employee,
                Number = order.Number
            });

            if (OrderWindow.ShowDialog() == true)
            {
                order = orderListModel.db.Orders.Find(OrderWindow.Order.Id);
                if (order != null)
                {
                    order.Name = OrderWindow.Order.Name;
                    order.Employee = OrderWindow.Order.Employee;
                    order.Number = OrderWindow.Order.Number;
                    orderListModel.db.SaveChanges();
                    page.orderList.Items.Refresh();
                }
            }
        }
        public static void Delete(OrderList page, OrderListModel orderListModel)
        {
            Order order = page.orderList.SelectedItem as Order;
            if (order is null) return;
            orderListModel.db.Orders.Remove(order);
            orderListModel.db.SaveChanges();
        }
    }
}
