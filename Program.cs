using System;
namespace InheritanceApp;

public interface ICalc
{
    int Less(int valueToCompare);
    int Greater(int valueToCompare);
}

public interface IOutput2
{
    void ShowEven();
    void ShowOdd();
}

public interface ICalc2
{
    int CountDistinct();
    int EqualToValue(int valueToCompare);
}


public abstract class BaseArray : IOutput2, ICalc, ICalc2
{
    protected int[] arr;

    public BaseArray(int[] arr)
    {
        this.arr = arr;
    }

    public abstract void Show();
    public abstract void Show(string info);

    public virtual void ShowEven()
    {
        Console.Write("Even numbers of array: ");
        foreach (var number in arr)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }

    public virtual void ShowOdd()
    {
        Console.Write("Odd numbers of array: ");
        foreach (var number in arr)
        {
            if (number % 2 != 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }


    public int Less(int valueToCompare)
    {
        return arr.Count(x => x < valueToCompare);
    }

    public int Greater(int valueToCompare)
    {
        return arr.Count(x => x > valueToCompare);
    }

    public int CountDistinct()
    {
        return arr.Distinct().Count();
    }

    public int EqualToValue(int valueToCompare)
    {
        int count = 0;
        foreach (var number in arr)
        {
            if (number == valueToCompare)
                count++;
        }
        return count;
    }
}

public class CustomArray : BaseArray
{
    public CustomArray(int[] arr) : base(arr) { }

    public override void Show()
    {
        foreach (var item in arr) 
        { 
            Console.Write(item + " "); 
        }

        Console.WriteLine();
    }

    public override void Show(string info)
    {
        Console.WriteLine(info);
        Show();
    }
}




class Program
{
    static void Main()
    {
        int[] data = { 1, 2, 3, 4, 5 };
        BaseArray customArray = new CustomArray(data); // L SOLID

        customArray.Show();
        Console.WriteLine("Result: ");

        Console.WriteLine("Number of unique elements: " + customArray.CountDistinct());

        int valueToCompare = 4;
        Console.WriteLine($"Number of values compare to {valueToCompare}: " + customArray.EqualToValue(valueToCompare));

    }
}

/*
1 2 3 4 5
Result:
Number of unique elements: 5
Number of values compare to 4: 1

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (process 3140) exited with code 0 (0x0).
Press any key to close this window . . .

*/