using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JunkGen
{ 
    static class Program
    {
        public static string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        
        static void Main(string[] args)
        {
            Generate(int.Parse(args[0]));
        }
        
        static void Generate(int charlength)
        {
            for (int i = 0; i < charlength; i++)
            {
                File.AppendAllText(Environment.CurrentDirectory + @"/adding.txt", GenerateChar());
            }

        }
        
        public static string GenerateChar()
        {
            return alphabet[(new Random()).Next(alphabet.Length)].ToString();
        }
    }

}
