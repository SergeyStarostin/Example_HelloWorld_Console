﻿int Max(int argument1, int argument2, int argument3)
{
    int result = argument1;
    if (argument2 > result) result = argument2;
    if (argument3 > result) result = argument3;
    return result;
}

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;


int max1 = Max (a1, b1, c1);
int max2 = Max (a2, b2, c2);
int max3 = Max (a3, b3, c3);
int max = Max(max1, max2, max3);

Console.WriteLine(max);
