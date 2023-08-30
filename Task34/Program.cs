// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] AskArray() // метод создает массив введенной длины
{
    Console.Write("Введите количество элементов массива: ");
    int length = int.Parse(Console.ReadLine());
    int[] array = new int[length];
    return array;
}

void FillArray(int[] array) //метод заполняет массив случайными трехзначными числами
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    Console.WriteLine("[" + String.Join(" ", array) + "]");
}

int FindingEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = AskArray();
FillArray(array);
int evenNumbers = FindingEvenNumbers(array);
if (evenNumbers == 0) { Console.WriteLine($"В заданном массиве четных чисел нет."); }
else { Console.WriteLine($"В заданном массиве количество четных чисел равно: {evenNumbers}."); }
