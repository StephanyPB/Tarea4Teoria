using System;
using System.Collections.Generic;

namespace Tarea4Teoria
{
    class Program
    {
        static void Main(string[] args)
        {

            int op = 0;
            while (op != 3)
            {
                Console.Clear();
                Console.WriteLine(" \n 1- Capitulo 7 \n 2-Capitulo 8 \n  3- Salir \nElija una Opcion: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(" \n 1- Ejercicio 1 \n 2-Ejercicio 5   \n 3- Salir \n Elija una Opcion: ");
                        int opc = int.Parse(Console.ReadLine());
                        if (opc == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Digite el dia actual: ");
                            int dia = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite el numero del mes actual: ");
                            int mes = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite el year actual: ");
                            int year = int.Parse(Console.ReadLine());
                            DateTime thisDate1 = new DateTime(year, mes, dia);
                            Console.WriteLine("Hoy is " + thisDate1.ToString("MMMM dd, yyyy") + ".");
                            Console.ReadLine();

                        }

                        else if (opc == 2)
                        {
                            Console.Clear();
                            List<string> lista = new List<string>();
                            Console.Clear();
                            Console.WriteLine("Digite una cadena: ");
                            string cadena1 = Console.ReadLine();
                            Console.WriteLine("Digite otra cadena ");
                            string cadena2 = Console.ReadLine();

                            lista.Add(cadena1);
                            lista.Add(cadena2);

                            lista.Sort();
                            foreach (var item in lista)
                            {
                                Console.WriteLine("Cadenas Ordenadas Alfabeticamente: " + item);
                            }

                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(" \n 1- Ejercicio 1 \n 2-Ejercicio 3   \n 3- Ejericio 4 \n4- Salir\n Elija una Opcion: ");
                        int eligio = int.Parse(Console.ReadLine());
                        if (eligio == 1)
                        {
                            EstructuraTienda();
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (eligio == 2)
                        {
                            GuardarDatosMascota();
                            Console.ReadLine();
                            Console.Clear();

                        }
                        break;

                }

            }

        }

        public struct Tienda
        {
            public String Nombre;
            public double Precio;
            public int Cantidad;
        }
        public static void EstructuraTienda()
        {

            Console.Clear();
            Console.WriteLine("Digite la cantidad de productos: ");
            int cantidad = int.Parse(Console.ReadLine());
            int i = 0;
            Tienda[] tiendita = new Tienda[cantidad];
            for (i = 0; i < cantidad; i++)
            {
                Console.Clear();
                Console.WriteLine("Digite el nombre del producto: ");
                tiendita[i].Nombre = Console.ReadLine();
                Console.WriteLine("Digite el precio del producto: ");
                tiendita[i].Precio = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite la cantidad del producto: ");
                tiendita[i].Cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Productos Guardos. \n");
                Console.Clear();
                for (int j = 0; j < cantidad; j++)
                {
                    Console.WriteLine("Producto: " + tiendita[i].Nombre + "Precio: " + tiendita[i].Precio + "Cantidad: " + tiendita[i].Cantidad + "\n");
                }
            }
        }
        public struct Dueno
        {
            public string Nombre;
            public string Direccion;
            public int Edad;
            public Mascota mascota;
        }

        public struct Mascota
        {
            public string NombreD;
            public string Tipo;
            public string Raza;
        }

        public static void GuardarDatosMascota()
        {
            Dueno dueno;
            Console.Clear();   
        
            Console.WriteLine("Digite el nombre el dueno de la mascota: ");
            dueno.Nombre = Console.ReadLine();
            Console.WriteLine("Digite direccion del dueno de la mascota: ");
            dueno.Direccion = Console.ReadLine();
            Console.WriteLine("Digite la edad del dueno de la mascota: ");
            dueno.Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el nombre de la mascota: ");
            dueno.mascota.NombreD = Console.ReadLine();
            Console.WriteLine("Digite el tipo  la mascota: ");
            dueno.mascota.Tipo = Console.ReadLine();
            Console.WriteLine("Digite la raza de la mascota: ");
            dueno.mascota.Raza = Console.ReadLine();
            Console.WriteLine("Informacion Guardada. \n");
            Console.Clear();
                
           Console.WriteLine("Dueno: " + dueno.Nombre +"\n"+ "Direccion: " + dueno.Direccion + "\n"+"Edad: " + dueno.Edad + "\n"+"Nombre de la mascota: " +
           dueno.mascota.NombreD +"\n" +"Tipo de mascota: "+dueno.mascota.Tipo + "\n"+"Raza de la mascota: "+ dueno.mascota.Raza+ "\n");
   
        }

         enum Neumatico
        {
            Neumatico_Diagonal,
            Neumatico_de_Verano,
            Neumatico_de_Invierno,
            Neumatico_Radial,
            Neumatico_AllSeasons, 
            Neumatico_de_Perfil_Bajo,
            Neumatico_Recauchutado,
            Neumatico_Runflat,
            Neumatico_Ecologicos,
            Neumatico_Asimetrico,
            Neumatico_Direccional,
            Neumatico_Tubeless
          
        }

    }
}


