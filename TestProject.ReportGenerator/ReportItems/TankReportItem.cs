namespace TestProject.ReportGenerator.ReportItems
{
    public class TankReportItem
    {
        public string Name { get; }
        public string StorageCapacity { get; }
        public string FuelName { get; }

        public TankReportItem(string name, string storageCapacity, string fuelName)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            FuelName = fuelName ?? "Nenhum";
        }
    }
}
