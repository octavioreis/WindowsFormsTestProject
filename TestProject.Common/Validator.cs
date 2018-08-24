namespace TestProject.Common
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
    }
}
