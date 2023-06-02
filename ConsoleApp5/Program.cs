using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Задание №34\nВведите размер массива");
int f = Convert.ToInt32(Console.ReadLine());
if (f < 1)
{
    Console.WriteLine("Ошибка, Введите положительные значения");
}
else
{

    int[] CreateArrayRndInt(int size, int min, int max)
    {
        int con = 0;
        int[] arr = new int[size];
        Random rnd = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(min, max + 1);
            if (arr[i] % 2 == 0)
                con++;
        }

        Console.WriteLine($"Всего {arr.Length} числа, {con} из них четные");

        return arr;
    }

    void PrintArray(int[] arr, string sep)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
            else Console.Write($"{arr[i]}");
        }
    }

    int[] array = CreateArrayRndInt(f, 100, 999);
    Console.Write("\n|");
    PrintArray(array, ",");
    Console.Write("|");
}






Console.WriteLine("\n\nЗадание 36 №\nВведите размер массива");
int s1 = Convert.ToInt32(Console.ReadLine());
if (s1 < 1)
{
    Console.WriteLine("Ошибка, Введите положительные значения");
}
else
{

    int[] arr = new int[s1];
    zapolnenie(arr);
    Console.WriteLine("Вот наш массив: ");
    vivod(arr);
    int sum = 0;

    for (int z = 0; z < arr.Length; z += 2)
        sum = sum + arr[z];

    Console.WriteLine($"всего {arr.Length} чисел, сумма элементов на нечётных позициях = {sum}");

    void zapolnenie(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(1, 999);
        }
    }
    void vivod(int[] arr)
    {
        Console.Write("|");
        for (int i = 0; i < arr.Length; i++)

        {
            Console.Write(arr[i] + ", ");
        }
        Console.Write("|\n");

    }
}
int N = Convert.ToInt32(Console.ReadLine());
if (N < 2)
{
    Console.WriteLine("Ошибка, Введите положительные значения");
}
else
{
    Console.WriteLine("\n\nЗадание 38 №\nВведите размер массива");


    int[] array = new int[N];
    int min = int.MaxValue;
    int max = int.MinValue;
    Random random = new Random();
    int a = 0;
    for (int i = 0; i < array.Length; i++)
    {
        ArayRandom(array, a);
        a = random.Next(-100, 100);
        array[i] = a;
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    dfd(array);
    Console.WriteLine($"Минимальное значение: {min}");
    Console.WriteLine($"Максимальное значение: {max}");
    int difference = max - min;
    Console.WriteLine($"Разница между самым большим и самым маленьким значением: {difference}");

    Console.ReadLine();


    static bool ArayRandom(int[] array, int a)
    {
        return false;
    }

    void dfd(int[] array)
    {
        Console.Write("|");
        for (int i = 0; i < array.Length; i++)

        {
            Console.Write(array[i] + ", ");
        }
        Console.Write("|\n");

    }
}