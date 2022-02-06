using System;
using System.Collections.Generic;
using System.Linq;

namespace KataTest
{
    public class Program
    {
        public Dictionary<string, int> ChangeTypeDictionary = new Dictionary<string, int>()
            {
                { "one", 1 },
                { "two", 2},
                { "three", 3 },
                { "four", 4 },
                { "five", 5 },
                { "six", 6 },
                { "seven",7 },
                { "eight", 8 },
                { "nine", 9 },
                { "zero", 0 }
            };
        static void Main(string[] args)
        {
            var program = new Program();
            Console.WriteLine(program.StringAverage(""));
        }
        public string StringAverage(string input)
        {
            if (input == "") return "n/a";

            var numbers = input.Split(" ");

            var sum = 0;
            foreach (var number in numbers)
            {
                if (!ChangeTypeDictionary.ContainsKey(number)) return "n/a";
                sum += ChangeTypeDictionary[number];
            }
            sum /= numbers.Length;
            return ChangeTypeDictionary.FirstOrDefault(x => x.Value == sum).Key;
        }
        public int DeadAntCount(string ants)
        {
            if (string.IsNullOrEmpty(ants)) return 0;
            return
                ants.Split("ant")
                    .Select(x => x.AsEnumerable().Count(y => y == 'a'))
                    .Sum(x => x);
        }
    }
}
