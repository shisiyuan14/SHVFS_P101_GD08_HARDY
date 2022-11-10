using System;
using System.IO.Pipes;
using System.Reflection.Metadata;

namespace SHVFS_P101_GD08_Q4_Hardy
{
    class program
    {
        public static void Main(string[] args)
        {
            string a,answer;
            int i = 0;
            Random rnd = new Random();
            string[] names = { "Hardy", "Chris", "Bandy","April","Cloud","Matt" };
            int nameIndex = rnd.Next(names.Length);
            Console.WriteLine("Hello user! Let's play a word guessing game!");
            Console.WriteLine("Please input your name!");
            a=Console.ReadLine();
            Console.WriteLine($"Ok,{a}. The game begin!");
            do
            {
                
                Console.WriteLine("Please guess the correct name from \"Hardy\", \"Chris\", \"Bandy\",\"April\",\"Cloud\",\"Matt\"");
                answer = Console.ReadLine();
                if(answer== names[nameIndex])
                {
                    Console.WriteLine("You got the answer!");
                }
                else if(answer != names[nameIndex])
                {
                    Console.WriteLine("Wrong!");
                    Console.WriteLine("Please input anything to clear");
                    Console.ReadLine();
                    Console.Clear();
                }
                i=i+1;  
            } while (answer != names[nameIndex]);
            
            Console.WriteLine($"And you have used {i} times, great!");







        }


    }




}