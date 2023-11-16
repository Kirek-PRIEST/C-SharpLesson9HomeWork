// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int ReadIn(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    return int.Parse(a);
}

void PrintNaturalNumbers(int min, int max)
{
    if (max <min){return;}
    PrintNaturalNumbers(min, max-2);
    Console.Write($"{max}\t");
}
PrintNaturalNumbers(ReadIn("от"), ReadIn("до"));