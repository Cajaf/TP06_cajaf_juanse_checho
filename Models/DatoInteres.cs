using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace TP02_Andraca.Models
{
    public class DatoInteres
    {

        
        public int Id{get;private set;}
        public int IdUsuario{get;private set;}
        public int TipoInteres{get;private set;}
        public string Interes{get;private set;}
        public DatoInteres(int id, int idusuario, int tipointereses,string interes)
        {
         this.Id= id;
         this.IdUsuario=idusuario;  
         this.TipoInteres=tipointereses;
         this.Interes=interes;
        }
       
    }
}