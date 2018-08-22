using System;
using System.Windows.Forms;
using TestProject.Controller;
using TestProject.Controller.Interfaces;
using TestProject.Model.Enums;

namespace TestProject.View.Views
{
    public partial class FuelView : UserControl, IFuelView
    {
        private FuelController _fuelController;

        public string FuelName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public FuelType FuelType
        {
            get
            {
                if (!Enum.TryParse(cbType.SelectedItem.ToString(), out FuelType type))
                    throw new FormatException("Erro ao converter o tipo de gasolina.");

                return type;
            }
            set { cbType.SelectedItem = value; }
        }

        public FuelView()
        {
            InitializeComponent();
        }

        public void SetController(FuelController controller)
        {
            _fuelController = controller;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _fuelController.UpdateModel();
        }
    }
}
