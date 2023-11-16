// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9


int ReadIn(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    return int.Parse(a);
}

int PrintNaturalNumbers(int num)
{
    if (num == 0) { return 0; }
    return PrintNaturalNumbers(num/10)+num%10;
     
}

Console.Write($"{PrintNaturalNumbers(ReadIn("чисдл"))}");