using System;
using System.Security.Cryptography;

namespace SHVFS_P101_GD08_Q3_Hardy
{
    class program
    {
        public static void Main(string[] args)
        {
            string moodAnswer = "test";
            int i,age;
            float avgage,sumage=0;
            Console.WriteLine("HI! How are you today?");
            
            while (moodAnswer!="bad")
            {
                Console.WriteLine("The Answer is:");
                moodAnswer = Console.ReadLine();
                if (moodAnswer == "good")
                {
                    string choice = "0";
                    Console.WriteLine("Well! Welcome to my program experiment!\n");
                    while (choice != "3")
                    {
                        Console.WriteLine("Input 1 to start the calculator\nInput 2 to play a guessing game!\nInput 3 to log out!");
                        choice = Console.ReadLine();                      
                        if (choice == "1")
                        {
                            int personNumber;
                            Console.WriteLine("HI! I'm the Calculator. Please input the number of person!");
                            personNumber = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"OK!There're {personNumber} persons, please input the age of them now ! ");
                            for (i = 0; i < personNumber; i++)
                            {
                                Console.WriteLine($"Please input the {i + 1}st person's age!");
                                age = Convert.ToInt32(Console.ReadLine());
                                sumage += age;
                            }
                            avgage = sumage / personNumber;
                            Console.WriteLine($"OK!Here's the calculation outcome! The sum of the age is {sumage.ToString("f0")} and the average of the age is {avgage.ToString("f1")}");
                        }
                        else if (choice == "2")
                        {
                            Random answerNumber = new Random();
                            int guess = 0, count = 0;
                            Console.WriteLine("Oh! You want to play the guessing game!");
                            int guessAnswer = answerNumber.Next(100);
                            Console.WriteLine("OK! The secret number is born now! Please guess!\nGive you a hint! The number is positive whole number!");
                            while (guess != guessAnswer)
                            {
                                Console.WriteLine("Input your guess number!");
                                guess = Convert.ToInt32(Console.ReadLine());
                                count++;
                                if (guess > guessAnswer)
                                {
                                    Console.WriteLine("Your guess is too high! Try again!");
                                }
                                else if (guess < guessAnswer)
                                {
                                    Console.WriteLine("Your guess is too low! Try again!");
                                }
                                else
                                {
                                    Console.WriteLine($"Wow! You got it! You only use {count} times! Great!");
                                }
                            }
                        }
                        else if (choice != "1" && choice != "2")
                        {
                            Console.WriteLine("Unlegal input! Try again!");
                        }
                    }
                }
                else if (moodAnswer != "good" && moodAnswer != "bad")
                {
                    Console.WriteLine("Please input good or bad!");                 
                }
            }
            Console.WriteLine("I'm sorry to hear that. I'll give you some time! Let's do the experiment later!");


            






        }


    }





}