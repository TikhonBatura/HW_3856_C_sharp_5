internal class Program
{
    private static void Main(string[] args)
    {
        int EnterNumber(string number) // функция для ввода целочисленного значения пользователем
        {
            Console.Write($"Enter {number}: "); 
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }


        int[] CreateArray(int size, int minValue, int maxValue) // функция по заполнению массива целочисленными значениями
        {
            int[] res = new int[size];

            for (int i = 0; i < size; i++)
            {
                res[i] = new Random().Next(minValue, maxValue + 1);
            }
            return res;
        }


        // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
        // Напишите программу, которая покажет количество чётных чисел в массиве.

        // [345, 897, 568, 234] -> 2


        Console.WriteLine();
        Console.WriteLine("Задача 34");
        Console.WriteLine();

        int[] numbers = CreateArray(5, 100, 999);
        int Result = 0;

        Console.WriteLine(string.Join(" ", numbers));
        Console.WriteLine();

        foreach (int i in numbers)
        {
            if (i % 2 == 0)
            {
                Result++;
            }
        }

        Console.WriteLine($"Current array have {Result} even numbers");

        Console.WriteLine();
        Console.WriteLine("************");


        // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
        // Найдите сумму элементов, стоящих на нечётных позициях.

        // [3, 7, 23, 12] -> 19

        // [-4, -6, 89, 6] -> 0


        Console.WriteLine();
        Console.WriteLine("Задача 36");
        Console.WriteLine();

        int ArraySize = EnterNumber("Enter array size");
        int minValue = EnterNumber("Enter minValue for array");
        int maxValue = EnterNumber("Enter maxValue for array");
        Result = 0;
        Console.WriteLine();

        numbers = CreateArray(ArraySize, minValue, maxValue);

        Console.WriteLine(string.Join(" ", numbers));
        Console.WriteLine();

        for (int i = 1; i < numbers.Length; i += 2)
        {
            Result = Result + numbers[i];
        }
        Console.WriteLine($"sum of odd positions = {Result}");
        Console.WriteLine();
        Console.WriteLine("************");

        // Задача 38: Задайте массив вещественных чисел. 
        // Найдите разницу между максимальным и минимальным элементов массива.

        // [3 7 22 2 78] -> 76

        double EnterDoubleNumber(string number) // функция для ввода вещественного значения пользователем
        {
            Console.Write($"Enter {number}: ");
            double num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        double[] CreateDoubleArray(int size, double minValue, double maxValue) // функция по заполнению массива вещественными числами
        {
            double[] res = new double[size];

            for (int i = 0; i < size; i++)
            {
                res[i] = Convert.ToDouble(new Random().Next((int)minValue, (int)(maxValue + 1)) / 100.0);
            }
            return res;
        }

        double findMin (double[] DoubleArray) // функция по нахождению минимального числа в массиве
        {
            double Min = DoubleArray[0];
            
            for (int i = 0; i < DoubleArray.Length; i++)
            {    
                if (DoubleArray[i] < Min)
                {
                    Min = DoubleArray[i];
                }
            }
            return Min;
        }

        double findMax (double[] DoubleArray) // функция по нахождению минимального числа в массиве
        {
            double Max = DoubleArray[0];
            for (int i = 0; i < DoubleArray.Length; i++)
            {
                if (DoubleArray[i] > Max)
                {
                    Max = DoubleArray[i];
                }
            }
            return Max;
        }

        Console.WriteLine();
        Console.WriteLine("Задача 38");
        Console.WriteLine();

        double ArraySize38 = EnterDoubleNumber("Enter array size");
        double minValue38 = EnterDoubleNumber("Enter minValue for array");
        double maxValue38 = EnterDoubleNumber("Enter maxValue for array");
        
        Console.WriteLine();

        double[] numbers38 = CreateDoubleArray(ArraySize, minValue, maxValue);

        Console.WriteLine(string.Join(" ", numbers38));
        Console.WriteLine();
        double minValue2 = findMin(numbers38);
        double maxValue2 = findMax(numbers38);

        Console.WriteLine($"Diference between MAX element {maxValue2} and min {minValue2} = {maxValue2-minValue2}");
        Console.WriteLine();
        Console.WriteLine("************");
    }
}