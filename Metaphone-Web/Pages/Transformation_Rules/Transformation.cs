namespace Metaphone_Web.Pages.Transformation_Rules
{
    public class Transformation
    {
        DuplicateConsonants adjacent = new DuplicateConsonants();
        LetterExceptions exceptedletters = new LetterExceptions();
        Vowels vowels = new Vowels();
        Consonants consonants = new Consonants();
        string? dropSilent;
        string? removeDuplicate;
        string? consonantLetters;
        string? vowelDrop;
        public string Filters(string word)
        {
            removeDuplicate = adjacent.DropDuplicateConsonant(word);
            dropSilent = exceptedletters.DropBeginningSilentLetters(removeDuplicate);            
            consonantLetters = consonants.ConsonantTransformer(dropSilent);
            vowelDrop = vowels.VowelRemover(consonantLetters);

            return vowelDrop;
        }
    }
}