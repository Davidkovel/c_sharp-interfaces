namespace InheritanceApp;

public interface IOutput
{
    void Show();
    void Show(string info);
}

public interface IMath
{
    int Max();
    int Min();
    float Avg();
    bool Search(int valueToSearch);
}

public class Array : IOutput, IMath
{
    private int[] arr;

    public Array(int[] arr)
    {
        this.arr = arr;
    }

    public void Show()
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    public void Show(string info)
    {
        Console.WriteLine(info);
        Show();
    }

    public int Max()
    {
        if (arr.Length == 0) throw new Exception("Array is empty"); 
        return arr.Max();

    }

    public int Min()
    {
        if (arr.Length == 0) throw new Exception("Array is empty");
        return arr.Min();
    }

    public float Avg()
    {
        if (arr.Length == 0) throw new Exception("Array is empty.");

        return (float)arr.Average();
    }

    public bool Search(int valueToSearch)
    {
        if (arr.Length == 0) throw new Exception("Array is empty.");
        return arr.Contains(valueToSearch);
    }
}


class Program
{
    static void Main()
    {
        int[] data = { 1, 2, 3, 4, 5 };
        IOutput arrayOutput = new Array(data);
        IMath arrayMath = new Array(data);

        arrayOutput.Show();
        arrayOutput.Show("Array elements are:");

        Console.WriteLine("Max: " + arrayMath.Max());
        Console.WriteLine("Min: " + arrayMath.Min());
        Console.WriteLine("Avg: " + arrayMath.Avg());
        Console.WriteLine("Search 3: " + arrayMath.Search(5));
        Console.WriteLine("Search 10: " + arrayMath.Search(24));
    }
}

/*
1 2 3 4 5
Array elements are:
1 2 3 4 5
Max: 5
Min: 1
Avg: 3
Search 3: True
Search 10: False

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (process 11032) exited with code 0 (0x0).
Press any key to close this window . . .

 */