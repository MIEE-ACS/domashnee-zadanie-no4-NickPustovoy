using System;

namespace Homework_4__IVT_21B_Nick_Pustovoy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите кол-во элементов массива:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rand.Next(0, 10);
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
            int even = 1;
            int b;
            for (int i = 0; i < n; i++)
            {
                b = i % 2;
                if (b == 0)
                {
                    if(a[i] == 0)
                    {
                        even = even + 0;
                    }
                    else
                    even = even * a[i];
                }
            }
            Console.WriteLine("Произведение чисел массива с чётным номером:");
            Console.WriteLine(even);
            int nu1 = 0;
            int nu2 = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == 0)
                {
                    nu1 = i;
                    break;
                }
            }
            for(int i = n - 1; i > 0 ; i--)
            {
                if (a[i] == 0)
                {
                    nu2 = i;
                    break;
                }
            }
            for(int i = nu1; i < nu2; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("Сумма между первым и последним нулевыми элементами:");
            Console.WriteLine(sum);
            int c = 0;
            int u = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] <= -1)
                {      
                    c = a[i];
                    a[i] = a[u];
                    a[u] = c;
                    u = u + 1;
                }
            }
        }
    }
}
