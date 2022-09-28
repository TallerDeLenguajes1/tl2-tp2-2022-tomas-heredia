using System;

using System.Net;
using System.IO;  // para archivos csv
using LectorCSV;
using punto4;
using NLog;
  NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

Console.WriteLine("hola mundos");
      string Atletismo = "Atletismo.csv";  
      string Voley = "Voley.csv";  
      string Futbol = "Futbol.csv";  
    Alumno nuevo = new Alumno();
    List<Alumno> L_Atletismo = new List<Alumno>();
    List<Alumno> L_Voley = new List<Alumno>();
    List<Alumno> L_Futbol = new List<Alumno>();
    int cantidad = 0;
    try
    {
        
       Console.WriteLine("Ingrese el numero de alumnos de Atletismo.");
         cantidad =  Convert.ToInt32(Console.ReadLine()); 
    }
    catch (System.Exception)
    {
        Console.WriteLine("Dato ingresado incorrecto.");
        logger.Error("se ingreso un valro no esperado en cantidad de atletismo.");
    }
    for (int i = 0; i < cantidad; i++)
    {
         try
            {
                logger.Info("Se guardaron lso alumnos de atletismo.");
                Console.WriteLine("Ingrese el DNI.");
                int dni =  Convert.ToInt32(Console.ReadLine()); 
                nuevo.Dni = dni;
                
                Console.WriteLine("Ingrese el Apellido");
                string apellido =  Console.ReadLine();
                nuevo.Apellido = apellido; 

                Console.WriteLine("Ingrese el Nombre");
                string nombre =  Console.ReadLine(); 
                nuevo.Nombre = nombre;
                nuevo.Curso = "Atletismo";

                L_Atletismo.Add(nuevo);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Dato ingresado incorrecto.");
                logger.Error("se ingreso un valro no esperado en la carga de alumnos.");
            }
            
    }

    try
    {
       Console.WriteLine("Ingrese el numero de alumnos de Voley.");
         cantidad =  Convert.ToInt32(Console.ReadLine()); 
    }
    catch (System.Exception)
    {
        Console.WriteLine("Dato ingresado incorrecto.");
        logger.Error("se ingreso un valro no esperado en cantidad de Voley.");
    }
    for (int i = 0; i < cantidad; i++)
    {
         try
            {
                logger.Info("Se guardaron lso alumnos de Voley.");
                Console.WriteLine("Ingrese el DNI.");
                int dni =  Convert.ToInt32(Console.ReadLine()); 
                nuevo.Dni = dni;

                Console.WriteLine("Ingrese el Apellido");
                string apellido =  Console.ReadLine();
                nuevo.Apellido = apellido; 

                Console.WriteLine("Ingrese el Nombre");
                string nombre =  Console.ReadLine(); 
                nuevo.Nombre = nombre;
                nuevo.Curso = "Voley";
                L_Voley.Add(nuevo);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Dato ingresado incorrecto.");
                logger.Error("se ingreso un valro no esperado en la carga de alumnos.");
            }
            
    }
 
    try
    {
       Console.WriteLine("Ingrese el numero de alumnos de Futbol.");
         cantidad =  Convert.ToInt32(Console.ReadLine()); 
    }
    catch (System.Exception)
    {
        Console.WriteLine("Dato ingresado incorrecto.");
        logger.Error("se ingreso un valro no esperado en cantidad de Futbol.");
    }
    for (int i = 0; i < cantidad; i++)
    {
         try
            {
                logger.Info("Se guardaron lso alumnos de Futbol.");
                Console.WriteLine("Ingrese el DNI.");
                int dni =  Convert.ToInt32(Console.ReadLine()); 
                nuevo.Dni = dni;

                Console.WriteLine("Ingrese el Apellido");
                string apellido =  Console.ReadLine();
                nuevo.Apellido = apellido; 

                Console.WriteLine("Ingrese el Nombre");
                string nombre =  Console.ReadLine(); 
                nuevo.Nombre = nombre;
                nuevo.Curso = "Futbol";
                L_Futbol.Add(nuevo);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Dato ingresado incorrecto.");
                logger.Error("se ingreso un valro no esperado en la carga de alumnos.");
            }
            
    }
    HelperCsv archivo = new HelperCsv();
    logger.Info("se ingreso las listas a los .csv.");
    archivo.EscribirLinea(L_Atletismo,Atletismo);
    archivo.EscribirLinea(L_Voley,Voley);
    archivo.EscribirLinea(L_Futbol,Futbol); 