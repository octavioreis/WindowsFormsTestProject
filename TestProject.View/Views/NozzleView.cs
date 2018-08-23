using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestProject.Controller;
using TestProject.Controller.ComboBoxOptions;
using TestProject.Controller.Interfaces;
using TestProject.Model;

namespace TestProject.View.Views
{
    public partial class NozzleView : UserControl, INozzleView
    {
        private readonly NoneOption _comboBoxNoneOption = new NoneOption();
        private NozzleController _controller;

        public string NozzleName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string SellingPrice
        {
            get { return txtPrice.Text; }
            set { txtPrice.Text = value; }
        }

        public Tank Tank
        {
            get { return cbTank.SelectedItem as Tank; }
            set
            {
                if (value != null && cbTank.Items.Contains(value))
                    cbTank.SelectedItem = value;
                else
                    cbTank.SelectedItem = _comboBoxNoneOption;
            }
        }

        public NozzleView()
        {
            InitializeComponent();
        }

        public void SetController(NozzleController controller)
        {
            _controller = controller;
        }

        public void SetTankOptions(IEnumerable<Tank> tanks)
        {
            cbTank.Items.Clear();
            cbTank.Items.Add(_comboBoxNoneOption);
            cbTank.Items.AddRange(tanks.ToArray());
        }

        public void SetViewVisibility(bool visible)
        {
            Visible = visible;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            _controller.UpdateModel();
        }

        private void btnGoToTank_Click(object sender, System.EventArgs e)
        {

        }
    }
}
