using System;

// Clase base abstracta para representar a un empleado
public abstract class Empleado
{
    public string Nombre { get; set; }
    public double Salario { get; set; }

    // Constructor
    protected Empleado(string nombre, double salario)
    {
        Nombre = nombre;
        Salario = salario;
    }

    // Método abstracto para calcular el salario
    public abstract double CalcularSalario();
}

// Clase derivada que representa a un empleado por horas
public class EmpleadoPorHoras : Empleado
{
    public int HorasTrabajadas { get; set; }
    public double TarifaPorHora { get; set; }

    // Constructor
    public EmpleadoPorHoras(string nombre, double salario, int horasTrabajadas, double tarifaPorHora) : base(nombre, salario)
    {
        HorasTrabajadas = horasTrabajadas;
        TarifaPorHora = tarifaPorHora;
    }

    // Implementación del método abstracto para calcular el salario
    public override double CalcularSalario()
    {
        return HorasTrabajadas * TarifaPorHora;
    }
}

// Clase derivada que representa a un empleado asalariado
public class EmpleadoAsalariado : Empleado
{
    // Constructor
    public EmpleadoAsalariado(string nombre, double salario) : base(nombre, salario)
    {
    }

    // Implementación del método abstracto para calcular el salario
    public override double CalcularSalario()
    {
        return Salario;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear instancias de empleados por horas y empleados asalariados
        Empleado empleadoPorHoras = new EmpleadoPorHoras("Juan", 0, 40, 20);
        Empleado empleadoAsalariado = new EmpleadoAsalariado("Maria", 3000);

        // Calcular salario de cada empleado
        double salarioJuan = empleadoPorHoras.CalcularSalario();
        double salarioMaria = empleadoAsalariado.CalcularSalario();

        // Mostrar información
        Console.WriteLine("Salario de {0}: ${1}", ((EmpleadoPorHoras)empleadoPorHoras).Nombre, salarioJuan);
        Console.WriteLine("Salario de {0}: ${1}", ((EmpleadoAsalariado)empleadoAsalariado).Nombre, salarioMaria);
    }
}
