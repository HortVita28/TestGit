using System;

namespace Test
{
    class TestCharp
    {
        
        static void Main(string[] args)
        {
            /*
            //Console.WriteLine("Hello World!");
            int num1, rem1;
            Console.Write("\n\n");
            Console.Write("Kiem tra chan le trong c#");
            Console.Write("---------------------------");
            Console.Write("\n\n");
            Console.Write("Nhap mot so nguyen bat ky ");
            num1 = Int32.Parse(Console.ReadLine());
            rem1 = num1 % 2;
            if(rem1 == 0)
            {
                Console.WriteLine("{0} la so chan .\n", +num1);

            }
            else
            {
                Console.WriteLine("{0} la so le\n", +num1);
            }
            Console.ReadLine();

            */
            int chk_year;
            Console.WriteLine("kIEM TRA NAWM NHUAN TRONG");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\nHay nhap nawm bats ky");

            chk_year = Int32.Parse(Console.ReadLine());

            if ((chk_year % 400) == 0)
                Console.WriteLine("{0} la nam nhuan.\n", chk_year);
            else if ((chk_year % 100) == 0)
                Console.WriteLine("{0} khong phai la nam nhuan.\n", chk_year);
            else if ((chk_year % 4) == 0)
                Console.WriteLine("{0} la nam nhuan.\n", chk_year);
            else
                Console.WriteLine("{0} khong phai la nam nhuan.\n", chk_year);

            Console.ReadKey();


        }
    }
}
