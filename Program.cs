﻿// Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.

string[] strArray = { "Size", "5", "GitHab", "=(","привет", "25" };

PrintArray();
Console.WriteLine("Массив из строк, длинна которых меньше либо равна 3 символа");
SortThreeElrments();

//  Вывод исходного массива.
void PrintArray()
{
    for (int i = 0; i < strArray.Length; i++)
    {
        Console.Write(strArray[i] + " ");
    }
    Console.WriteLine();
}
// Нахождение масива строк, длинна которых меньше либо равна 3. Вывод искомого массива. 
void SortThreeElrments()
{
    for (int i = 0; i < strArray.Length; i++)
    {
        if (strArray[i].Length <=3) 
        Console.Write(strArray[i] + " ");
    }
    Console.WriteLine();
}
// Test 2
// Size 5 GitHab =( привет 25 
// Массив из строк, длинна которых меньше либо равна 3 символа
// 5 =( 25 