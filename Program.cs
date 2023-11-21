using System;

class Program {
    public static void Main(string[] args){
        Console.WriteLine("Enter three numbers respectively below:");
        int numOne = Convert.ToInt32(Console.ReadLine());
        int numTwo = Convert.ToInt32(Console.ReadLine());
        int numThree = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The average of 3 numbers is: " + (numOne + numTwo + numThree) / 3);
    }
}