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
int firstNumber = ReadIn("Введите первое число");
int secondNumber = ReadIn("Введите второе число");
if (firstNumber < 1 || secondNumber < 1) { Console.WriteLine("Оба числа долны быть натуральными."); } // Проверка числа на натуральность
else if (secondNumber > firstNumber) { Console.WriteLine($"Сумма чисел в диапазоне от {secondNumber} до {firstNumber} равна {SumOfNaturalNumbers(secondNumber, firstNumber)}");} //Если второе число больше первого
else { Console.WriteLine($"Сумма чисел в диапазоне от {firstNumber} до {secondNumber} равна {SumOfNaturalNumbers(firstNumber, secondNumber)}");} //Если первое больше ворого

