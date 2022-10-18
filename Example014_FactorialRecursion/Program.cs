// Расчет факториала с помощью рекурсии

int FactorialRecursion(int num)
{
    if (num == 1) return 1;
    else return num * FactorialRecursion(num - 1);
}

int factorial = FactorialRecursion(5);
Console.WriteLine(factorial);
