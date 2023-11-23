/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int ReadInt(string text)
{
Console.WriteLine(text);
return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int Akkerman (int m, int n)
{
    if (m==0)
    {
        return n+1;
    }
    else if ((m!=0)&& (n==0))
    {
        return Akkerman(m-1,1);
    }
    else
    {
        return Akkerman(m-1, Akkerman(m,n-1));
    }
}

//========================
int M = ReadInt("Введите число M:");
int N = ReadInt("Введите число N:");
System.Console.WriteLine($"A({M},{N}) = {Akkerman(M,N)}");
