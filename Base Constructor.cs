using System;

public class TwoD
{
    public int length;
    public int breadth;

    public TwoD(int x = 5, int y = 4)
    {
        this.length = x;
        this.breadth = y;
    }

    public int GetResults()
    {
        return this.length * this.breadth;
    }
}

public class ThreeD : TwoD
{
    public int height;

    public ThreeD(int a, int b, int c) : base(a, b)
    {
        this.height = c;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ThreeD obj = new ThreeD(2, 3, 4);
        Console.WriteLine($"Length: {obj.length}");
        Console.WriteLine($"Breadth: {obj.breadth}");
        Console.WriteLine($"Height: {obj.height}");
        int result = obj.GetResults();
        Console.WriteLine($"Result: {result}");
    }
}
