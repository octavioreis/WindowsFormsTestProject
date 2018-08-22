using TestProject.Model.Enums;

namespace TestProject.Controller.ModelWrappers
{
    public class FuelTypeObject
    {
        public FuelType Type;
        public string PreviewName;

        public FuelTypeObject(FuelType type, string previewName)
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
