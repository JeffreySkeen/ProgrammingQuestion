
using System.Text;

namespace ProgrammingQuestion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CapitalizeLetters("hello world") == "heLlo woRld");
            Console.WriteLine(CapitalizeLetters("entelect") == "eNteLeCt");
            Console.WriteLine(CapitalizeLetters("open book") == "oPeN booK");
            Console.WriteLine(CapitalizeLetters("aaaaaaah") == "aaaaaaaH");
            Console.WriteLine(CapitalizeLetters("") == "");
        }

        private static string CapitalizeLetters(string txt)
        {
            char[] vowels = ['a', 'e', 'i', 'o', 'u','A','E','I','O','U'];

            bool shouldCapitalize = false;
            StringBuilder ans = new StringBuilder();

            for (int i = 0; i < txt.Length; i++)
            {
                // Rule 2: if current char is a vowel dont capitalize
                if (vowels.Contains(txt[i]))
                {
                    shouldCapitalize = false;
                }

                if (shouldCapitalize)
                {
                    ans.Append(Char.ToUpper(txt[i]));
                }
                else
                {
                    ans.Append(txt[i]);
                }

                // default flag to false for next run
                shouldCapitalize = false;

                // Rule 3: if white space dont capitalize
                if (char.IsWhiteSpace(txt[i]))
                {
                    shouldCapitalize = false;
                    continue;
                }

                // Rule 1: if vowel capitilize the next character if its not a vowel
                if (vowels.Contains(txt[i])) {
                    shouldCapitalize = true;
                }
            }

            return ans.ToString();
        }
    }
}
