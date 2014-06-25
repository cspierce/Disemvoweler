using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program is going to be awesome
            Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!");
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");
            Console.ReadKey();
        }
        static void Disemvoweler(string input)
        {
            //hold our output
            string vowels = "";
            string consonants = "";
            for (int i = 0; i < input.Length; i ++)
            {
                char letter = input[i];
                //pull vowels out of string
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'I')
                {
                    //convert letters to string
                    vowels = vowels + letter.ToString();
                }
                    //pull special characters out of string
                else if (letter != ' ' && letter != '.' && letter != '?' && letter != ',' && letter != '!' && letter != '\'')
                {
                    //convert letters to string
                    consonants = consonants + letter.ToString();
                }
          
            }
             //print to console
            Console.WriteLine("Original: "+ input);
            Console.WriteLine("Disemvoweled: "+ consonants);
        }
    }
}
