namespace TestProject.ReportGenerator.ReportItems
{
    public class NozzleReportItem
    {
        public string Name { get; }
        public string SellingPrice { get; }
        public string TankName { get; }

        public NozzleReportItem(string name, string sellingPrice, string tankName)
        {
            Name = name;
            SellingPrice = sellingPrice;
            TankName = tankName ?? "Nenhum";
        }
    }
}
