using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/*
 * Solution for the 5th advent of code challenge 2020
 * Find out more about advent of code @ https://adventofcode.com/
 * Link to challenge: https://adventofcode.com/2020/day/5
 */
namespace AdventOfCode_2020_Day_05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = new List<string>(File.ReadAllLines("input.txt"));
            List<int> seatIDs = GetSeatIds(inputList);

            Console.WriteLine("Solution One: " + PuzzleOne(seatIDs));
            Console.WriteLine("Solution Two: " + PuzzleTwo(seatIDs));
            Console.ReadKey(true);
        }

        static int PuzzleOne(in List<int> seatIDs)
        {
            return seatIDs.Max();
        }

        static int PuzzleTwo(List<int> seatIDs)
        {
            seatIDs.Sort();
            return Enumerable.Range(seatIDs[0], seatIDs[^1]).Except(seatIDs).First();
        }

        static List<int> GetSeatIds(in List<string> input)
        {
            List<int> seatIDs = new List<int>();
            string bin;

            foreach (string s in input)
            {
                bin = s.Replace('F', '0').Replace('B', '1').Replace('L', '0').Replace('R', '1');
                seatIDs.Add(Convert.ToInt32(bin, 2));
            }
            return seatIDs;
        }
    }
}
