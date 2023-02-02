// /// Создайте массив вещественных чисел.
// /// Найдите double dif = dif+ max- min;

void Zadanie(string msg)
{
    System.Console.WriteLine(msg);
}

int InputInt(string message)// создаем фукцию для введения длины массива
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}

double[] GenerateArray(int len)// создаем массив 
{
    double[] array = new double[len];
    Random rnd = new Random(); // ! ввела ограничение по размеру числа в массиве
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 10) + rnd.NextDouble();
        array[i] = Math.Round(array[i], 2);
    }
    return array;
}

void PrintArray(double[] array)// выводим массив на консоль
{
    foreach (double item in array)//item - все равно что array[i]. Только без явного указания индекса
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}





double DifferenceMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)//если текущий элемент больше максимального, то он становится максимальным.
        {
            max = array[i];
        }
        if (array[i] < min)//если текущий элемент меньше минимального, то он становится минимальным.
        {
            min = array[i];
        }
    }
    return max-min;
}
Zadanie("Создайте массив вещественных чисел. ");
Zadanie("Найдите разницу между максимальным и минимальным элементов массива");
System.Console.WriteLine();
int length = InputInt("Введите длину массива ");
double[] array = GenerateArray(length);
System.Console.WriteLine();
System.Console.Write("Mассив вещественных чисел: ");
PrintArray(array);
System.Console.WriteLine();
double rez = DifferenceMaxMin(array);
System.Console.WriteLine($"Разницу между максимальным и минимальным значение элементов = {rez}");


