using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace TP02_Andraca.Models
{
    public class DatoFamiliar
    {
        public string Nombre {get; private set;}
        public string Apellido {get; private set;}
        public string Parentesco {get; private set;}

    public DatoFamiliar(string Nombre, string Apellido, string Parentesco)
    {
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.Parentesco = Parentesco;
    }
    }
    
}