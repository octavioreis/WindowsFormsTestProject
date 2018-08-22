using System.Windows.Forms;
using TestProject.Controller;
using TestProject.Controller.Enums;
using TestProject.Controller.Interfaces;

namespace TestProject.View
{
    public partial class MainView : Form, IMainView
    {
        private MainController _controller;

        public MainView()
        {
            InitializeComponent();
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

        public void SetController(MainController controller)
        {
            _controller = controller;
        }

        private void selectedTab_Changed(object sender, System.EventArgs e)
        {
            _controller.LoadSelectedTab();
        }
    }
}
