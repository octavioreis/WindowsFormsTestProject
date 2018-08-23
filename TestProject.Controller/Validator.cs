namespace TestProject.Controller
{
    public static class Validator
    {
        public static bool ValidateName(string value, out string message)
        {
            message = null;

            if (string.IsNullOrWhiteSpace(value))
            {
                message = "O nome não pode estar em branco.";
                return false;
            }

            return true;
        }

        public static bool ValidateFloatValue(string value, out string message)
        {
            message = null;

            if (!float.TryParse(value, out float result))
            {
                message = $"O valor {value} não pode conter texto.";
                return false;
            }

            return true;
        }
    }
}
