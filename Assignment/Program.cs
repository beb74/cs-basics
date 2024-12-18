namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q13
            //Console.WriteLine("Enter the word");
            //string x = Console.ReadLine();
            //string reversed = "";
            //for (int i = x.Length - 1; i >= 0; i--)
            //{
            //    reversed += x[i];
            //}
            //Console.WriteLine($"revesed word is:{reversed} ");
            #endregion
            #region Q14
            //Console.WriteLine("Enter the Num");
            //string x = Console.ReadLine();
            //string reversed = "";
            //for (int i = x.Length - 1; i >= 0; i--)
            //{
            //    reversed = reversed + x[i];
            //}
            //int convert = int.Parse(reversed);
            //Console.WriteLine($"The reversed number is {convert}");
            #endregion
            #region Q15
            Console.Write("Start: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("End: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("Prime numbers:");

            for (int number = start; number <= end; number++)
            {
                if (number < 2) continue;

                bool prime = true;
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime)
                {
                    Console.Write(number + " ");
                }
            }


            #endregion
        }



    
}
}