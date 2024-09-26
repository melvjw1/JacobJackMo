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
            Console.WriteLine("This is Jack");
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
