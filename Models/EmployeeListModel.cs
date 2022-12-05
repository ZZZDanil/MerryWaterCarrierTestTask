using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ВеселыйВодовоз.Models
{
    public class EmployeeListModel
    {
        public ApplicationContext db = new ApplicationContext();
        public Employee Employee { get; private set; }
    }
}
