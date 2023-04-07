/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

*/

Console.Clear();

// Вводим данные
int arrayLength = GetIntInput("Введите длину массива (больше 0): ");

// Проверяем, чтобы длина массива была больше 0
if (Validation(arrayLength))
{
    int minNum = 1;
    int maxNum = 99;

    int[] array = new int[arrayLength]; // Создаем новый массив
    FillArray(array, minNum, maxNum);   // Заполняем массив
    Console.Write("Массив: ");
    PrintArray(array);                  // Выводим массив функция PrintArray

    // Выводим массив без функции (так быстрее)
    //Console.WriteLine("[{0}]", string.Join(", ", array));

    // Считаем сумму чисел в массиве, которые стоят на позициях при делении на 2 дают 1 (т.е. нечётные)
    Console.WriteLine(SumEvenArray(array, 2, 1));
}
ExitProgram();

// Функция: считаем сумму чисел в массиве
// у которых позиция при делении на определенное число M дает остаток N
int SumEvenArray(int[] array, int m, int n)
{
    int sumEven = 0;
    for (int i = n; i < array.Length; i += m)
    {
        sumEven += array[i];
    }
    return sumEven;
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