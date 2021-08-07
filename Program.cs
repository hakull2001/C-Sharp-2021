using System;
namespace Method
{
    class Program
    {
        public static void input(string[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }
        }
        public static void process(string[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i].Length > 3)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so ptu mang: ");
            int n = int.Parse(Console.ReadLine());
            string[] str = new String[n];
            input(str, n);
            process(str, n);
        }
    }
}