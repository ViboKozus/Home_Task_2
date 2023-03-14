#pragma warning disable

Console.Clear ();
Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");

Console.WriteLine("Введите число от 1 до 7 ");
int N;
int.TryParse(Console.ReadLine ()!, out N);
if ( N < 0 || N > 8)
    {
    Console.WriteLine("ВЫ ВВЕЛИ НЕВЕРНОЕ ЧИСЛО!!");
    }
else 
    {   
    if (N == 7 || N == 6)
        Console.WriteLine("ВЫХОДНОЙ!!");
    else 
    {
        Console.WriteLine("Это не выходной(( ");
    }}       