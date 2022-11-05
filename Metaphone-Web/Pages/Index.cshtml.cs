using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.RegularExpressions;

namespace Metaphone_Web.Pages
{
    public class IndexModel : PageModel
    {
        public string? Text { get; set; }

        public void OnGet()
        {
            
        }
        public void OnPost(string text, string transcribed)
        {
            bool isValid = Validate(text);
            if (isValid)
                Text = text;
            else Text = "Input text is not valid!";
            if (!string.IsNullOrEmpty(transcribed))
            {
                Text = "";
            }
        }

        private bool Validate(string text)
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