using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int m = 0;
            int counter = 0;
            Console.WriteLine("Пожалуйста введите кол-во строк матрицы:");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста введите кол-во столбцов матрицы:");
            n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rand.Next(0, 3);
                }
            }
            Console.WriteLine("Матрица:");
            for (int i = 0; i < n; i++, Console.WriteLine())
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,3}", array[i, j]);
                }
            }
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (array[i, j] == 0)
                    {
                        counter++;
                        break;
                    }
                }
            }
            Console.WriteLine("Кол-во столбцов с нулевым элементом");
            Console.WriteLine(counter);
            int c = 1;
            int max = 0;
            int number = 0;
            for (int i = 0; i < n; i++)
            {
                c = 1;
                for (int j = 0; j < m - 1; j++)
                {
                    if (array[i, j] == array[i, j + 1])
                    {
                        c = c + 1;
                    }
                    else
                    {
                        c = 1;
                    }
                    if (max < c)
                    {
                        number = i;
                        max = c;
                    }
                }         
            }
            if (max == 1)
            {
                Console.WriteLine("Одинаковых цифр нет");
            }
            else
            {
                Console.WriteLine("Ответ:" + max);
            }
            Console.WriteLine("Номер строки:" + number);
        }
    }
}
