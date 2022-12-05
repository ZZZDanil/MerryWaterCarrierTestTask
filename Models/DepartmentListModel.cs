using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ВеселыйВодовоз.Models
{
    public class DepartmentListModel
    {
        public ApplicationContext db = new ApplicationContext();
        public Department Department { get; private set; }
    }
}
