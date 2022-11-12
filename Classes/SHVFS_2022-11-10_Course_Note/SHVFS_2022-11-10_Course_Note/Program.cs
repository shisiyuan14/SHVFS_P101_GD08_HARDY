using System;
using System.Security.Cryptography.X509Certificates;

namespace SHVFS_P101_C6_GD08_COURSE
{
    internal class program
    {
        public static void Main(string[] args)
        {
            //    PrintAThing("some funny things!");
            //    PrintAThing(13);
            //    PrintAthing("a thing", "another thing");
            //    Console.ReadLine();
            //    var pokemon1 = new Pokemon();
            //    pokemon1.EXP = 900;

            //    var pokemon2 = new Pokemon(100, 100, "HaHa");

            //    var pokemon3 = new Pokemon()
            //    {
            //        EXP = 9000,
            //        HP = 100
            //    };

            //    Console.WriteLine($"P1:{pokemon1.EXP} | PS:{pokemon2.EXP} | P3{pokemon3.EXP}");
            //    Console.ReadLine();

            //    var pokemon1 = new Pokemon(0, 100, "Cutie", "Devil");
            //    Console.WriteLine($"Pokemon1! | EXP: {pokemon1.EXP} | HP:{pokemon1.HP} | Name: {pokemon1.Name} | Secret Name > :) : {pokemon1.GetSecretName}");
            //}

            //overloads, access modifiers, overrides/virtual methods, inheritance, lists, dictinoaries, recursion, try/catch(error handling)
            //Methods/constructors can be overloaded, if the signatures are different
            //Overloads
            //public static void PrintAThing(string stringThing)
            //{
            //    Console.WriteLine($"The thing is: {stringThing}");
            //}

            //public static void PrintAThing(int anotherStringThing)
            //{
            //    Console.WriteLine($"The thing is: {anotherStringThing}");
            //}

            //public static void PrintAthing(string stringThing, string anotherStringThing)
            //{
            //    Console.WriteLine($"The thing is: {stringThing}, and the other thing is {anotherStringThing}");
            //}
            var pikachu1 = new Pikachu(0, 100, "Pikachu", "devil");
            pikachu1.DeclareForBattle();
            Console.ReadLine();
        }

        public class Pokemon
        {
            public int EXP;
            public int HP;
            public string Name;
            //Classes, fields, methods, etc, are IMPLICITLY PRIVATE in C#
            // Only instances of the class itself if it's static, can see their private memebers
            protected string SecretName;

            public Pokemon()
            {

            }

            public Pokemon(int eXP, int hp, string name, string secretName)
            {
                Console.WriteLine("Invoking the base Pokemon Constructor");
                EXP = eXP;
                HP = hp;
                Name = name;
                SecretName = secretName;
            }

            public string GetSecretName()
            {
                return SecretName;
            }

            //Overrides/virtual methods
            public virtual void DeclareForBattle()
            {
                Console.WriteLine("I AM readyyyyyyyyyyyyyyyyyy for battle!");


            }
        }

        // Inheritance
        // OO/Polymorphism
        // Pokemon is the base class of Pikachu, so pikachu gets allllllllllllll his memebers
        // We INVOKE the POKEMON CONSTRUCTOR with this base keyword
        public class Pikachu : Pokemon
        {
            public Pikachu(int exp, int hp, string name, string secretName) : base(exp, hp, name, secretName)
            {
                Console.WriteLine("Invoke Pikachu's constructor!");
            }

            public override void DeclareForBattle()
            {
                
                Console.WriteLine("I AMMMMMMMMMMMMMMMMM PIKACHUUUUUUUUUUUUUUUUUUUUUU!");
                base.DeclareForBattle();
            }

            public void PrintDetails()
            {
                //GetSecretName();
                Console.WriteLine($"Pokemon1! | EXP: {EXP} | HP:{HP} | Name: {Name} | Secret Name > :) : {SecretName}");

            }

        }

    }
}