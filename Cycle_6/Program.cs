using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите десятичное число: ");
        int decimalNumber = Convert.ToInt32(Console.ReadLine());

        // Переведення в двійкову систему числення
        string binaryRepresentation = DecimalToBinary(decimalNumber);

        // Виведення результату
        Console.WriteLine($"Двоичный вид числа {decimalNumber}: {binaryRepresentation}");
    }

    static string DecimalToBinary(int number)
    {
        if (number == 0)
        {
            return "0";
        }

        string binary = "";

        while (number > 0)
        {
            int remainder = number % 2;
            binary = remainder + binary;
            number /= 2;
        }

        return binary;
    }
}