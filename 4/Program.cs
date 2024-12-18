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
        Console.WriteLine("Enter the Num");
        string x = Console.ReadLine();
        string reversed = "";
        for (int i = x.Length - 1; i >= 0; i--)
        {
            reversed = reversed + x[i];
        }
        int convert = int.Parse(reversed);
        Console.WriteLine($"The reversed number is {convert}");
        #endregion


    }
}