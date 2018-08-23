using System;
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

        #region IItemsView Implementation

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

        public void RemoveItem(IdentifiedRegistry item)
        {
            lbItems.Items.Remove(item);
        }

        public void SelectItem(IdentifiedRegistry item)
        {
            lbItems.SelectedItem = item;
        }

        public void SelectItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        #endregion

        #region Control Events

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.SelectedItemChanged(lbItems.SelectedItem as IdentifiedRegistry);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _controller.AddItem();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _controller.RemoveItem(lbItems.SelectedItem as IdentifiedRegistry);
        }

        #endregion
    }
}
