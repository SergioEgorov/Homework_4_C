Console.WriteLine("Введите число A: ");
Console.WriteLine("Введите число B: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int result =0;
for (int i = 0; i <= numberB; i++)
{
    result ^=i;
    Console.WriteLine($"Число {numberA} в степени {numberB} = {(long)Math.Pow(numberA,i)}");
}

