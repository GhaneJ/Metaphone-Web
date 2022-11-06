namespace Metaphone_Web.Pages.Transformation_Rules
{
    public class DuplicateConsonants
    {
        public string DropDuplicateConsonant(string word) 
        {
            int res_ind = 1, ip_ind = 1;

            // Character array for removal of duplicate characters
            char[] arr = word.ToCharArray();

            /* In place removal of duplicate characters*/
            while (ip_ind != arr.Length)
            {
                if (arr[ip_ind] != arr[ip_ind - 1])
                {
                    arr[res_ind] = arr[ip_ind];
                    res_ind++;
                }
                ip_ind++;

            }

            word = new String(arr);
            return word.Substring(0, res_ind);
        }
    }
}