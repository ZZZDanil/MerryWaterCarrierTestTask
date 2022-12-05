using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ВеселыйВодовоз.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public int Employee { get; set; }
    }
}
