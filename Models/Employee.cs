using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ВеселыйВодовоз.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public DateTime Birthday { get; set; }
        public int Sex { get; set; }
        public int Department { get; set; }

    }
}
