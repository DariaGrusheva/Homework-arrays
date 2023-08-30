// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] AskArray() // метод создания массива заданной длины
{
    Console.Write("Введите длину массива: ");
    int length = int.Parse(Console.ReadLine());
    double[] array = new double[length];
    return array;
}

void FillArray(double[] array) // метод заполняющий массив рандомно
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-9, 10) + rand.NextDouble();
        array[i] = Math.Round(array[i], 2);

    }
    Console.WriteLine("[" + String.Join(" ", array) + "]");
}

double SearchMin(double[] array) //метод поиска минимального элемента массива
{
    double minelement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minelement)
        {
            minelement = array[i];
        }
    }
    return minelement;
}

double SearchMax(double[] array) //метод поиска максимального элемента массива
{
    double maxelement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxelement)
        {
            maxelement = array[i];
        }
    }
    return maxelement;
}

double[] array = AskArray();
FillArray(array);
double minelement = SearchMin(array);
double maxelement = SearchMax(array);
double difference = maxelement - minelement;
Console.WriteLine($"Разнасть максимального и минимального элементов массива равна: {difference}.");
