//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
void PrintNumber(int n,int a)
{
    if (n==a-1)
    {
      return;
    }
    PrintNumber(n,a+1);
    Console.Write(a+" ") ;
}
Console.WriteLine("Введите число : ") ;
int n = Convert.ToInt32(Console.ReadLine());
int a=1;
PrintNumber(n,a);

