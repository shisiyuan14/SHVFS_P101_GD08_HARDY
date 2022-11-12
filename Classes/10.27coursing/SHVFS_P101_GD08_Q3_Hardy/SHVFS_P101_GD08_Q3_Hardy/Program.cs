using System;
using System.Reflection.Metadata;

namespace SHVFS_P101_GD08_C5_Hardy
{
    class programm
    {

        public static void Main(string[] args)
        {
            #region
            //break
            //Terminates the closest enclosing loop

            //var input = "";
            ////This while(true) is very dangerous unless your name is chirs
            //while (true)
            //{
            //    Console.WriteLine("Type 'y' to quit");
            //    input = Console.ReadLine();
            //    if(input == "y")
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Did not exit the loop..");
            //}
            //Console.WriteLine("Quiting........");
            //Console.ReadLine();



            //continue
            //Proceeds to the next iteration of the loop
            //for(int i= 0; i<10;i++)
            //{
            //    if(i==4)
            //    {
            //     //break;
            //     continue;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            ////PrintHello();
            ////PrintHelloName("Hardy");
            ////var expArray = new int[] { 23, 345, 22, 1, 99, 9999, 2, 3 };
            ////var maxExp=GetMaxExp(expArray);
            ////Console.WriteLine($"Our max exp is :{maxExp}");
            ////var smileyFace = ReturnSmileyFace();
            ////Console.WriteLine(smileyFace);

            ////out modifiers MUST be set before ANYTHING is return
            //string input;
            //int radius;
            //double myCircumference;
            //double myArea;

            //do
            //{
            //    Console.WriteLine("Please enter a radius!");
            //    input = Console.ReadLine();

            //} while (!int.TryParse(input,out radius) || !TryCircle(radius, out myCircumference, out myArea));
            //Console.WriteLine($"Your circle has radius of {radius}, a cricumference of }{myCircumference}, and an area of {myArea}");

            //Console.ReadLine();




            //with ref modifiers we tell the compiler WE WILL set them
            //string input;
            //int radius;
            //double myCircumference = 0;
            //double myArea = 0;

            //do
            //{
            //    Console.WriteLine("Please enter a radius!");
            //    input = Console.ReadLine();

            //} while (!int.TryParse(input, out  radius) || !TryCircleRef(radius, ref  myCircumference , ref myArea));
            //Console.WriteLine($"Your circle has radius of {radius}, a cricumference of {myCircumference}, and an area of {myArea}");

            //Console.ReadLine();

            //string input;
            //int radius;
            //double myCircumference = 0;
            //double myArea = 0;

            //do
            //{
            //    Console.WriteLine("Please enter a radius!");
            //    input = Console.ReadLine();

            //} while (!int.TryParse(input, out radius) || !TryCircleOops(radius,  myCircumference,  myArea));
            //Console.WriteLine($"Your circle has radius of {radius}, a cricumference of {myCircumference}, and an area of {myArea}");

            //Console.ReadLine();
            #endregion

            //Classes sorta like templates, and they are use/reused to create OBJECTS
            //We use the new keyword to create an instance of a class
            //This run the classes' constructor -- which is public
            // It creates a version of it in memory -- an instance -- assigning it the variable name

            var pikachu1 = new Pokemon(20);
            var pikachu2 = pikachu1;
            pikachu2.HP = 9999;
            Console.WriteLine($"pikachu1's HP:{pikachu1.HP},pikachu2's HP:{pikachu2.HP}");

            var pokemonData1 = new PokemonData(40);
            var pokemonData2 = pokemonData1;
            pokemonData2.Exp = 4546876;
            Console.WriteLine($"pokimonData1's EXP: {pokemonData1.Exp} | pokemonData2's EXP: {pokemonData2.Exp}");
            Console.WriteLine($"OH! STATICS! I FORGOT! BaseType:{Pokemon.BaseType}");
            Console.WriteLine($"pikachu1's HP: {pikachu1.HP}");
            



        }

        //Class are reference types
        public class Pokemon
        {
            //Static fields are accessed on the class ITSELF, NOT INSTANCES of the class
            public static string BaseType = "Pokemon";
            private static string baseType = "Pokemon";


            //Non-static public field
            //It is public, so other classes can see/access it 
            //SINCE it's non-static, it is accessed on INSTANCES of the class
            public int HP;
            //The constructor is a special method used to create a version/object/instance
            //The constructor name and class name Must MATCH
            //It run ONCE, when the object is created(the'new' keyword is used)
            //There are NO return types with constructors
            //We can use them to assign fields/properties

            public Pokemon(int hp)
            {
                HP = hp;
            }
        }


        //structs are value types
        public struct PokemonData
        {
            public int Exp;
            public PokemonData(int exp)
            {
                Exp = exp;
            }
        }

        #region 
        //methods/functions are blocks of code that do thigns that we can reuse 
        //We've already been using them.. WriteLine, ReadLine, Clear, etc.
        //They can have inputs -- parameteres in the definition/arguments that are passed -- and outputs -- return
        //Methods can have as many parameters as we want to define
        //Usually more than a few, is a sign that your mehtod is doing too much...
        //Mehtods can only return ONE value

        //This method has No parameteres in this signature and returns nothing(void)
        //public static void PrintHello()
        //{
        //    Console.WriteLine("Hello");
        //}

        //This method has one parameter, a string called 'name', in its siganture and returns nothing
        //public static void PrintHelloName(string name)
        //{

        //    Console.WriteLine($"Hello,{name}");
        //}

        //This method has 1 parameter in its signature, and returns an int
        //public static int GetMaxExp(int[] intArray)
        //{
        //    var maximum = intArray[0];
        //    for(var i = 0;i< intArray.Length;i++)
        //    {
        //        if(i==0)
        //        {
        //            continue;
        //        }
        //        if (intArray[i]>maximum)
        //        {
        //            maximum = intArray[i];
        //        }
        //    }

        //    return maximum;

        //}

        //This mehtod has NO parameters and returns a string
        //public static string ReturnSmileyFace()
        //{
        //Console.WriteLine("returning a smiley face");

        //return ":)";

        //}


        //out/ref modifiers
        //out modifiers MUST be set beofre ANTTHING is returned
        //public static bool TryCircle(int radius, out double circumference, out double area)
        //{
        //    circumference = 0;
        //    area = 0;
        //    if(radius == 0 )
        //    {
        //        Console.WriteLine("You need to enter a radius for a circle, silly billy!");
        //        return false;
        //    }
        //    circumference = Math.PI * radius * 2;
        //    area = Math.PI * Math.Pow(radius, 2);
        //    return true;

        //}


        //if we use ref modifiers we don't have to set           We tell the computer that we will set it later
        //public static bool TryCircleRef(int radius, ref double circumference, ref double area)
        //{

        //    if (radius == 0)
        //    {
        //        Console.WriteLine("You need to enter a radius for a circle, silly billy!");
        //        return false;
        //    }
        //    circumference = Math.PI * radius * 2;
        //    area = Math.PI * Math.Pow(radius, 2);
        //    return true;
        //}



        //public static bool TryCircleOops(int radius, double circumference,  double area)
        //{

        //    if (radius == 0)
        //    {
        //        Console.WriteLine("You need to enter a radius for a circle, silly billy!");
        //        return false;
        //    }
        //    circumference = Math.PI * radius * 2;
        //    area = Math.PI * Math.Pow(radius, 2);
        //    return true;
        //}


        //public static void WheresI()
        //{
        //    int i;

        //}
        #endregion
    }





}