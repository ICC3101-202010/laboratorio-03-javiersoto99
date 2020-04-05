using System;
using System.Collections.Generic;
using System.Linq;

namespace lab3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Bienvenido al Software para el control del Supermercado");
            int cargo = 0;
            List<string> listaproductos = new List<string>();
            while (cargo != 5)
            {
                Console.WriteLine("Cual es su Puesto de Trabajo: ");
                Console.WriteLine("1.- Jefe");
                Console.WriteLine("2.- Supervisor");
                Console.WriteLine("3.- Cajero");
                Console.WriteLine("4.- Auxiliar");
                Console.WriteLine("5.- Salir del Software");
                cargo = Convert.ToInt32(Console.ReadLine());
                if (cargo == 1 || cargo == 2 || cargo == 3 || cargo == 4 || cargo == 5)
                {
                    
                    if (cargo == 1)
                    {
                        int funcionjefe = 0;
                        Console.WriteLine("Elija una funcion: ");
                        Console.WriteLine("");
                        Console.WriteLine("1.- Agregar Producto");
                        Console.WriteLine("2.- Ver Productos");
                        Console.WriteLine("3.- Ajustes Personal de Trabajo");
                        Console.WriteLine("4.- Realizar Compra");

                        funcionjefe = Convert.ToInt32(Console.ReadLine());
                        if (funcionjefe == 1 || funcionjefe == 2 || funcionjefe == 3 || funcionjefe == 4)
                        {
                            if (funcionjefe == 1)
                            {
                                
                                Console.WriteLine("Ingrese el Nombre del producto: ");
                                string nombreProducto = Console.ReadLine();

                                Console.WriteLine("Ingrese la Marca del producto: ");
                                string marcaProducto = Console.ReadLine();


                                Console.WriteLine("Ingrese el Precio del producto: ");
                                int precioProducto = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Ingrese el Stock del producto");
                                int stockProducto = Convert.ToInt32(Console.ReadLine());

                                var producto = new Producto(nombreProducto, marcaProducto, precioProducto, stockProducto);
                                listaproductos.Add(producto.Informacion());

                            }
                            else if (funcionjefe == 2)
                            {
                                if (listaproductos.Count() == 0)
                                {
                                    Console.WriteLine("Por el momento no hay Productos");
                                }
                                else
                                {
                                    Console.WriteLine(listaproductos.Count +"  " + "Productos: ");
                                    foreach (string i in listaproductos)
                                    {
                                        Console.WriteLine(i);
                                    }
                                }


                            }
                            else if (funcionjefe == 3)
                            {
                                Console.WriteLine("opcion 3");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Funcion invalida, intente de nuevo");
                        }





                    }
                    else if (cargo == 2)
                    {
                        int funcionsv = 0;
                        Console.WriteLine("Elija una funcion: ");
                        Console.WriteLine("");
                        Console.WriteLine("1.- Agregar Producto");
                        Console.WriteLine("2.- Ver Productos");
                        Console.WriteLine("3.- Realizar Compra");

                        funcionsv = Convert.ToInt32(Console.ReadLine());
                        if (funcionsv == 1 || funcionsv == 2 || funcionsv == 3)
                        {
                            if (funcionsv == 1)
                            {
                                Console.WriteLine("Ingrese el Nombre del producto: ");
                                string nombreProducto = Console.ReadLine();

                                Console.WriteLine("Ingrese la Marca del producto: ");
                                string marcaProducto = Console.ReadLine();


                                Console.WriteLine("Ingrese el Precio del producto: ");
                                int precioProducto = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Ingrese el Stock del producto");
                                int stockProducto = Convert.ToInt32(Console.ReadLine());

                                var producto = new Producto(nombreProducto, marcaProducto, precioProducto, stockProducto);
                                
                                listaproductos.Add(producto.Informacion());

                            }
                            else if (funcionsv == 2)
                            {

                                if (listaproductos.Count() == 0)
                                {
                                    Console.WriteLine("Por el momento no hay Productos");
                                }
                                else
                                {
                                    Console.WriteLine(listaproductos.Count + "  " + "Productos: ");
                                    foreach (string i in listaproductos)
                                    {
                                        Console.WriteLine(i);
                                    }
                                }

                            }
                            else if(funcionsv == 3)
                            {

                            }


                        }
                        else
                        {
                            Console.WriteLine("Funcion invalida, intente de nuevo");
                        }






                    }
                    else if (cargo == 3)
                    {
                        int funcioncaj = 0;
                        Console.WriteLine("Elija una funcion: ");
                        Console.WriteLine("");
                        Console.WriteLine("1.- Realizar Compra");
                        Console.WriteLine("2.- Ver Productos");

                        funcioncaj = Convert.ToInt32(Console.ReadLine());
                        if (funcioncaj == 1 || funcioncaj == 2)
                        {
                            if (funcioncaj == 1)
                            {


                            }
                            else if (funcioncaj == 2)
                            {
                                if (listaproductos.Count() == 0)
                                {
                                    Console.WriteLine("Por el momento no hay Productos");
                                }
                                else
                                {
                                    Console.WriteLine(listaproductos.Count + "  " + "Productos: ");
                                    foreach (string i in listaproductos)
                                    {
                                        Console.WriteLine(i);
                                    }
                                }


                            }

                        }
                        else
                        {
                            Console.WriteLine("Funcion invalida, intente de nuevo");
                        }






                    }
                    else if (cargo == 4)
                    {
                        int funcionaux = 0;
                        Console.WriteLine("Elija una funcion: ");
                        Console.WriteLine("");
                        Console.WriteLine("1.- Ver Productos");
                        funcionaux = Convert.ToInt32(Console.ReadLine());
                        if (funcionaux == 1)
                        {
                            if (listaproductos.Count() == 0)
                            {
                                Console.WriteLine("Por el momento no hay Productos");
                            }
                            else
                            {
                                Console.WriteLine(listaproductos.Count + "  " + "Productos: ");
                                foreach (string i in listaproductos)
                                {
                                    Console.WriteLine(i);
                                }
                            }


                        }
                        else
                        {
                            Console.WriteLine("Funcion invalida, intente de nuevo");
                        }


                    }
                    else if(cargo == 5)
                    {
                        continue;
                    }

                }
                else
                {
                    Console.WriteLine("Puesto de Trabajo Invalido ... Intentelo de nuevo");
                }



            }
            Console.WriteLine("Cerrando Software...");

        }
    }
}
