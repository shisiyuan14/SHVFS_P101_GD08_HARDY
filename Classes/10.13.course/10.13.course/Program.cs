namespace SHVFS_P101_GD08_Hardy
{
    public class program
    {
        public static void Main(string[] args)
        {
            // the boolean/ bool type
            //we learned mathematical operators last week */ +-%
            //relatinoal operators
            ////////
            //var firstNumber = 20;
            // var secondNumber = 30;
            // var evaluation = firstNumber > secondNumber;
            // bool altEvaluation = firstNumber > secondNumber;
            // Console.WriteLine($"Evaluation is : {evaluation}, as int it's {Convert.ToInt32(evaluation)}");
            // Console.ReadLine();
            //int numberToGuess = 80;
            //int guess;
            //while(true)
            //{
            //    Console.WriteLine("What number am I thinking of?");
            //    guess = Convert.ToInt32(Console.ReadLine());
            //    if (guess < numberToGuess)
            //    {
            //        Console.WriteLine("Your guess was too low!");

            //    }
            //    else if (guess > numberToGuess)
            //    {
            //        Console.WriteLine("Your guess was too high!");

            //    }
            //    else if (guess == numberToGuess)
            //    {
            //        Console.WriteLine("You got it, dude!");
            //    }
                
            //}
            var rand = new Random();
            var randomBoolA = Convert.ToBoolean(rand.Next(2));
            var randomBoolB = Convert.ToBoolean(rand.Next(2));
            var randomBoolC = Convert.ToBoolean(rand.Next(2));
            bool answer;
            Console.Clear();
            Console.WriteLine("Answer with true for TRUE, or False for FALSE");
            // Console.WriteLine($"A is {randomBool1}, B is {randomBool2}, C is {randomBool3}");
            Console.WriteLine("A is {0}, B is {1}, C is {2}", randomBoolA, randomBoolB, randomBoolC);
            //Console.WriteLine("A is " + randomBool1+ "B is" + randomBool2 + "C is" + randomBool3);

            Console.WriteLine("What is A && B?");
            answer = Convert.ToBoolean(Console.ReadLine());
            if (answer == (answer && randomBoolA) )
            {
                Console.WriteLine("CORRECT!");
            }
            else
            {
                Console.WriteLine("INCORRECT!");

            }
            Console.WriteLine("What is A || C?");
            answer = Convert.ToBoolean(Console.ReadLine());
            if (answer == (randomBoolA || randomBoolC))
            {
                Console.WriteLine("CORRECT!");
            }
            else
            {
                Console.WriteLine("INCORRECT!");

            }
            Console.WriteLine("What is A || C && B?");
            answer = Convert.ToBoolean(Console.ReadLine());
            if (answer == (randomBoolA || randomBoolC && randomBoolB))
            {
                Console.WriteLine("CORRECT!");
            }
            else
            {
                Console.WriteLine("INCORRECT!");

            }
            Console.WriteLine("What is A && C && B?");
            answer = Convert.ToBoolean(Console.ReadLine());
            if (answer == (randomBoolA && randomBoolC && randomBoolB))
            {
                Console.WriteLine("CORRECT!");
            }
            else
            {
                Console.WriteLine("INCORRECT!");

            }
            Console.WriteLine("What is A && B || B?");
            answer = Convert.ToBoolean(Console.ReadLine());
            if (answer == (randomBoolA && randomBoolB || randomBoolB))
            {
                Console.WriteLine("CORRECT!");
            }
            else
            {
                Console.WriteLine("INCORRECT!");

            }
            Console.WriteLine("What is A && (B || C)?");
            answer = Convert.ToBoolean(Console.ReadLine());
            if (answer == (randomBoolA && (randomBoolB || randomBoolC)))
            {
                Console.WriteLine("CORRECT!");
            }
            else
            {
                Console.WriteLine("INCORRECT!");

            }
        }

    }
}