namespace AuthControl.API.Utils
{
    public class GenerateUsername
    {
        public static string Run(string name)
        {
            var names = name.Split(" ");
            string initialChar = names[0].Substring(0, 1).ToUpper();
            string lastName = names.Length > 1 ? names[names.Length - 1].ToUpper() : "";

            return initialChar + lastName;
        }
    }
}
