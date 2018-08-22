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

        public void AddItem(IdentifiedRegistry item)
        {
            lbItems.Items.Add(item);
        }

        public void ClearList()
        {
            lbItems.Items.Clear();
        }

        public void SelectItem(IdentifiedRegistry item)
        {
            lbItems.SelectedItem = item;
        }
    }
}
