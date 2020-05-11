using System;
using System.Linq; 
using System.IO; 

namespace C__Assign1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prompt Enter a filename");
            string fname = Console.ReadLine();
            string filename = fname+".txt";
            Console.WriteLine("Prompt Enter a string to parse");
            string stop = Console.ReadLine();

            while(stop != "exit")
            {
                string readText = File.ReadAllText(filename);  // Read the contents of the file
                readText=readText.Replace(stop,"");
                File.WriteAllText(filename, readText);
                Console.WriteLine("File contents");
                Console.WriteLine(readText);  // Output the content
                Console.WriteLine("Prompt Enter a string to parse or enter 'exit' to stop");
                stop = Console.ReadLine();
            }
        }
    }
}