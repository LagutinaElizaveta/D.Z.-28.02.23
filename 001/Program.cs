// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2      1, -7, 567, 89, 223-> 3

Console.Write("Введите целые числа через пробел: ");
string[] st = Console.ReadLine().Split(' ');
// Метод записи массива строк в массив чисел
int[] Convert(string[] array)
{
    int[] res = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        res[i] = int.Parse(array[i]);
    }
    return res;
}
// Переписываем наш массив строк
int[] num = Convert(st);
// Метод пересчета отрицательных чисел
int CountMin(int[] num)
{
    int count = 0;
    foreach (int el in num)
    {
        if (el > 0) count++;
    }
    return count;
}
// Вывод результата
Console.WriteLine($"Количество чисел больше 0 равно {CountMin(num)}");