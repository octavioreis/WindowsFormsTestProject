using System.Collections.Generic;
using TestProject.Model;

namespace TestProject.Controller.Interfaces
{
    public interface INozzleView : IRegistryView
    {
        string NozzleName { get; set; }
        string SellingPrice { get; set; }
        Tank Tank { get; set; }

        void SetTankOptions(IEnumerable<Tank> tanks);
        void SetController(NozzleController controller);
    }
}
