/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

*/

Console.Clear();

// Вводим данные
int arrayLength = GetIntInput("Введите длину массива (больше 0): ");

// Проверяем, чтобы длина массива была больше 0
if (Validation(arrayLength))
{
    int minNum = 100;
    int maxNum = 999;

    int[] array = new int[arrayLength]; // Создаем новый массив
    FillArray(array, minNum, maxNum);   // Заполняем массив
    Console.Write("Массив: ");
    PrintArray(array);                  // Выводим массив функция PrintArray

    // Выводим массив без функции (так быстрее)
    //Console.WriteLine("[{0}]", string.Join(", ", array));

    // Считаем количество чисел в массиве, которые при делении на 2 дают 0 (т.е. чётные)
    Console.WriteLine(CountEvenArray(array, 2, 0));
}
ExitProgram();

// Функция: считаем количество чисел в массиве
// у которых при делении на определенное число M дает остаток N
int CountEvenArray(int[] array, int m, int n)
{
    int countEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % m == n)
        {
            countEven++;
        }
    }
    return countEven;
}

// Функция окончания работы программы
void ExitProgram()
{
    Console.WriteLine("Нажмите любую клавишу");
    Console.ReadKey();
}

// Функция ввода числа с выводом сообщения
int GetIntInput(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

// Функция проверки, если длина массива должна быть больше 0
bool Validation(int numArray)
{
    if (numArray <= 0)
    {
        Console.WriteLine($"Вы ввели длину массива: {arrayLength}, необходимо больше 0");
        return false;
    }
    return true;
}

// Заполняем массив случайными числами от min до max
void FillArray(int[] collection, int min, int max)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(min, max + 1);
    }
}

// Функция вывода массива
void PrintArray(int[] col)
{
    Console.Write("[");
    for (int position = 0; position < col.Length - 1; position++)
    {
        Console.Write($"{col[position]}, ");
    }
    Console.Write(col[col.Length - 1] + "]");
    Console.WriteLine();
}