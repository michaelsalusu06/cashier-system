using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input your name: ");
        string inputname = Console.ReadLine();
        Console.Write("Subtotal: ");
        double subtotal = Convert.ToDouble(Console.ReadLine());
        Console.Write("Points: ");
        int points = Convert.ToInt32(Console.ReadLine());
        
        string membership = points >= 50 ? "VIP" : "Standard";
        double total;
        double temptotal;

        for(int i=0; i<3; i++)
        {
            Console.WriteLine("Scanning item " + (i + 1));
        }

        if(subtotal > 3000)
        {
            temptotal = subtotal * 0.20;
            total = subtotal - temptotal;
        }

        else if(subtotal > 2000)
        {
            temptotal = subtotal * 0.10;
            total = subtotal - temptotal;
        }

        else
        {
            total = subtotal;
        }

        if(membership == "VIP")
        {
            temptotal = subtotal * 0.05;
            total = total - temptotal;
        }

        static void CalculateDiscount(double total1, double subtotal1)
        {
            Console.WriteLine("You just saved: " + (subtotal1 - total1));
        }
        CalculateDiscount(total, subtotal);
    }
}