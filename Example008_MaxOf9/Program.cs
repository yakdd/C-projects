﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 12;
int b1 = 44;
int c1 = 75;

int a2 = 11;
int b2 = 771;
int c2 = 21;

int a3 = 14;
int b3 = 5;
int c3 = 200;


int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);
