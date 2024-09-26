using System;

namespace ProjectStudio
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        static void Jack()
        {
            int age, days, hours;
            string temp;

            Console.Write("What is your age? ");
            temp = Console.ReadLine();
            age = Convert.ToInt32(temp);
            days = age * 365;
            hours = days * 24;
            Console.WriteLine($" If you are {age} then the total days you have been alive is {days} and the total hours is {hours} ");
            Console.ReadLine();
        }
        static void Mohammad()
        {
            Console.WriteLine("hello world from Mohamamd");
            string temp;
            int age;
            char answer;
            Random rand = new Random();
            Console.WriteLine("how old are you?");
            temp = Console.ReadLine();
            age = Convert.ToInt32(temp);
            if (age < 18)
            {
                Console.WriteLine("goodbye you're too young to play");
                Console.ReadLine();

            }
            else
            {
                do
                {


                    int total = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        int card = rand.Next(1, 14);
                        switch (card)
                        {
                            case 1:
                                total += 20;
                                break;
                            case 11:
                            case 12:
                            case 13:
                                total += 10;
                                break;
                            default:
                                total -= card;
                                break;


                        }
                        Console.WriteLine($"your card ={card} your total={total}");
                        Console.ReadLine();
                    }
                    Console.WriteLine("would you like to play again 'y' or 'n'");
                    string ans = Console.ReadLine();
                    answer = Convert.ToChar(ans);


                } while (answer == 'y');

            }
        static void Jacob()
        {
            Random rand = new Random();
            int[] lotto = new int[20];
            int temp, count = 0;

            for (int i = 0; i < lotto.Length; i++)
            {
                temp = rand.Next(lotto.Length);
                while (count < i)
                {

                    if (lotto[count] == temp)
                    {
                        temp = rand.Next(lotto.Length);
                        count = 0;
                    }
                    else
                    {
                        count++;
                    }

                }
                count = 0;
                lotto[i] = temp;

            }
            for (int i = 0; i < lotto.Length; i++)
            {
                Console.WriteLine(lotto[i]);
            }
            Console.ReadLine();

        }
    }
}
