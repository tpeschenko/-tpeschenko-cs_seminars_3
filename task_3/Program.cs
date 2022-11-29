// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void zadacha_23()
{
    Console.WriteLine("Введите число, программа выведит таблицу кубов введённого числа");
    int number = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i < number + 1; i ++)
    {
        double new_number = Math.Pow(i, 3);
        Console.Write($"{new_number} ");
    }

}

zadacha_23();