using System;

class MainClass {
    public static void Menu () {
        Console.WriteLine("Escribe tu nombre:");
        string nombre = Console.ReadLine();

        int posicion = 0;
        int encontrado = 0;
        for (int n = 0; n < nombres.length; n++)
        {
            if (String.Equals(nombre, nombres[n]))
            {
                posicion = n;
                encontrado = 1; 
            }
        }

        if (encontrado == 0)
        {
            Console.WriteLine("No se ha podido encontrar un niño con ese nombre!");
        } else
        {
            Console.WriteLine("Se ha encontrado!");
        }
    }

    public static void Main () {
        Console.WriteLine("hola");

    }
}