using System;
// Масиви (одновимірний масив).
namespace Arrays
{
    class Program
    {
        static void PrintArray(string a, int[,] mas)
        {
            Console.WriteLine(a);
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                    Console.Write("{0} ", mas[i, j]);
                Console.WriteLine();
            }
        }
        static void Change(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                int sum = 0;
                //Console.WriteLine(mas.GetLength(0));
                for (int j = 0; j < mas.GetLength(1); j++)
                {

                    //Console.WriteLine(mas.GetLength(1));
                    if (mas[i, j] % 2 == 0)
                    {
                        sum += mas[i, j];

                    }
                }
                Console.WriteLine(" sum  = {0} of {1} row", sum, i + 1);
            }
        }

        static void intPut(int[,] mas)
        {
            for(int i = 0; i < mas.GetLength(0); i++)
            {
                for(int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
        }
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter an array:");
                int[,] MyArray = new int[3, 3];// { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9} };
                intPut(MyArray);
                PrintArray("вихідний масив:", MyArray);
                Change(MyArray);
                PrintArray("підсумковий масив", MyArray);
            }
            catch (FormatException)
            {
                Console.WriteLine("невірний формат вводу даних");
            }
            catch (OverflowException)
            {

                Console.WriteLine("переповнення");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("недостатньо пам'яті для створення нового об'єкта");
            }
            Console.ReadKey();
        }
    }
}
