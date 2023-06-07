// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine ($"введите любое число");
int num = Convert.ToInt32(Console.ReadLine());
void reverse (int num)
{
    if (num > 0)
    {
        System.Console.Write(num + "  ");
        reverse (num -1);            
    }
}
reverse(num);


// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int summa(int m, int n)
{
if (m==n)
    {
        return n;        
    }
else return m + summa(m + 1, n);
}
// Console.Write($"{m} , {n} -> сумма натуральных элементов между данными числами {summa(m,n)}");

Console.Write("Введите значение M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N:");
int n = Convert.ToInt32(Console.ReadLine());

int akkerman(int m, int n)
{
if (m == 0) 
    {
        return n + 1;
    }
else if (n == 0) return akkerman(m - 1, 1);
else return akkerman(m - 1, akkerman(m, n - 1));
}

Console.Write($"Функция Аккермана равно {akkerman(m, n)} ");