Console.WriteLine("Задайте размерность строкого массива n");
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
string[] matrix = new string[n]; // объявляем массив строковых чисел, состоящих из n элементов, введенный пользователем ранне

void FillArray(string[] matrix)  // в этом методе мы заполняем массив
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.WriteLine($"Введите любое строковое значение элемента номер {i + 1}"); // заполнение для удобства
        matrix[i] = Console.ReadLine();
    }
}

void PrintArray(string[] matrix) // выводим наш массив
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write(matrix[i] + " ");
    }
}

int k = 0;  // вводим коэффициент, что бы распределять новые элементы в нормальном порядке, а не хаотичном
            // то есть что бы у нас не было элементов matrix1[0], затем matrix1[2]
string[] matrix1 = new string[matrix.Length]; // здесь мы вводим второй массив, который будем заполнять новыми данными

void NewArray()
{
    for (int i = 0; i < n; i++)
    {
        if (matrix[i].Length <= 3)
        {      
            matrix1[k] = matrix[i]; // в этом участке мы ищем элементы массива, в которых длина меньше либо равна трем
            k++;
        }
    }
}
// просто выполняем наши методы
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
NewArray();
Console.WriteLine();

PrintArray(matrix1);
