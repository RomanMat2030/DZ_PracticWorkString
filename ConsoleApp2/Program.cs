using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Task.1
            //string StrArr = "Привіт світ ! ";
            //Console.WriteLine(StrArr.Length);
            //Console.WriteLine("Enter word to insert: ");
            //string message = Console.ReadLine();

            //Console.WriteLine("Введи індекс: ");
            //int indexOfChar = int.Parse(Console.ReadLine());

            //StrArr = StrArr.Insert(indexOfChar, message);
            //Console.WriteLine(StrArr);
            //Task.2
            string wordArr = "pop";
            bool flag = false;
            //Console.WriteLine(wordArr.Length);
            for (int i = 0; i < wordArr.Length; i++)
            {
                if (wordArr[i] == wordArr[wordArr.Length-i-1])
                {
                    flag= true;
                }
                else
                {
                    flag = false; 
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Is palidrome!");
            }
            else
            {
                Console.WriteLine("Is not palidrome!");
            }
            //Task.3
        }
    }
}
