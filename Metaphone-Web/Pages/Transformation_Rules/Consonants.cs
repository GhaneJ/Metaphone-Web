namespace Metaphone_Web.Pages.Transformation_Rules;

public class Consonants
{
    public string ConsonantTransformer(string word)
    {
        if (!string.IsNullOrEmpty(word))
        {

            if (word.Length == 1)
            {
                return word;
            }
            if (word.EndsWith('B') && word[word.IndexOf('B') - 1] == 'M')
            {
                word = word.Remove(word.IndexOf('B'), 1);
            }

            if (word.Contains("CK"))
            {
                word = word.Remove(word.IndexOf('C'), 1);
            }

            if (word.Contains("CIA"))
            {
                word = word.Replace("C", "X");
            }

            if (word.Contains("CH"))
            {
                word = word.Replace("CH", "XH");
            }

            else if (word.Contains('C'))
            {
                word = word.Replace('C', 'K');
            }

            if (word.Contains("DGE") || word.Contains("DGI") || word.Contains("DGY"))
            {
                word = word.Replace('D', 'J');
                word = word.Remove(word.IndexOf('G'), 1);
            }

            else if (word.Contains('D'))
            {
                word = word.Replace('D', 'T');
            }

            if (word.Contains("CE") || word.Contains("CI") || word.Contains("CY"))
            {
                word = word.Replace('C', 'S');
            }

            if (word.Contains("GN") || word.Contains("GNED"))
            {
                word = word.Remove(word.IndexOf('G'), 1);
            }

            if (word.Contains("GI") || word.Contains("GE") || word.Contains("GY"))
            {
                word = word.Replace('G', 'J');
            }

            else if (word.Contains('G'))
            {
                word = word.Replace('G', 'K');
            }

            if (word.Substring(word.Length - 2) == "GH")
            {

            }

            else if (word.Contains("GH") || word.Contains("AH") || word.Contains("EH") || word.Contains("IH") || word.Contains("OH") || word.Contains("UH"))
            {
                word = word.Remove(word.IndexOf('H'), 1);
            }

            if (word.Contains("PH"))
            {
                word = word.Replace("PH", "F");
            }

            if (word.Contains("SIA"))
            {
                word = word.Replace("S", "X");
            }

            if (word.Contains("SIO"))
            {
                word = word.Replace("S", "X");
            }

            if (word.Contains("SH"))
            {
                word = word.Replace("S", "X");
            }

            if (word.Contains("TIA"))
            {
                word = word.Replace("T", "X");
            }

            if (word.Contains("TIO"))
            {
                word = word.Replace("T", "X");
            }

            if (word.Contains("TH"))
            {
                word = word.Replace("TH", "0");
            }

            if (word.Contains("TCH"))
            {
                word = word.Remove(word.IndexOf("T"), 1);
            }

            if (word.Contains('Q'))
            {
                word = word.Replace("Q", "K");
            }

            if (word.Contains('V'))
            {
                word = word.Replace("V", "F");
            }

            if (word.Contains("WA") || word.Contains("WE") || word.Contains("WI") || word.Contains("WO") || word.Contains("WU"))
            {

            }

            else if (word.Contains('W'))
            {
                word = word.Remove(word.IndexOf("W"), 1);
            }

            if (word.Contains('X'))
            {
                if(word.IndexOf('X') == 0)
                {
                    word = word.Replace("X", "S");
                }
                else
                word = word.Replace("X", "KS");
            }

            if (word.Contains("YA") || word.Contains("YE") || word.Contains("YI") || word.Contains("YO") || word.Contains("YU"))
            {

            }

            else if (word.Contains('Y'))
            {
                word = word.Remove(word.IndexOf("Y"), 1);
            }

            if (word.Contains('Z'))
            {
                word = word.Replace("Z", "S");
            }
        }

        return word;
    }
}