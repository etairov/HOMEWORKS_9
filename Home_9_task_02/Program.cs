/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
//-------------------------

Console.Write("m = ");
int m = int.Parse(Console.ReadLine());

Console.Write("n = ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(NumberRec(m, n));
Console.WriteLine($"Сумма Элементов = {SumNumbers(m, n)}");
Console.ReadLine();

string NumberRec(int m, int n)
{
    if (m <= n) return $"{m} " + NumberRec(m + 1, n);
    else return String.Empty;
}

static int SumNumbers(int m, int n)
{
    if (m == 0) return (n * (n + 1)) / 2;            
    if (n == 0) return (m * (m + 1)) / 2;       
    if (m == n) return m;                       
    if (m < n) return n + SumNumbers(m, n - 1); 
    else return n + SumNumbers(m, n + 1);            
}
