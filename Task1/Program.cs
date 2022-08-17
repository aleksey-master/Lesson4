/* Напишите цикл, который принимает на вход два числа (A и B) и
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int Prompt(string message)
{
    Console.WriteLine(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

Console.WriteLine($"Возведение числа A в натуральную степень B");

int numberA = Prompt("Введите число A: ");
int numberB = Prompt("Введите число B: ");
int Exponentiation(int numberA, int numberB)
{
    int exponent = 1;
    for (int i = 1; i <= numberB; i++)
    {
        exponent = exponent * numberA;
    }
    return exponent;
}
int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine("Ответ: " + exponentiation);
