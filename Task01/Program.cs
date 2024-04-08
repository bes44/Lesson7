 Console.Write("Введите начальное число (M): ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конечное число (N): ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.Write($"все натуральные числа в промежутке от {M} до {N}: ");
    SimpleNumbers(M, N);


void SimpleNumbers(int M, int N)
{
    if(M > N) return;
    if (M>0) {
    Console.Write($"{M}  ");
    }
    SimpleNumbers(M+1, N);
}


   

