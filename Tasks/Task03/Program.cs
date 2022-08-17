/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

string SqrtFind (int N)
{
    string result = "";
    for (int i = 1; i <= N; i++)
    {
        result += $"{Math.Pow(i, 3)} ";
    }
    return result;
}

Console.Write("Ввкдите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SqrtFind(N));