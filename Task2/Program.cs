/* Напишите программу, которая принимает на вход число и
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int Prompt(string message)
{
    Console.WriteLine(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int number = Prompt("Введите число: ");
int SumNumbers(int number)
{
    int numbersLength = Convert.ToString(number).Length;
    int count = 0;
    int sum = 0;

    for (int i = 0; i <= numbersLength; i++)
    {
        count = number - number % 10;
        sum = sum + (number - count);
        number = number / 10;
    }
    return sum;
}
int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма цифр в числе: " + sumNumbers);
