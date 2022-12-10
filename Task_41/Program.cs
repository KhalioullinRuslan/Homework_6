// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int DataNUmber(string str)
{
    System.Console.WriteLine(str);
    int numb = Convert.ToInt32(Console.ReadLine());
    return numb;
}

void FindPositive(int[] arr, out int pos) 
{
    pos = 0;
    
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
            pos++;
    }
}

Console.Clear();
int size = DataNUmber("Введите количество чисел");
int[] array = new int [size];
for (int i = 0; i < size; i++)
{
    array[i] = DataNUmber($"Введите {i + 1} число");
}
System.Console.WriteLine(string.Join( ", ", array));
FindPositive(array, out int pos); 
System.Console.WriteLine("положительных чисел: " + pos);

