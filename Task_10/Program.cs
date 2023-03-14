#pragma warning disable

Console.Clear ();
Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");

Console.WriteLine("Введите трёхзначное число N = ");
int N;
int b = 0;

int.TryParse(Console.ReadLine()!, out N);
int M = N;
while(0!= N)          // cчетчик кол-во десятков 
    {
        N= N/10;
        b = b + 1;
    }
if (b == 3 )            
    {
    int N3 = M / 10;
    int N2 = N3 % 10;
    Console.WriteLine($"{M} -> {N2}" );
    }
else    
    {   
    Console.WriteLine("ВЫ ВВЕЛИ НЕВЕРНОЕ ЧИСЛО!!");
    }
   