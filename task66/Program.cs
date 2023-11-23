/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int ReadInt(string text)
{
Console.WriteLine(text);
return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}
int SumOfNumbers(int startNumber, int endNumber)
{
    while (startNumber < endNumber)
    {
        return startNumber+SumOfNumbers(startNumber+1,endNumber);
    }
    return startNumber;
}

int M = ReadInt("Введите число M:");
int N = ReadInt("Введите число N:");



Console.WriteLine(SumOfNumbers(M,N));