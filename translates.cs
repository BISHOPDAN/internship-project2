// The Translation Task For My Internship


using System;

namespace Translate
{
    class Program
    {
        static void Main(string[] args)
        {
            const string SPACE = " ";
                string pig = "";
                string first;
                string last;

                string txtEnglish = "The quick brown fox";        
                string[] words = txtEnglish.Split(' ');

                foreach (string word in words)
                {
                    first = word.Substring(0, 1);                        
                    last = word.Substring(1, word.Length - 1);                      
                    bool isVowel = "aeiouAEIOU".IndexOf(first) >= 0;
                    if (isVowel)
                    {
                        pig += word + "way" + SPACE;                       
                    }
                    else
                    {
                        pig += last + first + "ay" + SPACE;
                    }
                }
                Console.WriteLine(pig);
            }
        } 
}
