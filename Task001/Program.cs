// Задача N1 Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.

int M = 1;
int N = 10;

void Numbers(int x, int y)
{
    if(x<=y)
    {
        Console.Write(x +" ");
        Numbers(x+1, y);
    }
}

Numbers(M, N);
