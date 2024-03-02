using System;

public class Calculadora
{
    public static int Sumar(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int Restar(int num1, int num2)
    {
        return num1 - num2;
    }

    public static int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }

    public static int Dividir(int num1, int num2)
    {
        return num1 / num2;
    }

    static void Main(string[] args)
    {
        // Pedir dos números al usuario
        Console.WriteLine("Introduce el primer número:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el segundo número:");
        int num2 = int.Parse(Console.ReadLine());

        // Invocar los métodos
        int suma = Sumar(num1, num2);
        int resta = Restar(num1, num2);
        int multiplicacion = Multiplicar(num1, num2);
        int division = Dividir(num1, num2);

        // Mostrar los resultados
        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Resta: " + resta);
        Console.WriteLine("Multiplicación: " + multiplicacion);
        Console.WriteLine("División: " + division);
    }
}
