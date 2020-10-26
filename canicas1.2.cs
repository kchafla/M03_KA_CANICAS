using System;
class MainClass{
    public static int Consulta(string[] nens, int[] canicas, string[] ciutat, int posicion){
        Console.WriteLine("\nAhora esta es la cantidad de canicas que tienes:");
        Console.WriteLine("Nombre: " + nens[posicion]+ "\nCanicas: " + canicas[posicion] + "\nPoblación: " + ciutat[posicion]);
        Console.WriteLine("\nDime las canicas que quieres poner o dispones ahora:");
        int canicasActuales = Convert.ToInt32(Console.ReadLine());
        return canicasActuales;
    }

    public static int subMenu(string[] nens, int[] canicas, string[] ciutat, int posicion){
        Console.WriteLine("\nQue quieres hacer?\n1. Saber el numero de canicas que tienes.\n2. Actualizar el numero de canicas.\n3. Salir.");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion){
          case 1:
            Console.WriteLine("\nAhora esta es la cantidad de canicas que tienes:");
            Console.WriteLine("Nombre: " + nens[posicion]+ "\nCanicas: " + canicas[posicion] + "\nPoblación: " + ciutat[posicion]);
            break;
          case 2:
            canicas[posicion] = Consulta(nens, canicas, ciutat, posicion);
            break;
          case 3:
            Console.WriteLine("");
            Main();
            break;
          default:
            Console.WriteLine("Selecciona una opcion valida!\n");
              break;
          }
        return canicas[posicion];

    }
    public static void Main() {
        string[] nens = {"Joan", "Nil", "Roc", "Thiago", "Nico","Noa", "Gerard", "Nor"};
        int[] canicas = {12,3,25,31,6,11,21,9};
        string[] ciutat = {"Vilanova", "Canyelles", "Vilanova", "Sitges", "Cunit", "Vilanova", "Kazahstan", "Cubelles"};

        for (;;){
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
                Console.WriteLine("No se ha podido encontrar un niño con ese nombre!");
            } else
            {
                Console.WriteLine("Se ha encontrado!");
                canicas[posicion] = subMenu(nens, canicas, ciutat, posicion);
            }
        }
    }
}