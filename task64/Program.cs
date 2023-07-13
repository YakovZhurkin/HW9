// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int N = Prompt("Введите чилсо N :");
Console.WriteLine($"{Range(N)}");


string Range(int n)
{
    if(n == 1)
    {
        return "1";
    }
    return Range(n-1)+ ", " + n;
}

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}


// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

// int N = Prompt("Введите большее чилсо N :");
// int M = Prompt("Введите меньшнн чилсо M :");
// Console.WriteLine($"{Range(M,N)}");


// string Range(int m,int n)
// {
//     if(n == m)
//     {
//         return m.ToString();
//     }
//     return Range(M,n-1)+ ", " + n;
// }

// int Prompt(string message)
// {
//     Console.Write(message);
//     int number = int.Parse(Console.ReadLine()!);
//     return number;
// }



