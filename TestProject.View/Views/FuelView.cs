using System;
using System.Linq;
using System.Windows.Forms;
using TestProject.Controller;
using TestProject.Controller.Interfaces;
using TestProject.Controller.ComboBoxOptions;
using TestProject.Model.Enums;

namespace TestProject.View.Views
{
    public partial class FuelView : UserControl, IFuelView
    {
        private FuelTypeOption[] _fuelTypes = new FuelTypeOption[]
        {
            new FuelTypeOption(FuelType.CommonGasoline, "Gasolina Comum"),
            new FuelTypeOption(FuelType.AdditivatedGasoline, "Gasolina Aditivada"),
            new FuelTypeOption(FuelType.Etanol, "Etanol"),
            new FuelTypeOption(FuelType.Diesel, "Diesel")
        };

        private FuelController _controller;

        public string FuelName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public FuelType FuelType
        {
            get { return (cbType.SelectedItem as FuelTypeOption)?.Type ?? FuelType.CommonGasoline; }
            set { cbType.SelectedItem = _fuelTypes.FirstOrDefault(f => f.Type == value); }
        }

        public FuelView()
        {
            InitializeComponent();

            cbType.Items.AddRange(_fuelTypes);
        }

        public void SetController(FuelController controller)
        {
            _controller = controller;
        }

        public void SetViewVisibility(bool visible)
        {
            Visible = visible;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _controller.UpdateModel();
        }
    }
}
