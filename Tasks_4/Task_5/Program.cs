using System;
using System.IO;

namespace Task_5
{
    class Massivs
    {
        public void Changex(ref int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i]%2==0)
                {
                    x[i] = 2* x[i];
                }
            }
            Whitex(ref x);
        }
        public void Whitex(ref int[] x)
        {
            Console.WriteLine("Новий масив х: ");
            Console.WriteLine(string.Join(",", x));
        }
        public void Magic(int[] x, int[] y, ref int[] z)
        {
            for (int i = 0; i<x.Length; i++)
            {
                z[i] = x[i] * y[i];
            }
            Writezz(ref z);
        }
        public void Writezz(ref int[] z)
        {
            Console.WriteLine("Масив z : ");
            Console.WriteLine(string.Join(",", z));
        }
    }
    class Program
    {
        private static int[] Readin(string path)
        {
            string[] file_data = File.ReadAllText(path).Split(" ");
            int[] massi = new int[file_data.Length];
            for (int i = 0; i < file_data.Length; i++)
            {
                try
                {
                    massi[i] = Convert.ToInt32(file_data[i]);
                    Console.WriteLine(massi[i]);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Щось не так з даними.");
                    Environment.Exit(1);
                }
            }
            return massi;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Massivs trying = new Massivs();

            string path_x = @"files\x.txt";
            Console.WriteLine("Масив x: ");
            int[] x = Readin(path_x);
            trying.Changex(ref x);


            string path_y = @"files\y.txt";
            Console.WriteLine("Масив y: ");
            int[] y = Readin(path_y);
            

            int[] z = new int[x.Length];
            trying.Magic(x, y, ref z);


            Console.ReadKey();
        }
    }
}
