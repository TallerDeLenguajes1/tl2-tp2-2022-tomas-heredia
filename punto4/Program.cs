using System;

using System.Net;
using System.IO;  // para archivos csv
using LectorCSV;
using punto4;

    public  string Atletismo = @"G:\taller2\tl2-tp2-2022-tomas-heredia\punto4\Atletismo.csv";  
    public  string Voley = @"G:\taller2\tl2-tp2-2022-tomas-heredia\punto4\Voley.csv";  
    public  string Futbol = @"G:\taller2\tl2-tp2-2022-tomas-heredia\punto4\Futbol.csv";  
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
        
    }
    for (int i = 0; i < cantidad; i++)
    {
         try
            {
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
        
    }
    for (int i = 0; i < cantidad; i++)
    {
         try
            {
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
        
    }
    for (int i = 0; i < cantidad; i++)
    {
         try
            {
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
                
            }
            
    }

    archivoCSV(L_Atletismo,Atletismo);
    archivoCSV(L_Voley,Voley);
    archivoCSV(L_Futbol,Futbol);