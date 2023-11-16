// Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”
int ReadIn(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    return int.Parse(a);
}

bool SimpleNumber(int M, int divider)
{
    if (divider == 1) { return true; }
    return M%divider != 0 && SimpleNumber(M, divider-1);

}
int number = ReadIn("Число");
Console.WriteLine(SimpleNumber(number, number-1));