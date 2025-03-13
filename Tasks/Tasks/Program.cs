namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string txet = "";
            {
                for (int i = text.Length - 1; i >= 0; i--)
                    txet += text[i];

                Console.WriteLine(txet);
            }
        }
    }
}
