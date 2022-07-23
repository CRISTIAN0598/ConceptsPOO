using System;

namespace POOConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POO Concepts!");
            Console.WriteLine("==============");


            try
            {
                Console.WriteLine(new Date(2024,2,29));
                Console.WriteLine(new Date(1974, 11, 31));
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
