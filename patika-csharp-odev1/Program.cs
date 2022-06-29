using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_csharp_odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork1();
            HomeWork2();
            HomeWork3();
            HomeWork4();
            Console.ReadKey();
        }
        static void HomeWork1()
        {
            try
            {
                Console.WriteLine("Pozitif bir sayi giriniz.");
                int num = int.Parse(Console.ReadLine());
                while (num <= 0)
                {
                    Console.WriteLine("Pozitif bir sayi giriniz.");
                    num = int.Parse(Console.ReadLine());
                }
                int[] arr = new int[num];
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("Pozitif bir sayi giriniz.");
                    arr[i] = int.Parse(Console.ReadLine());
                    while (arr[i] <= 0)
                    {
                        Console.WriteLine("Pozitif bir sayi giriniz.");
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Girdiginiz Cift Sayilar.");
                foreach (int item in arr)
                {
                    if (item % 2 == 0)
                    {
                        Console.WriteLine(item + " ");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void HomeWork2()
        {
            try
            {
                Console.WriteLine("Pozitif iki sayi giriniz.");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                while (num1 <= 0 && num2 <= 0)
                {
                    Console.WriteLine("Pozitif iki sayi giriniz.");
                    num1 = int.Parse(Console.ReadLine());
                    num2 = int.Parse(Console.ReadLine());
                }
                int[] arr = new int[num1];
                for (int i = 0; i < num1; i++)
                {
                    Console.WriteLine("Pozitif bir sayi giriniz.");
                    arr[i] = int.Parse(Console.ReadLine());
                    while (arr[i] <= 0)
                    {
                        Console.WriteLine("Pozitif bir sayi giriniz.");
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Girdiginiz 2. sayiya bolunen sayilar.");
                foreach (int item in arr)
                {
                    //2. durumu 1 bir karsiliyor aslinda 
                    if (item % num2 == 0 || item == num2)
                    {
                        Console.WriteLine(item + " ");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void HomeWork3()
        {
            try
            {
                Console.WriteLine("Pozitif bir sayi giriniz.");
                int num = int.Parse(Console.ReadLine());
                while (num <= 0)
                {
                    Console.WriteLine("Pozitif bir sayi giriniz.");
                    num = int.Parse(Console.ReadLine());
                }
                string[] arr = new string[num];
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("kelime giriniz.");
                    arr[i] = Console.ReadLine().ToString();
                }
                Console.WriteLine("Girdiginiz kelimeler.");
                Array.Reverse(arr);
                foreach (string item in arr)
                {
                    Console.WriteLine(item + " ");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void HomeWork4()
        {
            try
            {
                Console.WriteLine("Bir cumle yaziniz.");
                string text = Console.ReadLine().ToString();
                string[] word = text.Split(' ');
                int letter = 0;
                foreach (string item in word)
                {
                    char[] ch = item.ToCharArray();
                    letter += ch.Length;
                }
                Console.WriteLine("Toplam karakter sayisi: " + text.Length);
                Console.WriteLine("Toplam kelime sayisi: " + word.Length);
                Console.WriteLine("Toplam harf sayisi: " + letter);

                Console.WriteLine("Ozel karakterler ihmal edilmistir. ");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
