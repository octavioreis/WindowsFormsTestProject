using System.Windows.Forms;
using TestProject.Controller;
using TestProject.Controller.Interfaces;
using TestProject.Model;

namespace TestProject.View.Views
{
    public partial class ItemsView : UserControl, IItemsView
    {
        private ItemsController _controller;

        public ItemsView()
        {
            InitializeComponent();
        }

        public void SetController(ItemsController controller)
        {
            _controller = controller;
        }

        public void AddItem(IdentifiedRegistry item)
        {
            lbItems.Items.Add(item);
        }

        public void ClearList()
        {
            lbItems.Items.Clear();
        }

        public IFuelView GetFuelView()
        {
            return fuelView1;
        }

        public ITankView GetTankView()
        {
            return tankView1;
        }

        public INozzleView GetNozzleView()
        {
            return nozzleView1;
        }

        public void SelectItem(IdentifiedRegistry item)
        {
            lbItems.SelectedItem = item;
        }

        private void lbItems_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            _controller.SelectedItemChanged(lbItems.SelectedItem as IdentifiedRegistry);
        }
    }
}
