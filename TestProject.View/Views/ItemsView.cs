using System;
using System.Linq;
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

        #region IItemsView Members

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

        public IRegistryHostView GetRegistryHostView()
        {
            return registryHostView;
        }

        public void RemoveItem(IdentifiedRegistry item)
        {
            lbItems.Items.Remove(item);
        }

        public void SelectItem(Guid id)
        {
            SelectItem(lbItems.Items.OfType<IdentifiedRegistry>().FirstOrDefault(r => r.Id == id));
        }

        public void SelectItem(IdentifiedRegistry item)
        {
            lbItems.SelectedItem = item;
        }

        public void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void UpdateSelectedItem()
        {
            lbItems.Items[lbItems.SelectedIndex] = lbItems.Items[lbItems.SelectedIndex];
        }

        #endregion

        #region Methods

        private IdentifiedRegistry GetSelectedRegistry()
        {
            return lbItems.SelectedItem as IdentifiedRegistry;
        }

        #endregion

        #region Control Events

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.UpdateRegistryViewItem(GetSelectedRegistry());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _controller.AddItem();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var selectedRegistry = GetSelectedRegistry();
            if (selectedRegistry == null)
                return;

            var message = $"Deseja remover o item \"{selectedRegistry.Name}\"?";
            var title = "Atenção";

            if (MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                _controller.RemoveItem(selectedRegistry);
        }

        #endregion
    }
}
