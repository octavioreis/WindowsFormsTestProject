using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Model;

namespace TestProject.ReportGenerator.ReportItems
{
    public class NozzleReportItem
    {
        public string Name { get; }
        public string SellingPrice { get; }
        public string TankName { get; }

        public NozzleReportItem(Nozzle nozzle)
        {
            //Name = nozzle.Name;
            //SellingPrice = nozzle.SellingPrice.ToString();
            //Tank = nozzle
        }
    }
}
