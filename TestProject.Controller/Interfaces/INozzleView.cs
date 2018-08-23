using System.Collections.Generic;
using TestProject.Model;

namespace TestProject.Controller.Interfaces
{
    public interface INozzleView : IRegistryView
    {
        string NozzleName { get; set; }
        float SellingPrice { get; set; }
        Tank Tank { get; set; }

        void SetTankOptions(IEnumerable<Tank> tanks);
        void SetController(NozzleController controller);
    }
}
