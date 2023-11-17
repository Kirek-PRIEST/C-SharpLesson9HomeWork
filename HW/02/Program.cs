// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadIn(string msg)// ввод числа
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    return int.Parse(a);
}

int SumOfNaturalNumbers(int min, int max) //Вычисление суммы в заданном диапазоне
{
    if (max < min) { return 0; }
    return SumOfNaturalNumbers(min + 1, max) + min;

}
int M = ReadIn("Введите первое число");
int N = ReadIn("Введите второе число");
if (M < 1 || N < 1) { Console.WriteLine("Оба числа долны быть натуральными."); } // Проверка числа на натуральность
else if (M > N) { Console.WriteLine($"Сумма чисел в диапазоне от {N} до {M} равна {SumOfNaturalNumbers(N, M)}");} //Если второе число больше первого
else { Console.WriteLine($"Сумма чисел в диапазоне от {M} до {N} равна {SumOfNaturalNumbers(M, N)}");} //Если первое больше ворого

