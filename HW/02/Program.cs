// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadIn(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    return int.Parse(a);
}

int SumOfNaturalNumbers(int min, int max)
{
    if (max <min){return 0;}
    return SumOfNaturalNumbers(min+1, max)+min;

}
int sum = SumOfNaturalNumbers(ReadIn("от"), ReadIn("до"));
if (sum == 0) {Console.WriteLine("Число \"До\" должно быть больше числа \"От\"." );}
else {Console.WriteLine(sum);}

    