using System;
using System.Collections.Generic;

namespace Estructura_canicas
{
    struct Canica {
        public string nombre;
        public int canicas;
        public string ciudad;

        public Canica(string nombre, int canicas, string ciudad) {
            this.nombre = nombre;
            this.canicas = canicas;
            this.ciudad = ciudad;
        }

        public void mostrarCanicas() {
            Console.WriteLine("\nEstos son tus datos:");
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Canicas: " + this.canicas);
            Console.WriteLine("Ciudad: " + this.ciudad);
        }

        public void modificarCanicas(int canicasActuales) {
            new Canica(this.nombre, canicasActuales, this.ciudad);
        }
    }

    class MainClass {
        public static void Main () {
            Canica[] agregarUsuarios = {
                new Canica("Joan", 12, "Vilanova"),
                new Canica("Nil", 3, "Canyelles"),
                new Canica("Roc", 25, "Vilanova"),
                new Canica("Thiago", 31, "Sitges"),
                new Canica("Nico", 6, "Cunit"),
                new Canica("Noa", 11, "Vilanova"),
                new Canica("Gerard", 21, "Kazakhstan"),
                new Canica("Nor", 9, "Cubelles")
            };

            List<Canica> usuarios = new List <Canica>(agregarUsuarios);

            while (true)
            {
                Console.WriteLine("\nQue quieres hacer?\n1. Mostrar tus canicas.\n2. Modificar tus canicas.");
                int opcion = Convert.ToInt32(Console.ReadLine());
                
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nEscribe tu nombre:");
                        string nombre = Console.ReadLine();
                        
                        foreach (Canica usuario in usuarios) {
                            if (String.Equals(nombre,usuario.nombre)) {
                                usuario.mostrarCanicas();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nEscribe tu nombre:");
                        string nom = Console.ReadLine();

                        Console.WriteLine("\nEscribe tus canicas:");
                        int actual = Convert.ToInt32(Console.ReadLine());

                        foreach (Canica usuario in usuarios) {
                            if (String.Equals(nom,usuario.nombre)) {
                                usuario.modificarCanicas(actual);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("\nElije una opcion!\n");
                        break;
                }
            }
        }
    }
}