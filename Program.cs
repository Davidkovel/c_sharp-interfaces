using System;
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

public interface ISort
{
    void SortAsc();
    void SortDesc();
    void SortByParam(bool isAsc);
}

public abstract class ArrayOperations : IOutput, IMath, ISort
{
    public abstract void Show();
    public abstract void Show(string info);
    public abstract int Max();
    public abstract int Min();
    public abstract float Avg();
    public abstract bool Search(int valueToSearch);
    public abstract void SortAsc();
    public abstract void SortDesc();
    public abstract void SortByParam(bool isAsc);
}

public class CustomArray : ArrayOperations
{
    private int[] arr;

    public CustomArray(int[] arr)
    {
        this.arr = arr;
    }

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

    public override int Max()
    {
        if (arr.Length == 0) throw new Exception("Array is empty");
        return arr.Max();
    }

    public override int Min()
    {
        if (arr.Length == 0) throw new Exception("Array is empty");
        return arr.Min();
    }

    public override float Avg()
    {
        if (arr.Length == 0) throw new Exception("Array is empty.");
        return (float)arr.Average();
    }

    public override bool Search(int valueToSearch)
    {
        if (arr.Length == 0) throw new Exception("Array is empty.");
        return arr.Contains(valueToSearch);
    }

    public override void SortAsc()
    {
        Array.Sort(arr);
    }

    public override void SortDesc()
    {
        Array.Sort(arr);
        Array.Reverse(arr);
    }

    public override void SortByParam(bool isAsc)
    {
        if (isAsc)
        {
            SortAsc();
        }
        else
        {
            SortDesc();
        }
    }
}

class Program
{
    static void Main()
    {
        int[] data = { 1, 2, 3, 4, 5 };
        ArrayOperations arrayOps = new CustomArray(data);

        arrayOps.Show();
        arrayOps.Show("Array elements are:");

        Console.WriteLine("Max: " + arrayOps.Max());
        Console.WriteLine("Min: " + arrayOps.Min());
        Console.WriteLine("Avg: " + arrayOps.Avg());
        Console.WriteLine("Search 5: " + arrayOps.Search(5));
        Console.WriteLine("Search 24: " + arrayOps.Search(24));

        Console.WriteLine("\nSorting Array:");
        arrayOps.SortAsc();
        arrayOps.Show("Sorted in Ascending Order:");

        arrayOps.SortDesc();
        arrayOps.Show("Sorted in Descending Order:");
    }
}

/*
1 2 3 4 5
Array elements are:
1 2 3 4 5
Max: 5
Min: 1
Avg: 3
Search 5: True
Search 24: False

Sorting Array:
Sorted in Ascending Order:
1 2 3 4 5
Sorted in Descending Order:
5 4 3 2 1

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (process 836) exited with code 0 (0x0).
Press any key to close this window . . .

*/