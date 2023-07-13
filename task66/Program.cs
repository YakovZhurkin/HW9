// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int N = Prompt("Введите чилсо N(Большее число) :");
int M = Prompt("Введите чилсо M(Меньшее число) :");
Console.WriteLine($"{Sum(M,N)}");




int Sum(int m, int n)
{ int res = 0;
    if(n == m)
    {
     return m;
    }
    res += n +Sum(m,n-1);
    return res;

}

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

