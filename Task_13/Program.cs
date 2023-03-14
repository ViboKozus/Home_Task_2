#pragma warning disable

Console.Clear ();
Console.WriteLine ("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");

int N; 
Console.WriteLine($"введите число N"); 
int.TryParse(Console.ReadLine()!, out N); 
 

int modN = N; // модуль N если оно меньше 1, то просто умножим его на -1 
if (N < 0) 
    modN = -1 * N; 
  
if (modN > 99) // в положительном числе есть 3-я цифра, если оно больше 99 
{ 
    int result = (modN / 100) % 10; 
    Console.WriteLine($"3-я цифра в {N} -- это {result}"); 
} 
else 
    Console.WriteLine($"в числе {N} меньше 3-х циф");