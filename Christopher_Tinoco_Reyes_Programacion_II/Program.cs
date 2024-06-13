using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christopher_Tinoco_Reyes_Programacion_II
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            string buscar = "";
            int opcion = 0;
            string acceso;
          

            string[] nombre = new string[10000];
            string[] direccion = new string[10000];
            string[] correo = new string[10000];
            string[] telefono = new string[10000];

            int posicionAgregar = 0;
           

            do
            {
                Console.WriteLine("------------------BIENVENIDO------------------");
                Console.WriteLine("");
                Console.WriteLine("Digite (1) para registrar un cliente nuevo.");
                Console.WriteLine("");
                Console.WriteLine("Digite (2) para eliminar el registro de  un cliente.");
                Console.WriteLine("");
                Console.WriteLine("Digite (3) para realizar una busqueda.");
                Console.WriteLine("");
                Console.WriteLine("Digite (4) para mostrar todos los registro.");
                Console.WriteLine("");
                Console.WriteLine("Digite (5) para realizar una modificacion.");
                Console.WriteLine("");
                Console.WriteLine("Digite (6) para salir del sistema.");

                acceso = Console.ReadLine();


                if (int.TryParse(acceso, out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el nombre completo del cliente.");
                            nombre[posicionAgregar] = Console.ReadLine();
                            Console.WriteLine("");

                            Console.WriteLine("Ingrese la direccion del cliente.");
                            direccion[posicionAgregar] = Console.ReadLine();
                            Console.WriteLine("");

                            Console.WriteLine("Ingrese el numero de telefono del cliente.");
                            telefono[posicionAgregar] = Console.ReadLine();
                            Console.WriteLine("");

                            Console.WriteLine("Ingrese la direccion de correo electronico del cliente.");
                            correo[posicionAgregar] = Console.ReadLine();
                            Console.WriteLine("");

                            posicionAgregar++;
                            break;
                        
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese el nombre del cliente que desea borrar:");
                            buscar = Console.ReadLine();
                            for (int i = 0; i < posicionAgregar; i++) 
                            {
                                if (nombre[i] == buscar)
                                {
                                    nombre[i] = null;
                                    direccion[i] = null;
                                    telefono[i] = null;
                                    correo[i] = null;
  
                                    
                                }

                            

                            }


                           break;

                        case 3:
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese el nombre del cliente solicitado:");
                            buscar = Console.ReadLine();
                            Console.WriteLine("");

                            for (int i = 0; i < posicionAgregar; i++)
                            {
                                if (nombre[i] == buscar)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine($"Nombre del cliente: {nombre[i]}");
                                    Console.WriteLine($"La direccion del  cliente: {direccion[i]}");
                                    Console.WriteLine($"EL telefono del cliente: {telefono[i]}");
                                    Console.WriteLine($"El correo electronico del cliente: {correo[i]}");
                                    Console.WriteLine("");

                                }
                               
                            }             

                                
                            break;

                        case 4:
                            Console.WriteLine("");
                            Console.WriteLine("******************************************************");

                            for (int i = 0; i < posicionAgregar; i++)
                            {
                                if (nombre[i] != null) 
                                {
                                    Console.WriteLine($"Nombre del cliente: {nombre[i]}");
                                    Console.WriteLine($"La direccion del  cliente: {direccion[i]}");
                                    Console.WriteLine($"EL telefono del cliente: {telefono[i]}");
                                    Console.WriteLine($"El correo electronico del cliente: {correo[i]}");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                }



                            }
                            Console.WriteLine("******************************************************");
                            Console.WriteLine("");
                            break;
                      
                        case 5:
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese el nombre del cliente que desea modificar:");
                            buscar = Console.ReadLine();
                            Console.WriteLine("");

                            for (int i = 0; i < posicionAgregar; i++)
                            {
                                if (nombre[i] == buscar)
                                {
                                    Console.WriteLine("Ingrese el nuevo nombre  del cliente.");
                                    nombre[i] = Console.ReadLine();
                                    Console.WriteLine("");

                                    Console.WriteLine("Ingrese la nueva direccion del cliente.");
                                    direccion[i] = Console.ReadLine();
                                    Console.WriteLine("");

                                    Console.WriteLine("Ingrese el nuevo numero de telefono del cliente.");
                                    telefono[i] = Console.ReadLine();
                                    Console.WriteLine("");

                                    Console.WriteLine("Ingrese la nueva direccion de correo electronico del cliente.");
                                    correo[i] = Console.ReadLine();
                                    Console.WriteLine("");
                                }

                            }


                            break;


                    }
                }
              
               
            } while (opcion != 6);
            Console.WriteLine("");
            Console.WriteLine("");Console.WriteLine("------------------USTED A SALIDO DEL SISTEMA------------------");
            Console.Read();
        }
    }
}
