using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.RegularExpressions;

namespace Metaphone_Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }
        public void OnPost(string text)
        {
            bool isValid = Validate(text);
        }

        private bool Validate(string text)
        {
            //bool isAllLetters = false;
            bool isOnlyLetters = false;
            if (!string.IsNullOrEmpty(text))
            {
                //isAllLetters = text.All(c => char.IsLetter(c));
                isOnlyLetters = Regex.IsMatch(text, @"^[a-zA-Z\s]+$");
            }
            //return isAllLetters;
            return isOnlyLetters;
        }
    }
}