// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] GetArrayFromString(string stringArray)

{
    string[] nums = stringArray.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int CountPositive(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите числа через пробел: ");
string input = Console.ReadLine()!;
int[] numArray = GetArrayFromString(input);
int count = CountPositive(numArray);
Console.WriteLine($"Чисел больше нуля: {count}");
