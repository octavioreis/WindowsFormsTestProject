using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestProject.Controller;
using TestProject.Controller.Interfaces;
using TestProject.Model;

namespace TestProject.View.Views
{
    public partial class TankView : UserControl, ITankView
    {
        private TankController _controller;

        public string TankName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string StorageCapacity
        {
            get { return txtCapacity.Text; }
            set { txtCapacity.Text = value; }
        }

        public Fuel Fuel
        {
            get { return cbFuel.SelectedItem as Fuel; }
            set { cbFuel.SelectedItem = value; }
        }

        public TankView()
        {
            InitializeComponent();
        }

        public void SetController(TankController controller)
        {
            _controller = controller;
        }

        public void SetFuelOptions(IEnumerable<Fuel> fuels)
        {
            cbFuel.Items.Clear();
            cbFuel.Items.AddRange(fuels.ToArray());
        }

        public void SetViewVisibility(bool visible)
        {
            Visible = visible;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _controller.UpdateModel();
        }

        private void btnGoToFuel_Click(object sender, EventArgs e)
        {

        }
    }
}
