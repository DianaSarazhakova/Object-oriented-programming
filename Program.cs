using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
                int[,] Mass = new int[5, 5];
                int[] P = new int[4];
                int[] F = new int[4];
                int i = 0;
                int j = 0;
                int m;
                int b;
                for (i = 0; i < 5; i = i + 1)
                {
                    m = i + 1;
                    Console.WriteLine("Участник номер " + m + ":");
                    for (j = 0; j < 5; j = j + 1)
                    {
                        b = j + 1;
                        Console.Write("Вид спорта " + b + ": ");
                        Mass[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                int min = 25;
                int sum = 0;
                int k = 0;
                int n = 0;
                m = 0;
                for (i = 0; i < 5; i = i + 1)
                {
                    for (j = 0; j < 5; j = j + 1)
                    {
                        sum = Mass[i, j] + sum;
                    }
                    m = i + 1;
                    Console.WriteLine("Баллы участника"+m+": "+ sum);
                    if (sum < min)
                    {
                        min = sum;
                        k = i + 1;
                    }
                    else if (sum == min)
                    {
                        P[n] = sum;
                        F[n] = i + 1;
                        n = n + 1;
                    }
                    sum = 0;
                }
                    Console.WriteLine("Победил участник номер " + k);
                    for (i = 0; i < 4; i = i + 1)
                    {
                        if (P[i] == min)
                        { Console.WriteLine("Победил участник номер " + F[i]); }
                    }
            Console.WriteLine("Нажмите на enter, чтобы завершить работу с программой");
            Console.ReadLine();
                
            
        }
    }
}
