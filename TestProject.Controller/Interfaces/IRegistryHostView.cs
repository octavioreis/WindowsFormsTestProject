namespace TestProject.Controller.Interfaces
{
    public interface IRegistryHostView
    {
        void SetSaveButtonTooltip(string text);

        IFuelView GetFuelView();
        ITankView GetTankView();
        INozzleView GetNozzleView();

        void SetController(RegistryHostController controller);
    }
}
