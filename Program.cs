// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void ShowArray(int[] array)
// {
//     Console.Write("Array is: ");
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
         
//     Console.WriteLine(" :) \n ");
// }

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// void SumOfEvenNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] % 2 == 0)
//     count++;      
//     Console.WriteLine($"Sum of even elements is: {count}");    
// }
//-------------------------------------------------------------
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// void SumOfOddPositions(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i+=2)  // i = 0 Если чётные индексы i+=2
//         sum += array[i];        //sum = sum + array[i];     
//      Console.WriteLine($"Total digits is {array.Length}. Sum of odd positions is: {sum}");    
// }
// //-------------------------------------------------------------
// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(n, min, max);
// ShowArray(myArray);
//Задача 34:SumOfEvenNumbers(myArray); 
//Задача 36:SumOfOddPositions(myArray); 



//-------------------------------------------------------------
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateDoubleRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    {
        int numInt = new Random().Next(minValue, maxValue);
        double numDouble = new Random().NextDouble();
    
        array[i] = Math.Round(Convert.ToDouble(numInt) + numDouble, 2);
    }
    return array;
}

void ShowDoubleArray(double[] array)
{
    Console.Write("Array is: ");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine(" :) \n ");
}

double DifferenceOfMinMax(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(max < array[i])
            {
                max = array[i];
            }
        if(min > array[i])
            {
            min = array[i];
            }
    }
    double difference = max - min;
    return difference;
}

Console.Write("Input number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input an integer min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input an integer max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateDoubleRandomArray(n, min, max);

ShowDoubleArray(myArray);
Console.WriteLine($"Difference of min max elements of array is: {DifferenceOfMinMax(myArray)}");