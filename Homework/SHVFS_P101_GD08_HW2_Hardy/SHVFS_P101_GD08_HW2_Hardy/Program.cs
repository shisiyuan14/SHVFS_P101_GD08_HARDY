using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace SHVFS_P101_GD08_HW2_Hardy
{
    
    public class program
    {
        
        public static void Main(string[] args)
        {
            string f;
            float a;
            Console.WriteLine("       Fahrenheight Calculator!\n          ");
            Console.WriteLine("Please input a Fahrenheight!");
            f= Console.ReadLine();
            var f1converted = Convert.ToSingle(f);
            a = (f1converted - 32) * 5 / 9;
            Console.WriteLine($"The celsius is {a.ToString("f2")}!");
            



        }
        

    }

}