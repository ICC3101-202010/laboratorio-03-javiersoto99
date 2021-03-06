﻿using System;
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
            List<int> listacodigos = new List<int>();
            List<string> listasupervisores = new List<string>();
            List<string> listacajeros = new List<string>();
            List<string> listaauxiliares = new List<string>();
            List<string> listaproductos = new List<string>();
            List<int> listacajas = new List<int>();
            List<string> listaventas = new List<string>();
            
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
                        Console.WriteLine("Hola Jefe. Elija una funcion: ");
                        Console.WriteLine("");
                        Console.WriteLine("1.- Agregar Producto");
                        Console.WriteLine("2.- Ver Productos");
                        Console.WriteLine("3.- Ajustes Personal de Trabajo");
                        Console.WriteLine("4.- Ver Ventas del Supermercado");
                      

                        funcionjefe = Convert.ToInt32(Console.ReadLine());
                        if (funcionjefe == 1 || funcionjefe == 2 || funcionjefe == 3 || funcionjefe ==4 )
                        {
                            if (funcionjefe == 1)
                            {
                                
                                Console.WriteLine("Ingrese el Nombre del producto: ");
                                string nombreProducto = Console.ReadLine();

                                Console.WriteLine("Ingrese la Marca del producto: ");
                                string marcaProducto = Console.ReadLine();


                                Console.WriteLine("Ingrese el Precio del producto: ");
                                int precioProducto = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Ingrese el Stock del producto: ");
                                int stockProducto = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Ingrese codigo del producto (en numeros(ej. 199)): ");

                                int codigoProducto = Convert.ToInt32(Console.ReadLine());

                                listacodigos.Add(codigoProducto);
                                

                                var producto = new Producto(nombreProducto, marcaProducto, precioProducto, stockProducto, codigoProducto);
                                listaproductos.Add(producto.Informacion());

                            }
                            else if (funcionjefe == 2) //Ver Productos
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
                            else if (funcionjefe == 3) //Ajuste de Personal
                            {
                                int ajefe = 0;
                                Console.WriteLine("Que tipo de Ajuste quiere realizar?");
                                Console.WriteLine("1.- Contratar Trabajador ");
                                Console.WriteLine("2.- Ver Tranajadores");
                                Console.WriteLine("3.- Cambiar Sueldo de Trabajador");
                                Console.WriteLine("4.- Cambiar Horario de Trabajador");
                                ajefe = Convert.ToInt32(Console.ReadLine());
                                if (ajefe == 1 || ajefe == 2 || ajefe == 3 || ajefe == 4)
                                {
                                    if(ajefe == 1)
                                    {
                                        Console.WriteLine("Ingrese datos del nuevo Trabajador");
                                        Console.WriteLine("Nombre");
                                        string nombreTrabajador = Console.ReadLine();
                                        Console.WriteLine("Apellido: ");
                                        string apellidoTrabajador = Console.ReadLine();
                                        Console.WriteLine("RUT:");
                                        int rutTrabajador = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Nacionalidad: ");
                                        string nacionTrabajador = Console.ReadLine();
                                        Console.WriteLine("Fecha de Nacimiento (xx/xx/xx) :");
                                        string fdnTrabajador = Console.ReadLine();
                                        Console.WriteLine("Salario: ");
                                        int salarioTrabajador = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Horario : ejemplo (8:00 - 15:00)");
                                        string horarioTrabajador = Console.ReadLine();

                                        var persona = new Persona(nombreTrabajador, apellidoTrabajador, rutTrabajador, nacionTrabajador, fdnTrabajador);
                                        var trabajador = new Trabajador(nombreTrabajador, apellidoTrabajador, rutTrabajador, nacionTrabajador, fdnTrabajador, salarioTrabajador, horarioTrabajador);
                                        
                                        int contra = 0;
                                        Console.WriteLine("Que tipo de Cargo tiene: ");
                                        Console.WriteLine("1. Supervisor");
                                        Console.WriteLine("2.- Cajero");
                                        Console.WriteLine("3.- Auxiliar");
                                        contra = Convert.ToInt32(Console.ReadLine());
                                        if (contra == 1 || contra == 2 || contra == 3)
                                        {
                                            if(contra == 1)
                                            {
                                                Console.WriteLine("Ingrese sector de Supervision: ");
                                                string sectorTrabajador = Console.ReadLine();
                                                var supervisorContratado = new Supervisor(nombreTrabajador, apellidoTrabajador, rutTrabajador, nacionTrabajador, fdnTrabajador, salarioTrabajador, horarioTrabajador, sectorTrabajador);
                                                
                                                listasupervisores.Add(supervisorContratado.InfoSV());

                                            }
                                            else if(contra == 2)
                                            {
                                                Console.WriteLine("Ingrese numero de Cajero donde va a trabajar: ");
                                                int cajaTrabajador = Convert.ToInt32(Console.ReadLine());
                                                var cajeroContratado = new Cajero(nombreTrabajador, apellidoTrabajador, rutTrabajador, nacionTrabajador, fdnTrabajador, salarioTrabajador, horarioTrabajador, cajaTrabajador);
                                                
                                                listacajeros.Add(cajeroContratado.InfoCaj());
                                            }
                                            else if(contra == 3)
                                            {
                                                Console.WriteLine("Ingrese numero de Pasillo donde va a trabajar: ");
                                                int pasilloTrabajador = Convert.ToInt32(Console.ReadLine());
                                                var auxContratado = new Auxiliar(nombreTrabajador, apellidoTrabajador, rutTrabajador, nacionTrabajador, fdnTrabajador, salarioTrabajador, horarioTrabajador, pasilloTrabajador);

                                                listaauxiliares.Add(auxContratado.InfoAux());
                                            }
                                        }
                                        

                                    }
                                    else if(ajefe == 2)
                                    {
                                        Console.WriteLine(listasupervisores.Count + " Supervisores: ");
                                        foreach(string i in listasupervisores)
                                        {
                                            Console.WriteLine(i);
                                        }
                                        Console.WriteLine(listacajeros.Count + " Cajeros: ");
                                        foreach (string i in listacajeros)
                                        {
                                            Console.WriteLine(i);
                                        }
                                        Console.WriteLine(listaauxiliares.Count + " Auxiliares: ");
                                        foreach (string i in listaauxiliares)
                                        {
                                            Console.WriteLine(i);
                                        }
                                    }
                                    else if(ajefe == 3)
                                    {
                                        Console.WriteLine("No tenemos esa funcion todavia");
                                    }
                                    else if (ajefe == 4)
                                    {
                                        Console.WriteLine("No tenemos esa funcion todavia");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ajuste invalido");
                                }
                            }
                            else if(funcionjefe == 4)
                            {
                                if(listaventas.Count == 0)
                                {
                                    Console.WriteLine("No hay ventas por el momento");
                                }
                                else
                                {
                                    for (int i = 0; i < listaventas.Count; i++)
                                    {
                                        Console.WriteLine(listaventas[i]);

                                    }
                                }
                               
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
                        Console.WriteLine("Hola Supervisor. Elija una funcion: ");
                        Console.WriteLine("");
                        Console.WriteLine("1.- Agregar Producto");
                        Console.WriteLine("2.- Ver Productos");
                        Console.WriteLine("3.- Realizar Venta");
                        Console.WriteLine("4.- Ver ventas del Supermercado");

                        funcionsv = Convert.ToInt32(Console.ReadLine());
                        if (funcionsv == 1 || funcionsv == 2 || funcionsv == 3 || funcionsv == 4)
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

                                Console.WriteLine("Ingrese codigo del producto (en numeros(ej. 199)): ");

                                int codigoProducto = Convert.ToInt32(Console.ReadLine());

                                listacodigos.Add(codigoProducto);


                                var producto = new Producto(nombreProducto, marcaProducto, precioProducto, stockProducto, codigoProducto);
                                
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
                                Console.WriteLine("Ingrese hora actual: ");
                                Console.WriteLine("Ingrese hora actual: ");
                                Console.WriteLine("De que caja esta operando...");
                                
                                foreach (int i in listacajas)
                                {
                                    Console.WriteLine("Caja " + listacajas[i]);
                                }
                                Console.WriteLine("Numero de Caja: ");
                                int numeroCaja = Convert.ToInt32(Console.ReadLine());
                                string hora = Console.ReadLine();
                                Console.WriteLine("Ingrese datos del cliente: ");
                                Console.WriteLine("Nombre: ");
                                string nombreCliente = Console.ReadLine();
                                Console.WriteLine("Apellido: ");
                                string apellidoCliente = Console.ReadLine();
                                Console.WriteLine("RUT: ");
                                int rutCliente = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Nacionalidad: ");
                                string nacionCliente = Console.ReadLine();
                                Console.WriteLine("Fecha de Nacimiento (xx/xx/xx): ");
                                string fdnCliente = Console.ReadLine();

                                var cliente = new Persona(nombreCliente, apellidoCliente, rutCliente, nacionCliente, fdnCliente);

                                Console.WriteLine("Para Scanear codigo del Producto aprente ENTER");
                                string enter = Console.ReadLine();
                                int randomInt = new Random().Next(0, listacodigos.Count);
                              
                                Console.WriteLine("El cliente esta comprando: ");
                                Console.WriteLine(listaproductos[randomInt]);
                                Console.WriteLine("ENTER para finalizar venta");
                                string enter2 = Console.ReadLine();
                                listaventas.Add("CAJA: " + numeroCaja);
                                listaventas.Add("CLIENTE: " + cliente.InfoPer());
                                listaventas.Add("PRODUCTO: " + listaproductos[randomInt]);
                            }
                            else if (funcionsv == 4)
                            {
                                if (listaventas.Count == 0)
                                {
                                    Console.WriteLine("No hay ventas por el momento");
                                }
                                else
                                {
                                    for (int i = 0; i < listaventas.Count; i++)
                                    {
                                        Console.WriteLine(listaventas[i]);

                                    }
                                }
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
                        Console.WriteLine("Hola Cajero. Elija una funcion: ");
                        Console.WriteLine("");
                        Console.WriteLine("1.- Realizar Venta");
                        Console.WriteLine("2.- Ver Productos");

                        funcioncaj = Convert.ToInt32(Console.ReadLine());
                        if (funcioncaj == 1 || funcioncaj == 2)
                        {
                            if (funcioncaj == 1)
                            {

                                Console.WriteLine("Ingrese hora actual: ");
                                Console.WriteLine("De que caja esta operando...");
                                foreach(int i in listacajas)
                                {
                                    Console.WriteLine("Caja " + listacajas[i]);
                                }
                                Console.WriteLine("Numero de Caja: ");
                                int numeroCaja = Convert.ToInt32(Console.ReadLine());
                                string hora = Console.ReadLine();
                                Console.WriteLine("Ingrese datos del cliente: ");
                                Console.WriteLine("Nombre: ");
                                string nombreCliente = Console.ReadLine();
                                Console.WriteLine("Apellido: ");
                                string apellidoCliente = Console.ReadLine();
                                Console.WriteLine("RUT: ");
                                int rutCliente = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Nacionalidad: ");
                                string nacionCliente = Console.ReadLine();
                                Console.WriteLine("Fecha de Nacimiento (xx/xx/xx): ");
                                string fdnCliente = Console.ReadLine();

                                var cliente = new Persona(nombreCliente, apellidoCliente, rutCliente, nacionCliente, fdnCliente);

                                Console.WriteLine("Para Scanear codigo del Producto aprente ENTER");
                                string enter = Console.ReadLine();
                                int randomInt = new Random().Next(0, listacodigos.Count);
                                
                                Console.WriteLine("El cliente esta comprando: ");
                                Console.WriteLine(listaproductos[randomInt]);
                                 
                                Console.WriteLine("ENTER para finalizar venta");
                                string enter2 = Console.ReadLine();
                                listaventas.Add("CAJA: " + numeroCaja);
                                listaventas.Add("CLIENTE: " + cliente.InfoPer());
                                listaventas.Add("PRODUCTO: " + listaproductos[randomInt]);


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
                        Console.WriteLine("Hola Auxiliar. Elija una funcion: ");
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
