using TestProject.Globalization;
using TestProject.Model;

namespace TestProject.ReportGenerator.ReportItems
{
    public class FuelReportItem
    {
        public string Name { get; }
        public string Type { get; }

        public FuelReportItem(Fuel fuel)
        {
            Name = fuel.Name;
            Type = Translator.Translate(fuel.Type.ToString());
        }
    }
}
