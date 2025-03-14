namespace Tasks
{
    internal class Program
    {
        static void Main()
        {
            yearandmonth(25);
        }
        static void yearandmonth(int monthz)
        {
            int month = monthz;
            int years = month / 12;
            int months = (month - years * 12);

            Console.WriteLine(years + " " + "year(s)");
            Console.WriteLine(months +" " + "month(s)");

        }
    }
}


//        {

//            Factorial(5);
//        }
//        static void Factorial(int num)
//        {
//            int nums = num;
//            int i;
//            int factorial = 1;
//                for (i = 1; i <= nums; i++)
//            {
//                    factorial *= i;
//            }
//                Console.WriteLine(factorial);
//        }


//int month = Convert.ToInt32(Console.ReadLine());
//        int year = 0;
//        int months = 0;
//{
//    year = (month / 12);

//            if (month % 12 < 12)
//                months = month % 12;

//            Console.WriteLine(year + " " + "Year(s)");
//            Console.WriteLine(months + " " + "Month(s)");
//        }
//}
//}