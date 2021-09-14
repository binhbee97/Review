using System;

namespace Tong2so
{
    class Tong
    {
        public static int Sum(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }

        public static void Main()
        {
                Console.Write("Nhap so hang thu nhat: ");
                    int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so hang thu hai: ");
                int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nTong hai so: {0} \n", Sum(n1, n2));

            Console.ReadKey();
        }   
    }
}
