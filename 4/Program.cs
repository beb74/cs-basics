using System;

class Program
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
        //Console.Write("Start: ");
        //int start = int.Parse(Console.ReadLine());
        //Console.Write("End: ");
        //int end = int.Parse(Console.ReadLine());

        //Console.WriteLine("Prime numbers:");

        //for (int number = start; number <= end; number++)
        //{
        //    if (number < 2) continue;

        //    bool prime = true;
        //    for (int i = 2; i < number; i++)
        //    {
        //        if (number % i == 0)
        //        {
        //            prime = false;
        //            break;
        //        }
        //    }

        //    if (prime)
        //    {
        //        Console.Write(number + " ");
        //    }
        //}


        #endregion
        #region Q16
        //Console.WriteLine("Enter the number");
        //int number = int.Parse(Console.ReadLine());
        //string boolean = " ";
        //while (number > 0)
        //{
        //    boolean = (number % 2) + boolean;
        //    number = number / 2;
        //}
        //Console.WriteLine(boolean);
        #endregion
        #region Q17
        Console.Write("Enter x1: ");
        int x1 = int.Parse(Console.ReadLine());
        Console.Write("Enter x2: ");
        int x2 = int.Parse(Console.ReadLine());
        Console.Write("Enter x3: ");
        int x3 = int.Parse(Console.ReadLine());
        Console.Write("Enter y1: ");
        int y1 = int.Parse(Console.ReadLine());
        Console.Write("Enter y2: ");
        int y2 = int.Parse(Console.ReadLine());
        Console.Write("Enter y3: ");
        int y3 = int.Parse(Console.ReadLine());
        if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
        {
            Console.WriteLine("these points lie on a single straight line.");
        }
        else
        {
            Console.WriteLine("these points don't lie on a single straight line.");
        }
        #endregion
        #region Q18
        Console.WriteLine("Enter The Hours");
        float hour = float.Parse(Console.ReadLine());
        if (hour >= 2 && hour <= 3)
        {
            Console.WriteLine("A worker's highly efficient");
        }
        else if (hour >= 2 && hour <= 3)
        {
            Console.WriteLine("A worker's highly efficient");
        }
        else if (hour >= 3 && hour <= 4)
        {
            Console.WriteLine("A worker's instructed to increase their speed.");
        }
        else if (hour >= 4 && hour <= 5)
        {
            Console.WriteLine("A worker's provided with training to enhance their speed.");
        }
        else if (hour > 5)
        {
            Console.WriteLine("A worker's leave the company. ");
        }
        else
        {
            Console.WriteLine("put the correct hour again");
        }
        #endregion


    }
}


    }




}
}