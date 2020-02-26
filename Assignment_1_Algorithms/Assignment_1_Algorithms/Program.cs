using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithhms_and_complexity_asignment_1
{
    class Program
    {
        static List<Arrays> Net_1_List = new List<Arrays>();
        static List<Arrays> Net_2_List = new List<Arrays>();
        static List<Arrays> Net_3_List = new List<Arrays>();
        static void Main(string[] args)
        {
            Console.WriteLine($"Please eneter which array you would like to select\nThe arrays you are able to select are\n'Net_1'");
            string SelectArracy = Console.ReadLine();

            if (SelectArracy == "Net_1")
            {
                string[] lines = ReadFiles();
            }
            else
            {
                Console.WriteLine("You have not enetered a correct input. Please exit and enter a correct input");
            }
        }


        public static string[] ReadFiles() //  Read the files and convert into an array of integers
        {
            try
            {
                string[] Net1 = File.ReadAllLines("Net_1_256.txt");
                string[] Net2 = File.ReadAllLines("Net_2_256.txt");
                string[] Net3 = File.ReadAllLines("Net_3_256.txt");

                int count = 0;
                foreach (string s in Net1)
                {
                    Arrays a = new Arrays(int.Parse(Net1[count]), int.Parse(Net2[count]), int.Parse(Net3[count]));
                    Net_1_List.Add(a);
                    Net_2_List.Add(a);
                    Net_3_List.Add(a);
                    Console.WriteLine(Net_1_List[count].Net_1);
                    Console.WriteLine(Net_2_List[count].Net_2);
                    Console.WriteLine(Net_3_List[count].Net_3);
                    count++;
                }
                Console.ReadKey();
                return null;
            }
            catch(FileNotFoundException)
            {
                string[] temp = { "Net_1_256.txt not found " };
                return temp;
            }
        }

    }
    class Arrays
    {
        public int Net_1 { get; set; }
        public int Net_2 { get; set; }
        public int Net_3 { get; set; }
        public Arrays(int Net_1_, int Net_2_, int Net_3_)
        {
            Net_1 = Net_1_;
            Net_2 = Net_2_;
            Net_3 = Net_3_;
        }
    }
}