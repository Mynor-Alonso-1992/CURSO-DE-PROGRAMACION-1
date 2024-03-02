public class Program
{
    static void Main(string[] args)
    {
        //Solicitar nombre del usuario
        Console.WriteLine("Introduzca su nombre:");
        string nombreUsuario = Console.ReadLine();

        //Solicitar ingresos de los últimos 3 meses
        int[] ingresos = new int[3];
        for (int i = 0; i < ingresos.Length; i++)
        {
            Console.WriteLine("Introduzca los ingresos del mes " + (i + 1) + ":");
            ingresos[i] = int.Parse(Console.ReadLine());
        }

        //Calcular la suma y el promedio
        int suma = 0;
        foreach (int ingreso in ingresos)
        {
            suma += ingreso;
        }

        double promedio = (double)suma / ingresos.Length;

        //Mostrar el resultado
        Console.WriteLine("Hola " + nombreUsuario + ", en total ganaste " + suma + " y promediaste " + promedio);
    }
}
