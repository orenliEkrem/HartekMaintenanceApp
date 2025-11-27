using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineMaintenanceApp
{
    internal class Machine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime LastMaintenanceDate { get; set; }
        public string Notes { get; set; }
    }
}
