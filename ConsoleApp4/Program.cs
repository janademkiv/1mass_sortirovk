using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[3];
            Console.WriteLine("Введите 3 числа");
            inPut(mass);
            Console.WriteLine("Сумма положительных чисел");
            Sum(mass);
            massString(mass);
            Console.WriteLine();
            Console.WriteLine("Сортировка массива");
            sortMass(mass);
            Console.WriteLine("Макс индекс массива");
            //searchIndex(mass);
            Console.WriteLine(IndexOfMaxElement(mass,3));
            /*в одном методе 
            //заполнение массива с клав в методе inPut 
            for (int i = 0; i < mass.Length; i++) 
            { 
            int x = int.Parse(Console.ReadLine()); 
            mass[i] = x; 

            } 

            //Сумма положительных чисел 
            int sum = 0; 
            for (int l = 0; l < mass.Length; l++) 
            { 
            int a = mass[l]; 
            if (a > 0) 
            { 
            sum += mass[l]; 
            } 
            } 
            Console.WriteLine("Сумма массива" + sum); 

            //Показать элемент масива 
            foreach (int e in mass) 
            { 

            Console.WriteLine("Эллементы массива" + e); 
            } 
            */
            Console.ReadKey();
        }

        //заполнение массива с клав 
        static void inPut(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int x = int.Parse(Console.ReadLine());
                arr[i] = x;
            }

        }
        //Сумма положительных чисел int 
        static int Sum(int[] arr)
        {
            int sum = 0;
            for (int l = 0; l < arr.Length; l++)
            {
                int a = arr[l];
                if (a > 0)
                {
                    sum += arr[l];
                }
            }
            Console.WriteLine(sum);

            return sum;
        }


        //вывод массива в одну строку
        static void massString(int[] arr)
        {
            Console.Write("Вывод массива в одну строку: ");
            for (int i = 0; i < arr.Length; i++)
            {
                //int x = int.Parse(Console.ReadLine());
                Console.Write(arr[i]);
            }

        }

        //поиск индекса макс элемента
        //static void searchIndex(int[] arr)
        //{
        //    Console.Write("Вывод массива в одну строку: ");
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        //int x = int.Parse(Console.ReadLine());
        //        Console.Write(arr[i]);
        //    }
        static void sortMass(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                //поиск минимального числа
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                //обмен элементов
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
                Console.WriteLine(temp);
            }
        }

        //поиск индекса мак эл
        //static void searchIndex(int[] arr)
        //{

        //    //for (int i = 0; i < arr.Length; i++)
        //    //{

        //    //    int min = i;
        //    //    for (int j = i + 1; j < arr.Length; j++)
        //    //    {
        //    //        if (arr[j] < arr[min])
        //    //        {
        //    //            min = j;
        //    //        }
        //    //    }
        //    //}

        //    //if (arr[]) { }
        //    //int sum = 0;
        //    //for (int l = 0; l < arr.Length; l++)
        //    //{
        //    //    int a = arr[l];
        //    //    int y = arr[l];
        //    //    if (a > y)
        //    //    {
        //    //        Console.WriteLine( arr[l] );/* sum += arr[l];*/
        //    //    }
        //    //}

        //    int max = arr[0];
        //    int maxIndex = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {

        //        if (max < arr[i])
        //        {
        //            max = arr[i];
        //            maxIndex = i;
        //        }
        //        Console.WriteLine("Поиск максимального", maxIndex);
        //}


        static int IndexOfMaxElement(int[] a, int size)
        {
            int max = a[0];
            int index = 0;
            for (int i = 0; i < size; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    index = i;
                }
            }
            return index;
        }
    }


}

            

