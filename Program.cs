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
