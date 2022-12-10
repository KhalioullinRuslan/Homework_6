// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int AddNumber(string str)
{
    System.Console.WriteLine(str);
    int numb = Convert.ToInt32(Console.ReadLine());
    return numb;
}

Console.Clear();

int k1 = AddNumber("Введите k1: ");
int b1 = AddNumber("Введите b1: ");
int k2 = AddNumber("Введите k2: ");
int b2 = AddNumber("Введите b2: ");

int x = (b2 - b1) / (k1 - k2);
int y = k1 * (b2 - b1) / (k1 - k2) + b1;

System.Console.WriteLine($"Точка перечесения двух прямых: [{x}, {y}]");