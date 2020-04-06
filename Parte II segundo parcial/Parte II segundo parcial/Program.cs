using System;
using System.Collections;

namespace Parte_II_segundo_parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Hashtable datos = new Hashtable();
            bool flag = true;

            while (flag)
            {
                Console.Clear();
                Console.WriteLine("Elige una opcion");
                Console.WriteLine("\n");
                Console.WriteLine("1)Agregar Datos");
                Console.WriteLine("2)Actualizar Datos");
                Console.WriteLine("3)Eliminar Datos");
                Console.WriteLine("4)Mostrar Todos los datos");
                Console.WriteLine("5)Consultar Datos");
                

                switch (Console.ReadLine())
                {
                    case "1":
                        bool v1 = false;
                        string n1 = null;
                        while (!(v1))
                        {

                            Console.WriteLine("Ingrese DUI");
                            string dui = Console.ReadLine();
                            Console.WriteLine("Ingrese Nombre");
                            string nombre = Console.ReadLine();
                            datos.Add(dui, nombre);
                            v1 = true;
                        }
                        break;

                    case "2":
                        bool v2 = false;
                        string n2 = null;
                        while (!(v2))
                        {
                            Console.WriteLine("Ingresar DUI que desea modificar");
                            string dui2 = Console.ReadLine();
                            Console.WriteLine("Ingresar nombre modificado");
                            string nnombre = Console.ReadLine();
                            datos[dui2] = nnombre;
                            Console.WriteLine("Cambiando Nombre asociado a DUI: {0}", dui2);
                            Console.WriteLine("Para el DUI: {0}, nuevo Nombre: {1}", dui2, datos[dui2]);
                            v2 = true;
                        }

                        break;

                    case "3":
                        bool v3 = false;
                        string n3 = null;
                        while (!(v3))
                        {
                            Console.WriteLine("Ingresar DUI que desea remover");
                            string dui3 = Console.ReadLine();
                            Console.WriteLine("Remover: {0}", dui3);
                            datos.Remove(dui3);
                            v3 = true;
                            //Console.WriteLine("Verificando que ya no se encuentre el valor en la tabla");
                            //if (datos.ContainsKey(dui3))
                            //{
                            //    Console.WriteLine("Clave: {0} no encontrada", dui3);
                            //    v3 = true;
                            //}
                            
                        }
                        break;

                    case "4":
                        bool v4 = false;
                        string n4 = null;
                        while (!(v4))
                        {
                            ICollection valuecoll = datos.Values;
                            Console.WriteLine();
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine("Imprimiendo los valores de la tabla");
                            foreach (string s in valuecoll)
                            {
                                Console.WriteLine("Value = {0}", s);
                                v4 = true;
                            }
                            
                        }

                        break;

                    case "5":
                        bool v5 = false;
                        string n5 = null;
                        while (!(v5))
                        {
                            Console.WriteLine("Ingresar DUI del cual desea informacion");
                            string DUI5 = Console.ReadLine();
                            Console.WriteLine("Para el DUI: {0} el propietario es:{1}", DUI5, datos[DUI5]);
                            v5 = true;
                        }

                        break;

                    
                }

                Console.ReadKey();

            }

        }
    }
}
