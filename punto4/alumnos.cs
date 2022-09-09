using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace punto4{

public class Alumno
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Dni { get; set; }
    public int Curso { get; set; }

    public void set_nombre(string n){
        Nombre = n;
    }
    public void set_apellido(string n){
        Apellido = n;
    }

    public void set_dni(int n){
        Dni = n;
    }

    

}}