// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int ReadIn(string msg) //Ввод числа
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    return int.Parse(a);
}

void PrintNaturalNumbers(int min, int max) //Вывод положительных чисел в заданном диапазоне
{
    if (max < min) { return; }
    Console.Write($"{min}\t");
    PrintNaturalNumbers(min + 2, max);
}
int minNumber = ReadIn("от");
int maxNumber = ReadIn("до");
if (maxNumber == 0 || maxNumber == 0 ){Console.WriteLine("Минимальное число должно быть больше 0.");} // Если введён 0
else if (minNumber < 0) { Console.WriteLine("Число должно быть натуральным."); } //Если введено отрицательное число
else if (minNumber == maxNumber && minNumber%2 !=0){Console.WriteLine("В диапазоне нет чётных чисел");} //Если введены два одинаковых нечётных числа
else if (minNumber > maxNumber) // Если первое введённое число больше второго
{
    if (maxNumber % 2 != 0)// Проверка на чётность
    {
        maxNumber = maxNumber + 1;
        Console.WriteLine(maxNumber);
        PrintNaturalNumbers(maxNumber, minNumber);
    }
    else { PrintNaturalNumbers(maxNumber, minNumber); }

}
else if (minNumber % 2 != 0) // Проверка на чётность
{
    minNumber = minNumber + 1;
    Console.WriteLine(minNumber);
    PrintNaturalNumbers(minNumber, maxNumber);
}
else { PrintNaturalNumbers(minNumber, maxNumber); }
