// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] AskArray()
{
    Console.Write("Введите длину массива: ");
    int length = int.Parse(Console.ReadLine());
    int[] array = new int[length];
    return array;
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    Console.WriteLine("[" + String.Join(" ", array) + "]");
}

int SumElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] array = AskArray();
FillArray(array);
int sum = SumElements(array);
Console.WriteLine($"Сумма элементов заданного массива, стоящих на нечетных местах, равна: {sum}.");