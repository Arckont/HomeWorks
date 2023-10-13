﻿/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

void showNumbers(int number)
{
    if (number ==1) 
    {
        Console.Write(number);
        return;
    }
    Console.Write(number+" ");
    showNumbers(number-1);
}
showNumbers(8);