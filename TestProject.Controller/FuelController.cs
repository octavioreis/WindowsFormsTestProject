using TestProject.Controller.Interfaces;
using TestProject.Database;
using TestProject.Model;

namespace TestProject.Controller
{
    public class FuelController : AbstractRegistryController
    {
        private readonly IFuelView _view;
        private readonly IDatabase _database;
        private Fuel _fuel;

        public FuelController(IFuelView view, IDatabase database) : base(view)
        {
            _view = view;
            _database = database;

            view.SetController(this);
        }

        #region AbstractRegistryController Members

        public override string GetSaveButtonTooltip()
        {
            return "Salvar alterações no combustível (Ctrl+S)";
        }

        public override void UpdateViewItem(IdentifiedRegistry identifiedRegistry)
        {
            _fuel = identifiedRegistry as Fuel;
            UpdateView();
        }

        public override void UpdateView()
        {
            _view.FuelName = _fuel.Name;
            _view.FuelType = _fuel.Type;
        }

        protected sealed override void UpdateModel()
        {
            _fuel.Name = _view.FuelName;
            _fuel.Type = _view.FuelType;
            _database.SerializeFuel(_fuel.Id);
        }

        protected sealed override bool ValidateFields(out string message)
        {
            return Validator.ValidateName(_view.FuelName, out message);
        }

        #endregion
    }
}
