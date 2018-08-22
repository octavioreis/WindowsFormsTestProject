using System.Windows.Forms;
using TestProject.Controller;
using TestProject.Controller.Interfaces;
using TestProject.Model.Enums;

namespace TestProject.View
{
    public partial class MainView : Form, IMainView
    {
        private MainController _controller;

        public MainView()
        {
            InitializeComponent();
        }

        public void SetController(MainController controller)
        {
            _controller = controller;
        }

        public IItemsView GetItemsView()
        {
            return itemsView;
        }

        public RegistryType GetSelectedTab()
        {
            if (rbFuels.Checked)
                return RegistryType.Fuel;
            else if (rbTanks.Checked)
                return RegistryType.Tank;
            else
                return RegistryType.Nozzle;
        }

        private void selectedTab_Changed(object sender, System.EventArgs e)
        {
            var radioButton = (RadioButton)sender;
            if (radioButton.Checked)
                _controller.LoadSelectedTab();
        }
    }
}
