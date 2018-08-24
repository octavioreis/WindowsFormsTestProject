using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Model;

namespace TestProject.ReportGenerator.ReportItems
{
    public class TankReportItem
    {
        public string Name { get; }
        public string StorageCapacity { get; }
        public string FuelName { get; }

        public TankReportItem(Tank tank)
        {
            //Name = tank.Name;
        }
    }
}
