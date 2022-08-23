// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int M = 1;
int N = 15;
int result = 0;

void Sum(int x, int y, int z)
{
    if(x <= y) 
    {
        z += x;
        Sum(x+1, y, z);
    }
    else
    {
    Console.WriteLine(z);
    }
}

Sum(M, N, result);