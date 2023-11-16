// Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int ReadIn(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    return int.Parse(a);
}

void PrintNaturalNumbers(int min, int max)
{
    if (max <min){return;}
    PrintNaturalNumbers(min, max-1);
    Console.Write($"{max}\t");
}
PrintNaturalNumbers(ReadIn("от"), ReadIn("до"));