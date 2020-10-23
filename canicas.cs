using System;

class MainClass {
    public static void Consulta(string[] nens, int[] canicas, string[] ciutat, int posicion){
        Console.WriteLine("Ahora esta es la cantidad de canicas que tienes:");
        Console.WriteLine("Nombre" + nens [posicion]+ "Canicas" + canicas[posicion] + "Población" + ciutat[posicion]);
        Console.WriteLine("");
        Console.WriteLine("Dime las canicas que quieres poner o dispones ahora:");
        int canicasActuales = Convert.ToInt32(Console.ReadLine());
        canicas [posicion] = canicasActuales;
    }

    public static void SubMenu (string[] nens, int[] canicas, string[] ciutat, int posicion) {
        Console.WriteLine("\nQue quieres hacer?\n1. Saber el numero de canicas que tienes.\n2. Actualizar el numero de canicas.\n3. Salir.");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Saber el numero de canicas.");
                break;
            case 2:
                Console.WriteLine("Actualizar el numero de canicas.");
                break;
            case 3:
                Main();
                break;
            default:
                Console.WriteLine("Selecciona una opcion valida!\n");
                break;
        }
    }
        
    public static void Menu (string[] nens, int[] canicas, string[] ciutat) {
        Console.WriteLine("Escribe tu nombre:");
        string nombre = Console.ReadLine();

        int posicion = 0;
        int encontrado = 0;
        for (int n = 0; n < nens.Length; n++)
        {
            if (String.Equals(nombre, nens[n]))
            {
                posicion = n;
                encontrado = 1; 
            }
        }

        if (encontrado == 0)
        {
            Console.WriteLine("No se ha podido encontrar un niño con ese nombre!\n");
        } else
        {
            while (true)
            {
                SubMenu(nens, canicas, ciutat, posicion);
            }
        }
    }

    public static void Main () {
        string[] nens = {"Joan", "Nil", "Roc", "Thiago", "Nico","Noa", "Gerard", "Nor"};
        int[] canicas = {12,3,25,31,6,11,21,9};
        string[] ciutat = {"Vilanova", "Canyelles", "Vilanova", "Sitges", "Cunit", "Vilanova", "Kazahstan", "Cubelles"};
        
        while (true)
        {
            Menu(nens, canicas, ciutat);
        }
    }
}