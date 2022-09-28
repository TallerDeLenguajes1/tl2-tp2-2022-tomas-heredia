using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using punto4;

namespace LectorCSV
{
    
    public class HelperCsv
    {
        //usar este

        public void EscribirLinea( List<Alumno> ListadoElementos,string ruta)
        {
           
                using TextWriter streamWriter = File.AppendText(ruta );
                foreach (Alumno elemento in ListadoElementos)
                    {
                        Console.WriteLine(elemento);
                        
                        
                        streamWriter.WriteLine(elemento.Apellido+", "+elemento.Nombre+", " +elemento.Dni+", " + elemento.Id );
                       
                        
                    }
                
            
            
            
        }
        public static List<string[]> LeerCsv(string rutaDeArchivo, string nombreDeArchivo, char caracter)
        {
            FileStream MiArchivo = new FileStream(rutaDeArchivo + nombreDeArchivo, FileMode.Open);
            StreamReader StrReader = new StreamReader(MiArchivo);

            string Linea = "";
            List<string[]> LecturaDelArchivo = new List<string[]>();

            while ((Linea = StrReader.ReadLine()) != null)
            {
                string[] Fila = Linea.Split(caracter);
                LecturaDelArchivo.Add(Fila);
            }

            return LecturaDelArchivo;
        }

        public void archivoCSV (List<Alumno> ListadoElementos, string NombreArchivo){
        

            if(!File.Exists(NombreArchivo)){
                File.Create(NombreArchivo);
                
            }
                FileStream filestream = new FileStream(NombreArchivo, FileMode.Open);
                StreamWriter streamWriter = new StreamWriter(filestream);

                foreach (Alumno elemento in ListadoElementos)
                    {
                        Console.WriteLine(elemento);
                        
                        
                        streamWriter.WriteLine(elemento.Apellido+", "+elemento.Nombre+", " +elemento.Dni+", " + elemento.Id );
                       
                        
                    }

                streamWriter.Close();    //importante
                filestream.Close();
    }

        public static string[] nombreYextencion(string ruta){
        string[] subs = ruta.Split(@"\");
        int total = subs.Count();
        string[] nombre = subs[total-1].Split('.'); 
        return nombre;
    }

    }
}
