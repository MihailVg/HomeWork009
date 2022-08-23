// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

int FunctionAkkerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if((m > 0) && (n == 0))
        {
            return FunctionAkkerman(m - 1, 1);
        }
        else if((m > 0) && (n > 0))
        {
            return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
        }else
        return n + 1;
    }

int n = 3;
int m = 2;

Console.WriteLine(FunctionAkkerman(n, m));