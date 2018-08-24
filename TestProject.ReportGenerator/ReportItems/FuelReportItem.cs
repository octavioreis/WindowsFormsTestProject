namespace TestProject.ReportGenerator.ReportItems
{
    public class FuelReportItem
    {
        public string Name { get; }
        public string Type { get; }

        public FuelReportItem(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
