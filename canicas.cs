using System;

class MainClass {
        
    public static void Menu (string[] nens, int[] canicas, string[] ciutat) {
        Console.WriteLine("Escribe tu nombre:");
        string nombre = Console.ReadLine();

        int posicion = 0;
        int encontrado = 0;
        for (int n = 0; n < nens.length; n++)
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
        }
    }

    public static void Main () {
        string[] nens = {"Joan", "Nil", "Roc", "Thiago", "Nico","Noa", "Gerard", "Nor"};
        int[] canicas = {12,3,25,31,6,11,21,9};
        string[] ciutat = {"Vilanova", "Canyelles", "Vilanova", "Sitges", "Cunit", "Vilanova", "Kazahstan", "Cubelles"};
        Menu(nens, canicas, ciutat);
    }
}