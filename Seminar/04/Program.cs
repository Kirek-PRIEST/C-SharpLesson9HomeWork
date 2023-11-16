// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int ReadIn(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    return int.Parse(a);
}

int Power(int baseNumber, int powerNumber)
{
    if (powerNumber == 0) { return 1; }
    return Power(baseNumber, powerNumber-1)*baseNumber;
     
}

Console.Write($"{Power(ReadIn("число"), ReadIn("степень"))}");