#pragma warning disable

Console.Clear ();
Console.WriteLine ("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");

int N; 
Console.WriteLine($"введите число N"); 
int.TryParse(Console.ReadLine ()!, out N); 
 

int absN = N; 
if (N < 0) 
    absN = -1 * N; 
 
int result = absN; 
 

if (result > 99)  
{ 

    while (result > 999)  
    { 
        result = result / 10; 
    } 
    
    result = result % 10; 
 
    Console.WriteLine($"3-я цифра в {N} -- это {result}"); 
} 
else  
{ 
    Console.WriteLine($"в числе {N} меньше 3-х циф"); 
}
