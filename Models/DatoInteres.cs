using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace TP02_Andraca.Models
{
    public class DatoInteres
    {

        [JsonProperty]
        public int Id{get;private set;}
        [JsonProperty]
        public int IdUsuario{get;private set;}
        [JsonProperty]
        public int TipoInteres{get;private set;}
        [JsonProperty]
        public string Interes{get;private set;}
        public DatoInteres(int id, int idusuario, int tipointereses,string interes)
        {
         this.Id= id;
         this.IdUsuario=idusuario;  
         this.TipoInteres=tipointereses;
         this.Interes=interes;
        }
        public DatoInteres()
        {

        }
    }
}