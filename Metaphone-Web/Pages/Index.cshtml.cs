using Metaphone_Web.Pages.Transformation_Rules;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.RegularExpressions;

namespace Metaphone_Web.Pages
{
    public class IndexModel : PageModel
    {
        public string? Text { get; set; }
        public string? Transcribed { get; set; }

        public void OnGet()
        {
            
        }
        public void OnPost(string text, string transcribed)
        {
            Transformation transform = new Transformation();

            bool isValid = Validate(text);
            if (isValid)
                Text = text.ToUpper();
            else Text = "Input text is not valid!";
            if (!string.IsNullOrEmpty(transcribed))
            {
                Transcribed = "";
            }

            string transformed = transform.Filters(Text);
            Text = transformed;
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