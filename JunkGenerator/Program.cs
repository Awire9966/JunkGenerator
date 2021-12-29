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
        static void Main(string[] args)
        {
            Generate(int.Parse(args[0]));
        }
        static void Generate(int charlength)
        {

            for (int i = 0; i < charlength; i++)
            {

                if (File.Exists(Environment.CurrentDirectory + @"/adding.txt") == true)
                {
                    File.WriteAllText(Environment.CurrentDirectory + @"/adding.txt", File.ReadAllText(Environment.CurrentDirectory + @"/adding.txt") + getrandomchar());
                }
                if (!File.Exists(Environment.CurrentDirectory + @"/adding.txt") == true)
                {
                    File.WriteAllText(Environment.CurrentDirectory + @"/adding.txt", getrandomchar());
                }

            }
            return;


        }
        static string getrandomchar()
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 61);
            if (randomnumber == 1)
            {
                return "1";
            }

            if (randomnumber == 2)
            {
                return "2";
            }
            if (randomnumber == 3)
            {
                return "3";
            }
            if (randomnumber == 4)
            {
                return "4";
            }

            if (randomnumber == 5)
            {
                return "5";
            }
            if (randomnumber == 6)
            {
                return "6";
            }
            if (randomnumber == 7)
            {
                return "7";
            }
            if (randomnumber == 8)
            {
                return "8";
            }
            if (randomnumber == 9)
            {
                return "9";
            }
            if (randomnumber == 10)
            {
                return "a";
            }
            if (randomnumber == 11)
            {
                return "b";
            }
            if (randomnumber == 12)
            {
                return "c";
            }
            if (randomnumber == 13)
            {
                return "d";
            }
            if (randomnumber == 14)
            {
                return "e";
            }
            if (randomnumber == 15)
            {
                return "f";
            }
            if (randomnumber == 16)
            {
                return "g";
            }
            if (randomnumber == 17)
            {
                return "h";
            }
            if (randomnumber == 18)
            {
                return "i";
            }
            if (randomnumber == 19)
            {
                return "j";
            }
            if (randomnumber == 20)
            {
                return "k";
            }
            if (randomnumber == 21)
            {
                return "l";
            }
            if (randomnumber == 22)
            {
                return "m";
            }
            if (randomnumber == 23)
            {
                return "n";
            }
            if (randomnumber == 24)
            {
                return "o";
            }
            if (randomnumber == 25)
            {
                return "p";
            }
            if (randomnumber == 26)
            {
                return "q";
            }
            if (randomnumber == 27)
            {
                return "r";
            }
            if (randomnumber == 28)
            {
                return "s";
            }
            if (randomnumber == 29)
            {
                return "t";
            }
            if (randomnumber == 30)
            {
                return "u";
            }
            if (randomnumber == 31)
            {
                return "v";
            }
            if (randomnumber == 32)
            {
                return "w";
            }
            if (randomnumber == 33)
            {
                return "x";
            }
            if (randomnumber == 34)
            {
                return "y";
            }
            if (randomnumber == 35)
            {
                return "z";
            }
            if (randomnumber == 36)
            {
                return "A";
            }
            if (randomnumber == 37)
            {
                return "B";
            }
            if (randomnumber == 38)
            {
                return "C";
            }
            if (randomnumber == 39)
            {
                return "D";
            }
            if (randomnumber == 40)
            {
                return "E";
            }
            if (randomnumber == 41)
            {
                return "F";
            }
            if (randomnumber == 42)
            {
                return "G";
            }
            if (randomnumber == 43)
            {
                return "H";
            }
            if (randomnumber == 44)
            {
                return "I";
            }
            if (randomnumber == 45)
            {
                return "J";
            }
            if (randomnumber == 46)
            {
                return "K";
            }
            if (randomnumber == 47)
            {
                return "L";
            }
            if (randomnumber == 48)
            {
                return "M";
            }
            if (randomnumber == 49)
            {
                return "N";
            }
            if (randomnumber == 50)
            {
                return "O";
            }
            if (randomnumber == 51)
            {
                return "P";
            }
            if (randomnumber == 52)
            {
                return "Q";
            }
            if (randomnumber == 53)
            {
                return "R";
            }
            if (randomnumber == 54)
            {
                return "S";
            }
            if (randomnumber == 55)
            {
                return "T";
            }
            if (randomnumber == 56)
            {
                return "U";
            }
            if (randomnumber == 57)
            {
                return "V";
            }
            if (randomnumber == 58)
            {
                return "W";
            }
            if (randomnumber == 59)
            {
                return "X";
            }
            if (randomnumber == 60)
            {
                return "Y";
            }
            if (randomnumber == 61)
            {
                return "Z";
            }

            else
            {
                return "error";
            }
        }
    }

}
