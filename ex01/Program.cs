using System;
using static System.Console;

Clear();
WriteLine(PrintNumbers(10, 4));
string PrintNumbers(int n, int m){
    if (m > n)
    {
        return String.Empty;
    }
    string s = m.ToString() + " " + PrintNumbers(n, m +1);
    //WriteLine(s);
    return s;
}
