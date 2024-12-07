namespace InheritanceApp;
public interface IOutput
{
    void Show();
    void Show(string info);
}

public class Array : IOutput
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
}

class Program
{
    static void Main()
    {
        int[] data = { 1, 2, 3, 4, 5 };
        IOutput array = new Array(data);

        array.Show();
        array.Show("Array of elements are:");
    }
}