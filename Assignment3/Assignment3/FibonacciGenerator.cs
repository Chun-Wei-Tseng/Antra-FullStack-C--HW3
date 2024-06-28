namespace Assignment3;

public class FibonacciGenerator
{
    public void Execute()
    {
        for (int i = 1; i <= 10; i++)
        {
            int fibNumber = Fibonacci(i);
            Console.WriteLine($"Fibonacci({i}) = {fibNumber}");
        }
    }

    static int Fibonacci(int n)
    {
        if (n == 1 || n == 2)
        {
            return 1;
        }

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}