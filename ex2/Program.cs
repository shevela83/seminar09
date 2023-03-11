/***Задача 67:**Напишите программу, 
которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/

using System;
using static System.Console;

Clear();
WriteLine(sumnum (1234));
int sumnum (int n){
    if (n / 10 == 0)
    {
        return n;
    }
      
    return n % 10 + sumnum(n/10);
}

