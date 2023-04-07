/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

*/

Console.Clear();

// Вводим данные
int arrayLength = GetIntInput("Введите длину массива (больше 0): ");

// Проверяем, чтобы длина массива была больше 0
if (Validation(arrayLength))
{
    double minNum = -50.0; // Задаем минимальную границу чисел
    double maxNum = 50.0; // Задаем максимальную границу чисел

    double[] array = new double[arrayLength]; // Создаем новый массив
    FillArray(array, minNum, maxNum);         // Заполняем массив
    Console.Write("Массив: ");
    PrintArray(array);                       // Выводим массив функция PrintArray

    // Выводим массив без функции (так быстрее)
    //Console.WriteLine("[{0}]", string.Join(", ", array));

    // Вычисляем разницу между максимальным и минимальным элементов массива
    Console.WriteLine($"Наибольшее число: {FindMaxArray(array)}");
    Console.WriteLine($"Наименьшее число: {FindMinArray(array)}");
    Console.WriteLine($"Разница между ними: {FindMaxArray(array) - FindMinArray(array)}");
}
ExitProgram();

// Функция: Нахождение минимального значения массива
double FindMinArray(double[] array)
{
    double minArray = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minArray)
        {
            minArray = array[i];
        }
    }
    return minArray;
}

// Функция: Нахождение максимального значения массива
double FindMaxArray(double[] array)
{
    double maxArray = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxArray)
        {
            maxArray = array[i];
        }
    }
    return maxArray;
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
void FillArray(double[] collection, double min, double max)
{
    for (int i = 0; i < collection.Length; i++)
    {
        double rand = new Random().NextDouble(); // Генерируем вещественное случайное число от 0 до 1
        collection[i] = rand * (max - min) + min; // Заполняем массив случайными числами от min до max 
    }
}

// Функция вывода массива
void PrintArray(double[] col)
{
    Console.Write("[");
    for (int position = 0; position < col.Length - 1; position++)
    {
        Console.Write($"{col[position]}, ");
    }
    Console.Write(col[col.Length - 1] + "]");
    Console.WriteLine();
}