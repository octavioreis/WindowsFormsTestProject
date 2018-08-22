using System.Windows.Forms;
using TestProject.Controller.Interfaces;
using TestProject.Model;

namespace TestProject.View.Views
{
    public partial class ItemsView : UserControl, IItemsView
    {
        public ItemsView()
        {
            InitializeComponent();
        }

        public void AddFuel(Fuel fuel)
        {
            lbItems.Items.Add(fuel);
        }

        public void AddNozzle(Nozzle nozzle)
        {
            lbItems.Items.Add(nozzle);
        }

        public void AddTank(Tank tank)
        {
            lbItems.Items.Add(tank);
        }

        public void ClearList()
        {
            lbItems.Items.Clear();
        }
    }
}
