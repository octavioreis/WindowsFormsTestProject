using System;
using System.Linq;
using System.Windows.Forms;
using TestProject.Controller;
using TestProject.Controller.Interfaces;
using TestProject.Controller.ModelWrappers;
using TestProject.Model.Enums;

namespace TestProject.View.Views
{
    public partial class FuelView : UserControl, IFuelView
    {
        private FuelTypeObject[] _fuelTypes = new FuelTypeObject[]
        {
            new FuelTypeObject(FuelType.CommonGasoline, "Gasolina Comum"),
            new FuelTypeObject(FuelType.AdditivatedGasoline, "Gasolina Aditivada"),
            new FuelTypeObject(FuelType.Etanol, "Etanol"),
            new FuelTypeObject(FuelType.Diesel, "Diesel")
        };

        private FuelController _fuelController;

        public string FuelName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public FuelType FuelType
        {
            get { return (cbType.SelectedItem as FuelTypeObject).Type; }
            set { cbType.SelectedItem = _fuelTypes.FirstOrDefault(f => f.Type == value); }
        }

        public FuelView()
        {
            InitializeComponent();

            cbType.Items.AddRange(_fuelTypes);
        }

        public void SetController(FuelController controller)
        {
            _fuelController = controller;
        }

        public void SetViewVisibility(bool visible)
        {
            Visible = visible;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _fuelController.UpdateModel();
        }
    }
}
