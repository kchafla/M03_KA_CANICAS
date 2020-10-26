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
    }

    class MainClass {
        public static void Main (string[] args) {
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

            Console.WriteLine("Escribe tu nombre:");
            string nombre = Console.ReadLine();
            
            foreach (Canica usuario in usuarios) {
                if (String.Equals(nombre,usuario.nombre)) {
                    usuario.mostrarCanicas();

                    Console.WriteLine("\nCuantas canicas tienes ahora?");
                    int canicasActuales = Convert.ToInt32(Console.ReadLine());

                    usuario.canicas = canicasActuales;
                }
            }
        }
    }
}