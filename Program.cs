using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Count_String
{
    class Program
    {
        static void Main(string[] args)
        {
            String Sentence;
            Console.WriteLine("Enter String");
            Sentence = Console.ReadLine();
            String[] words = Sentence.Split(' ');
            Console.WriteLine("Count of words " + words.Length);
            Console.ReadKey(); 
        }
    }
}
