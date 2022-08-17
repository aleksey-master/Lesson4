/* Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран.
И ищет второй максимум (элемент меньше максимального, но больше всех остальных)
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33], 19
 */

Console.Write("Введите ряд чисел, разделенных запятой : ");
string seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ","; // дополнительня запятая для обозначения конца строки

// функция удаления пробелов из строки
string RemovingSpaces(string series)
{
    string seriesNew = "";
    for (int i = 0; i < series.Length; i++)
    {
        if (series[i] != ' ')
        {
            seriesNew += series[i];
        }
    }
    return seriesNew;
}

//  функция  проверки на правильность ввода
void СheckNumber2(int series)
{
    if (
        series == '0'
        || series == '1'
        || series == '2'
        || series == '3'
        || series == '4'
        || series == '5'
        || series == '6'
        || series == '7'
        || series == '8'
        || series == '9'
        || series == ','
        || series == '-'
    ) { }
    else
    {
        Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");
    }
}

// функция  создания и заполнения массива из строки
int[] ArrayOfNumbers(string seriesNew)
{
    int[] arrayOfNumbers = new int[1]; // инициализация массива из 1 элемента

    int j = 0;

    for (int i = 0; i < seriesNew.Length; i++)
    {
        string seriesNew1 = "";

        while (seriesNew[i] != ',' && i < seriesNew.Length)
        {
            seriesNew1 += seriesNew[i];
            СheckNumber2(seriesNew[i]);
            i++;
        }
        arrayOfNumbers[j] = Convert.ToInt32(seriesNew1); // заполняет массив значениями из строки
        if (i < seriesNew.Length - 1)
        {
            arrayOfNumbers = arrayOfNumbers.Concat(new int[] { 0 }).ToArray(); // добавляет новый нулевой элемент в конец массива
        }
        j++;
    }
    return arrayOfNumbers;
}

// функция  вывода массива на печать
void PrintArray(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

string seriesNew = RemovingSpaces(seriesOfNumbers);

int[] arrayOfNumbers = ArrayOfNumbers(seriesNew);

PrintArray(arrayOfNumbers);

int[] arrayofNumbers;

// функция нахождения второго по величине максимального элемента
void SecondBiggest(int[] arrayOfNumbers)
{
    int firstBiggest=0;
    int secondBiggest=0;

    for (int i = 0; i < arrayOfNumbers.Length; ++i)
    {
        int arr = arrayOfNumbers[i];
        if (arr > secondBiggest && arr > firstBiggest)
        {
            secondBiggest = firstBiggest;
            firstBiggest = arr;
        }
        else if (arr > secondBiggest||arr < firstBiggest)
        {
                arr = secondBiggest;
        }
    }
Console.WriteLine($"  Второй максимум: {secondBiggest}");
}
SecondBiggest (arrayOfNumbers);
int [] arr;
