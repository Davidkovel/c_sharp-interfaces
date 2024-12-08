using System;
namespace InheritanceApp;

public interface ICalc
{
    int Less(int valueToCompare);
    int Greater(int valueToCompare);
}

public class CustomArray : ICalc
{
    private int[] arr;

    public CustomArray(int[] arr)
    {
        this.arr = arr;
    }

    public int Less(int valueToCompare)
    {
        return arr.Count(x => x < valueToCompare);
    }

    public int Greater(int valueToCompare)
    {
        return arr.Count(x => x > valueToCompare);
    }

    public void Show()
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}



class Program
{
    static void Main()
    {
        int[] data = { 1, 2, 3, 4, 5 };
        CustomArray customArray = new CustomArray(data);

        customArray.Show();

        int valueToCompare = 3;

        Console.WriteLine($"Less than {valueToCompare}: {customArray.Less(valueToCompare)}");
        Console.WriteLine($"Greater than {valueToCompare}: {customArray.Greater(valueToCompare)}");
    }
}

/*
1 2 3 4 5
Less than 3: 2
Greater than 3: 2

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (process 21352) exited with code 0 (0x0).
Press any key to close this window . . .

*/