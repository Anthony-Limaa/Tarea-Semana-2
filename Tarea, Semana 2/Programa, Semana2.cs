using System;

class ProgramaSemana2
{
   static void Main()
    {
        Console.WriteLine("EDAD");
        Console.Write("¿Cuál es tu edad? Escribala porfavor ");
        byte edad = byte.Parse(Console.ReadLine());
        Console.WriteLine("Wow, no aparentas {0} años.", edad);

        Console.WriteLine("");
        Console.WriteLine("MULTIPLICACION");
        Console.Write("Introduce el primer número de dos cifras: ");
        byte num1 = byte.Parse(Console.ReadLine());

        Console.Write("Introduce el segundo número de dos cifras: ");
        byte num2 = byte.Parse(Console.ReadLine());

        ushort resultado = (ushort)(num1 * num2);

        Console.WriteLine("El resultado de la multiplicación es: {0}", resultado);


        Console.WriteLine("");
        Console.WriteLine("SUMA, RESTA Y PRODUCTO");
        Console.Write("Introduce el primer número entero largo: ");
        long numero1 = long.Parse(Console.ReadLine());

        Console.Write("Introduce el segundo número entero largo: ");
        long numero2 = long.Parse(Console.ReadLine());

        long suma = numero1 + numero2;
        long resta = numero1 - numero2;
        long producto = numero1 * numero2;

        Console.WriteLine("La suma de los números es: {0}", suma);
        Console.WriteLine("La resta de los números es: {0}", resta);
        Console.WriteLine("El producto de los números es: {0}", producto);
    }

}
