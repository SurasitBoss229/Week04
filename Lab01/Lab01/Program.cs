using System;


namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Name : ");
                string val1 = Console.ReadLine();
                Console.Write("Lastname : ");
                string val2 = Console.ReadLine();
                Console.Write("ID : ");
                double val3 = Convert.ToInt32(Console.ReadLine());
                Console.Write("GPA : ");
                double val4 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
            }
        }
    }
}
