using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace TP02_Andraca.Models
{
    public class DatoFamiliar
    {
        [JsonProperty]
        public int Id{get;private set;}
        [JsonProperty]
        public int IdUsuario{get;private set;}
        [JsonProperty]
        public string Nombre {get; private set;}
        [JsonProperty]
        public string Apellido {get; private set;}
        [JsonProperty]
        public string Parentesco {get; private set;}
        [JsonProperty]
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