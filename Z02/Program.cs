// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0




void Zadanie(string msg)
{
    System.Console.WriteLine(msg);
}

int InputInt(string message)// создаем фукцию для введения длины массива
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());// == как convert вместо него 
}

int[] GenerateArray(int len)// создаем массив 
{
    int[] array = new int[len];
    Random rnd = new Random(); // ! ввела ограничение по размеру числа в массиве
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if ((i + 1) < array.Length)
        {
            Console.Write($", ");
        }
    }
    Console.Write($"]");
}



// void PrintArray(int[] array)
// {
// foreach (int item in array)//item - все равно что array[i]. Только без явного указания индекса
// {
// System.Console.Write($"{item}\t");
// }
// System.Console.WriteLine();
// }

int SumInd(int[] array)// фукция поиска суммы элементов, стоящих на нечётных позициях
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum=sum + array[i];
        }
    }
    return sum;
}

Zadanie("Создайте одномерный массив, заполненный случайными числами");
Zadanie("И Найдите сумму элементов, стоящих на нечётных позициях.");
System.Console.WriteLine();
int len = InputInt("Введите длину массива  ");
int[] array = GenerateArray(len);
System.Console.WriteLine();
System.Console.Write("Одномерный массив случайных чисел: ");
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"{SumInd(array)} ");
