namespace Metaphone_Web.Pages.Transformation_Rules
{
    public class Vowels
    {
        public string VowelRemover(string word)
        {
            string[] vowels = new string[] { "A", "E", "I", "O", "U" };
            if (word.StartsWith('A') || word.StartsWith('E') || word.StartsWith('I') || word.StartsWith('O') || word.StartsWith('U'))
            {
                string startingLetter = word.Substring(0, 1);
                foreach (var letter in vowels)
                {
                    //word = word[word.IndexOf(word.Substring(0, 1))];
                    word = word.Replace(letter, string.Empty);
                }
                word = startingLetter + word;
            }
            else
            {
                foreach (var letter in vowels)
                {
                    word = word.Replace(letter, string.Empty);
                }
            }
            return word;
        }
    }
}