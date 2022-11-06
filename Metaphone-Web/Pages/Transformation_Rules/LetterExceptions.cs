namespace Metaphone_Web.Pages.Transformation_Rules
{
    public class LetterExceptions
    {
        public string DropBeginningSilentLetters(string word)
        {
            // Since "ac" starts with 'a' and 'a' is a vowel and removing
            // a vowel from the beginning violates our rules, so it will be
            // exempted from this method. ex. Acclaim, accept => aclm, acpt

            if (word.StartsWith("KN") || word.StartsWith("GN") || word.StartsWith("PN") || word.StartsWith("WR"))
            {
                int drop = word.IndexOf(word.Substring(0, 1));
                word = word.Remove(drop, 1);

            }
            if (word.StartsWith('X'))
            {
                word = word.Replace('X', 'S');
            }
            if (word.StartsWith("WH"))
            {
                int drop = word.IndexOf(word.Substring(1, 1));
                word = word.Remove(drop, 1);
            }

            return word;
        }
    }
}