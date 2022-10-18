// Вывод ряда Фибоначчи с помощью рекурсии

int Fibonacci(int num)
{
    // if (num == 1 || num == 2) return 1;
    if (num <= 1) return num;
    else return Fibonacci(num - 1) + Fibonacci(num - 2);
}


for (int i = 1; i < 15; i++)
{
    Console.WriteLine(Fibonacci(i));
}