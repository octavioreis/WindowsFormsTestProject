namespace TestProject.Controller.Interfaces
{
    public interface ISaveView
    {
        void SetSaveButtonTooltip(string text);

        IFuelView GetFuelView();
        ITankView GetTankView();
        INozzleView GetNozzleView();

        void SetController(SaveController controller);
    }
}
