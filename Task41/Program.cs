// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
Console.Write("Введите количество чисел, которые хотите ввести: ");
int q = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < q; i++)
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    {
        if (num > 0) count++;
    }
}
Console.Write($"Количество введённых чисел больше нуля : {count}");