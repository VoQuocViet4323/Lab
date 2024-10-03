internal class Program
{
    private static void Main(string[] args)
    {
        const int Scale = 23000;
        Console.WriteLine($"Nhap so tien ma ban co");
        int USD = int.Parse(Console.ReadLine()); 
        int tien = Scale * USD;
        Console.WriteLine($"So tien Viet ma ban co la: {tien}");
        
    }
}