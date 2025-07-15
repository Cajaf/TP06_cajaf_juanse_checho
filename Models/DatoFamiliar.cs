using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace TP02_Andraca.Models
{
    public class DatoFamiliar
    {
        public int Id{get;private set;}
        public int IdUsuario{get;private set;}
        public string Nombre {get; private set;}
        public string Apellido {get; private set;}
        public string Parentesco {get; private set;}
        public string Descripcion{get;private set;}

    public DatoFamiliar(int id,int idusuario,string nombre, string apellido, string parentesco,string descripcion)
    {
        this.Id = id;
        this.IdUsuario= idusuario;
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Parentesco = parentesco;
    }
    }
    
}