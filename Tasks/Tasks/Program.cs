namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string text = Console.ReadLine();
            //string txet = "";
            //{
            //    for (int i = text.Length - 1; i >= 0; i--)
            //        txet += text[i];

            //    Console.WriteLine(txet);
            //}

            //int month = Convert.ToInt32(Console.ReadLine());
            //int year = 0;
            //int months = 0;
            //{
            //    year = (month / 12);

            //    if (month % 12 < 12)
            //        months = month % 12;

            //    Console.WriteLine(year + " " + "Year(s)");
            //    Console.WriteLine(months + " " + "Month(s)");
            //}

            int num = Convert.ToInt32(Console.ReadLine());
            int i;
            int factorialofnum = 1;
            {
                for (i = 1; i <= num; i++)
                    factorialofnum *= i;

                Console.WriteLine("Factorial of num is equal to" + " " + factorialofnum);
            }


        }
    }
}
