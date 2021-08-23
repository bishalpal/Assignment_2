using System;
using System.IO;


namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem statement - Write a sample paragraph in a text file. Write a C# code to take a string input from the user and find the occurrence of the input string in the Sample file. Print the line number of the 2nd instance of that string from the file on the console.

            string[] towrite = { "I like to eat lfruits.", "Fruits are rich in vitamins and minerals.", "Do you eat fruits rich in vitamin A ?"};
            File.WriteAllLines(@"D:\MY CODING PRACTICE\Practice - C#\Assignment_2\file.txt", towrite);
            

            // Reading the content from the file 
            string[] lines = File.ReadAllLines(@"D:\MY CODING PRACTICE\Practice - C#\Assignment_2\file.txt");

            // printing the lines 
            foreach(string s in lines)
                Console.WriteLine(s);
            Console.WriteLine();


            Console.Write("Enter a string to search in file : ");
            string tosearch = Console.ReadLine();
            Console.WriteLine();

            string[] eachline;
            int count = 0;
            Boolean setflag = false;



            for(int i = 0; i<lines.Length; i++)
            {
                eachline = lines[i].Split(' ');
                foreach(string word in eachline)
                {
                    if (word.ToLower() == tosearch.ToLower())
                        count++;

                    if(count == 2)
                    {
                        Console.WriteLine("\n2nd instance of entered string found at line {0} in file when ignoring the case (i.e. lower case/upper case)", i+1);
                        setflag = true;
                        break;
                    }
                }
                if (setflag)
                    break;
            }

            if(count == 0)
                Console.WriteLine("The entered string \" {0} \" could not be found in the file.", tosearch);
        }
    }
}
