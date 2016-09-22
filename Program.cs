using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ShoskesShakespeareAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader firstReader = new StreamReader("../../../../../../Shakespeare.txt");
            string firstLine = firstReader.ReadLine();
            Console.WriteLine(firstLine);
            firstReader.Close();
            StreamReader secondReader = new StreamReader("../../../../../../Shakespeare.txt");
            string secondLine = secondReader.ReadLine();
            while (secondLine != null)
            {
                Console.WriteLine(secondLine);
                secondLine = secondReader.ReadLine();
            }
            secondReader.Close();
            StreamReader thirdReader = new StreamReader("../../../../../../Shakespeare.txt");
            string thirdLine = thirdReader.ReadLine();
            Dictionary<string, string> vowelDict = new Dictionary<string, string>();
            vowelDict.Add("a", "A");
            vowelDict.Add("e", "E");
            vowelDict.Add("i", "I");
            vowelDict.Add("o", "O");
            vowelDict.Add("u", "U");
            while (thirdLine != null)
            {
                foreach (string vowelKey in vowelDict.Keys)
                {
                    thirdLine = thirdLine.Replace(vowelKey, vowelDict[vowelKey]);
                }
                Console.WriteLine(thirdLine);
                thirdLine = thirdReader.ReadLine();
            }
        }
    }
}
