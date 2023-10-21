namespace Metaphone_Web.Pages.Validation;

using System.Text.RegularExpressions;

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
