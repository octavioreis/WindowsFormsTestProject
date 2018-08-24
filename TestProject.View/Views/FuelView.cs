using System.Linq;
using System.Windows.Forms;
using TestProject.Controller.ComboBoxOptions;
using TestProject.Controller.Interfaces;
using TestProject.Globalization;
using TestProject.Model.Enums;

namespace TestProject.View.Views
{
    public partial class FuelView : UserControl, IFuelView
    {
        private FuelTypeOption[] _fuelTypes = new FuelTypeOption[]
        {
            new FuelTypeOption(FuelType.CommonGasoline, Translator.Translate(FuelType.CommonGasoline.ToString())),
            new FuelTypeOption(FuelType.AdditivatedGasoline, Translator.Translate(FuelType.AdditivatedGasoline.ToString())),
            new FuelTypeOption(FuelType.Ethanol, Translator.Translate(FuelType.Ethanol.ToString())),
            new FuelTypeOption(FuelType.Diesel, Translator.Translate(FuelType.Diesel.ToString()))
        };

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

        public void SetViewVisibility(bool visible)
        {
            Visible = visible;
        }
    }
}
