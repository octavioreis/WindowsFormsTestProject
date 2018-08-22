using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Model;

namespace TestProject.Controller.Interfaces
{
    public interface IItemsView
    {
        void AddFuel(Fuel fuel);
        void AddTank(Tank tank);
        void AddNozzle(Nozzle nozzle);

        void ClearList();
    }
}
