using TestProject.Model.Enums;

namespace TestProject.Controller.ComboBoxOptions
{
    public class FuelTypeOption
    {
        public FuelType Type;
        public string PreviewName;

        public FuelTypeOption(FuelType type, string previewName)
        {
            Type = type;
            PreviewName = previewName;
        }

        public override string ToString()
        {
            return PreviewName;
        }
    }
}
