/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

// int A, B;
// Console.Write("Введите число A: ");
// A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// B = Convert.ToInt32(Console.ReadLine());
// int result = A;
// for (int i = 2; i <= B; i++)
// {
//     result *= A;
// }
// Console.WriteLine($"{A}^{B} = {result}");

/* Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
 
//  Console.WriteLine("Введите число: ");
//  int num = Convert.ToInt32(Console.ReadLine());
//  int result = 0;
// while (num != 0)
// {
//     result += num % 10;
//     num /= 10;
// }

// Console.WriteLine($"Сумма цифр в числе = {result}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Console.Write("Введите любое число (A): ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num];
// for (int i = 0; i < num; i++)
// {
//     array[i] = new Random().Next(num+1);
//     Console.Write(array[i] + "; ");
// }
// Console.WriteLine();