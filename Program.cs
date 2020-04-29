using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello! What's your name?");

            string name = Console.ReadLine();

            while (name == "")
            {
                Console.WriteLine("Please input your name");
                name = Console.ReadLine();
                if (name != "")
                {
                    break;
                }
            }
            
            Console.WriteLine("\nHello " + name);
            Console.WriteLine("How many questions do you want to do?");

            string qs1 = Console.ReadLine();
            int qs2;
            bool check1 = int.TryParse(qs1, out qs2);
            
            while (check1 == false)
            {
                Console.WriteLine("Please enter a number");
                qs1 = Console.ReadLine();
                check1 = int.TryParse(qs1, out qs2);
                if (check1 == true)
                {
                    break;
                }
            }

            Console.WriteLine("\nPress enter to start\n");
            
            Console.ReadLine();

            int score = 0;

            for (int qsDone = 0; qsDone < qs2;)
            {

                Random number1 = new Random();

                int num1 = number1.Next(1, 11);
                int num2 = number1.Next(1, 11);

                Console.WriteLine(num1 + " x " + num2);
                string ans1 = Console.ReadLine();
                int ans2;
                int.TryParse(ans1, out ans2);

                int compliment1 = number1.Next(1, 7);
                int negcompliment1 = number1.Next(1, 7);

                    if (ans2 == num1 * num2)
                    {
                        score += 1;
                        qsDone += 1;

                        if (compliment1 == 1)
                        {
                            Console.WriteLine("Well done " + name);
                        }
                        else if (compliment1 == 2)
                        {
                            Console.WriteLine("Spot on " + name);
                        }
                        else if (compliment1 == 3)
                        {
                            Console.WriteLine("You're doing well " + name);
                        }
                        else if (compliment1 == 4)
                        {
                            Console.WriteLine("You're smashing it " + name);
                        }
                        else if (compliment1 == 5)
                        {
                            Console.WriteLine("That's incredible " + name);
                        }
                        else if (compliment1 == 6)
                        {
                            Console.WriteLine("Keep up the good work " + name);
                        }

                        Console.WriteLine("Your score is " + score + "\n");
                    }
                    else
                    {
                        qsDone += 1;

                        if (negcompliment1 == 1)
                        {
                            Console.WriteLine("Better luck next time " + name);
                        }
                        else if (negcompliment1 == 2)
                        {
                            Console.WriteLine("Nearly there " + name);
                        }
                        else if (negcompliment1 == 3)
                        {
                            Console.WriteLine("getting close " + name);
                        }
                        else if (negcompliment1 == 4)
                        {
                            Console.WriteLine("You're approaching it " + name);
                        }
                        else if (negcompliment1 == 5)
                        {
                            Console.WriteLine("" + name);
                        }
                        else if (negcompliment1 == 6)
                        {
                            Console.WriteLine("" + name);
                        }

                        Console.WriteLine("Your score is " + score + "\n");
                    }
            }

            Console.ReadLine();
        }
    }
}
