using System;

// Clase base Persona
public class Persona
{
    // Atributos de Persona
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }

    // Constructor de Persona que valida los datos
    public Persona(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion)
    {
        // Validación de los datos
        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentException("El nombre no puede estar vacío.", nameof(nombre));
        if (string.IsNullOrWhiteSpace(apellido))
            throw new ArgumentException("El apellido no puede estar vacío.", nameof(apellido));
        if (fechaNacimiento >= DateTime.Today)
            throw new ArgumentException("La fecha de nacimiento debe ser anterior a la fecha actual.", nameof(fechaNacimiento));
        if (string.IsNullOrWhiteSpace(telefono))
            throw new ArgumentException("El teléfono no puede estar vacío.", nameof(telefono));
        if (string.IsNullOrWhiteSpace(direccion))
            throw new ArgumentException("La dirección no puede estar vacía.", nameof(direccion));

        // Asignación de valores
        Nombre = nombre;
        Apellido = apellido;
        FechaNacimiento = fechaNacimiento;
        Telefono = telefono;
        Direccion = direccion;
    }
}

// Clase Alumno que hereda de Persona
public class Alumno : Persona
{
    // Atributos adicionales de Alumno
    public string Carnet { get; set; }
    public DateTime FechaIngreso { get; set; }

    // Constructor de Alumno
    public Alumno(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion, string carnet, DateTime fechaIngreso)
        : base(nombre, apellido, fechaNacimiento, telefono, direccion)
    {
        Carnet = carnet;
        FechaIngreso = fechaIngreso;
    }
}

// Clase Profesor que hereda de Persona
public class Profesor : Persona
{
    // Atributos adicionales de Profesor
    public string Titulo { get; set; }
    public DateTime FechaContratacion { get; set; }

    // Constructor de Profesor
    public Profesor(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion, string titulo, DateTime fechaContratacion)
        : base(nombre, apellido, fechaNacimiento, telefono, direccion)
    {
        Titulo = titulo;
        FechaContratacion = fechaContratacion;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear instancias para probar las clases
        Persona persona = new Persona("Juan", "Perez", new DateTime(1990, 5, 15), "123456789", "Calle Principal 123");
        Alumno alumno = new Alumno("Maria", "Gomez", new DateTime(2000, 10, 25), "987654321", "Avenida Central 456", "A12345", DateTime.Now);
        Profesor profesor = new Profesor("Pedro", "Martinez", new DateTime(1975, 8, 3), "555666777", "Calle Secundaria 789", "Licenciado en Educación", DateTime.Now);

        // Ejemplo de uso
        Console.WriteLine($"Persona: {persona.Nombre} {persona.Apellido}");
        Console.WriteLine($"Alumno: {alumno.Nombre} {alumno.Apellido}, Carnet: {alumno.Carnet}");
        Console.WriteLine($"Profesor: {profesor.Nombre} {profesor.Apellido}, Título: {profesor.Titulo}");
    }
}



