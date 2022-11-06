using System.Text.RegularExpressions;

namespace Metaphone_Web.Pages.Validation
{
    public class InputValidation
    {
        public bool InputValidate(string text)
        {
            bool isOnlyLetters = false;
            if (!string.IsNullOrEmpty(text))
            {
                isOnlyLetters = Regex.IsMatch(text, @"^[a-zA-Z\s]+$");
            }
            return isOnlyLetters;
        }
    }
}
