// Задача 1: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Если числа положительные и трехзначные значит они находятся в рамках от [100 до 1000)


void Zadanie(string msg)
{
    System.Console.WriteLine(msg);
}

int InputInt(string message)// создаем фукцию для введения длины массива
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());// == как convert вместо него 
}

int[] GenerateArray(int length)// создаем массив 
{
int[] array = new int[length];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = rnd.Next(100, 1000);
}
return array;
}


void PrintArray(int[] array)
{
foreach (int item in array)//item - все равно что array[i]. Только без явного указания индекса
{
System.Console.Write($"{item}\t");
}
System.Console.WriteLine();
}

int Number (int [] array)// фукция поиска двузначных элементов массива
{
int count = 0;

for (int i =0 ; i< array.Length ; i++)
{
if (array[i] % 2 == 0)
count++;

}
return count;
}




Zadanie("Создайте массив заполненный случайными положительными трёхзначными числами. И укажите количество чётных чисел в массиве");
System.Console.WriteLine();
int length = InputInt("Введите длину массива:  ");
int[] array = GenerateArray(length);
System.Console.WriteLine();
System.Console.Write("Одномерный массив трехзначных положительных чисел: ");
PrintArray(array);
System.Console.WriteLine($"Содержит {Number (array)} чисел");
