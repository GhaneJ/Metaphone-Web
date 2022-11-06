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
            dropSilent = exceptedletters.DropBeginningSilentLetters(word);            
            consonantLetters = consonants.ConsonantTransformer(dropSilent);
            vowelDrop = vowels.VowelRemover(consonantLetters);
            removeDuplicate = adjacent.DropDuplicateConsonant(vowelDrop);

            return removeDuplicate;
        }
    }
}