using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Tasks_CS_2
{
    public static class Extension
    { 
        public static string[] ReverseWord(this string[] strArray)
        {
            if (strArray is null)
            {
                throw new ArgumentNullException(nameof(strArray));
            }
            string temp;
            int j = strArray.Length - 1;
            for (int i = 0; i < j; i++)
            {
                temp = strArray[i];
                strArray[i] = strArray[j];
                strArray[j] = temp;
                j--;
            }
            return strArray;
        }
    }
    class Task2_CS
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(Input is Optional and Default value will be 'This is a Test on Words'");
            Console.WriteLine("Enter your data to Reverse otherwise just Hit Enter");
            var sampleText = Console.ReadLine();
            if (string.IsNullOrEmpty(sampleText))
                sampleText = "This is a Test on Words";
            Console.WriteLine("=======================================================");
            Console.WriteLine( "Original Text : "+sampleText);
            Console.WriteLine("=======================================================");
            Console.Write( "Reversed order of words (Static Method): ");
            DisplayArrayValues(Extension.ReverseWord(sampleText.Split(' ')));
            Console.WriteLine("======================================================");
            Console.Write( "Reversed order of words (Extension Method): ");
            DisplayArrayValues(sampleText.Split(' ').ReverseWord());
            Console.ReadLine();
        }
        static void DisplayArrayValues(string[] strArray)
        {
            if (strArray is null)
            {
                throw new ArgumentNullException(nameof(strArray));
            }
            for (int i = 0; i < strArray.Length; i++)
                Console.Write(strArray[i] + " ");
            Console.WriteLine();
        }
    }
}
