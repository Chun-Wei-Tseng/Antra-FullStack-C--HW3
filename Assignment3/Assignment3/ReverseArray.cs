namespace Assignment3;

public class ReverseArray
{
    public void Execute()
    {
        int[] numbers = GenerateNumbers(10);
        Console.WriteLine("Original array:");
        PrintNumbers(numbers);

        Reverse(numbers); // Reverse the array
        Console.WriteLine("\nReversed array:");
        PrintNumbers(numbers); 
    }
    static int[] GenerateNumbers(int length)
    {
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = i + 1;
        }
        return array;
    }
    static void Reverse(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[length - i - 1];
            array[length - i - 1] = temp;
        }
    }
    static void PrintNumbers(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}