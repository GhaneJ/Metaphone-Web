using Metaphone_Web.Pages.Transformation_Rules;
using Metaphone_Web.Pages.Validation;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Metaphone_Web.Pages
{
    public class IndexModel : PageModel
    {
        public string? Text { get; set; }
        public string? Transcribed { get; set; }
        
        public void OnPost(string text, string transcribed)
        {
            InputValidation validate = new InputValidation();
            bool isValid = validate.InputValidate(text);
            if (isValid)
                Text = text.ToUpper();
            else Text = " ";
            if (!string.IsNullOrEmpty(transcribed))
            {
                Transcribed = "";
            }
            Transformation transform = new Transformation();
            string transformed = transform.Filters(Text);
            Text = transformed;
        }
    }
}