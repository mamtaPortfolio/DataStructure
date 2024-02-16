namespace DataStructure;

class Program
{
    static void Main(string[] args)
    {
        TwoSum obj = new TwoSum();
        var output = obj.AddTwoSum([2,7,11,15],9);
        Console.WriteLine($"{output[0].ToString()}, {output[1].ToString()}");
    }
}
