using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Montrose_puzzle1
{
    class Program
    {
        public static Dictionary<char, char> numDic = new Dictionary<char, char>
        {
            {'0','0'},
            {'1','1'},
            {'A','2'},
            {'B','2'},
            {'C','2'},
            {'D','3'},
            {'E','3'},
            {'F','3'},
            {'G','4'},
            {'H','4'},
            {'I','4'},
            {'J','5'},
            {'K','5'},
            {'L','5'},
            {'M','6'},
            {'N','6'},
            {'O','6'},
            {'P','7'},
            {'R','7'},
            {'S','7'},
            {'T','8'},
            {'U','8'},
            {'V','8'},
            {'W','9'},
            {'X','9'},
            {'Y','9'}
        };
        public static void permutations(List<List<char>> comboL, int i, String s)
        {
            if (i == comboL.Count)
            {
                Console.WriteLine(s);
                return;
            }
            for (int j = 0; j < comboL[i].Count; j++)
            {
                permutations(comboL, i + 1, s + comboL[i][j]);
            }
        }

        public static void TranslateNumber(string num, Dictionary<char, char> D)
        {
            List<List<char>> comboList = new List<List<char>>();

            foreach (var n in num)
            {
                var kList = new List<char>();
                foreach (var item in D)
                {
                    if (item.Value == n)
                    {
                        kList.Add(item.Key);
                    }
                }
                comboList.Add(kList);
            }
            permutations(comboList, 0, "");
        }
        static void Main(string[] args)
        {
            string number;
            number = Console.ReadLine();
            foreach (var item in number)
            {
                if ((int)item < 48 || (int)item > 57)
                {
                    Console.WriteLine("ERROR");
                    return;
                }
            }
            if (number.Length != 9)
            {
                Console.WriteLine("ERROR");
            }
            else
                TranslateNumber(number, numDic);

            Console.ReadKey();
        }
    }
}
