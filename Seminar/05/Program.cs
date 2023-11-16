// Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

int ReadIn(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    return int.Parse(a);
}

bool PowerOfTwo(int baseNumber)
{
    if (baseNumber == 1) { return true; }
    return baseNumber % 2 == 0 && PowerOfTwo(baseNumber / 2);

}

if (PowerOfTwo(ReadIn("Число")) == true)
{
    Console.WriteLine("Является степенью двойки");
}
else
{
    Console.WriteLine(Не является степенью двойки");
}
