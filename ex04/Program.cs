using System;
using static System.Console;

Clear();
WriteLine(St (72, 3));
double St (int a, int b){
    if (b == 0)
    {
        return 1;
    }
    return a * St (a, b - 1);
}

