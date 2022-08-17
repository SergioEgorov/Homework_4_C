Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int GetSum (int number)
{
    int result = 0;
    result += number % 10;
    number /= 10;
    if(number > 0)
    {
    result += GetSum(number);
    }
    return result;
}

Console.WriteLine($"Сумма чисел числа {number} = {GetSum(number)}");
