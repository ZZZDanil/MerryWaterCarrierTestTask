using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ВеселыйВодовоз.Models
{
    public class OrderListModel
    {
        public ApplicationContext db = new ApplicationContext();
        public Order Order { get; private set; }
    }
}
