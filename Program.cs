// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] CreateNumbersArray()
{
    Console.Write("Введите размер массива -> ");
    int len = int.Parse(Console.ReadLine());
    int[] arr = new int[len];
    Console.Write($"Введите {len} числа через пробел -> ");
    string[] arrayNumber = Console.ReadLine().Split(' ');

    for (int i = 0; i < arrayNumber.Length; i++)
    {
        arr[i] = int.Parse(arrayNumber[i]);
    }
    return arr;
}


int Check(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}


int[] numbersArray = CreateNumbersArray();
System.Console.WriteLine($"{Check(numbersArray)} - столько чисел больше 0 ввёл пользователь!");