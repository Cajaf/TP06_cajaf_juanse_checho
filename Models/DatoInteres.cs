using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace TP02_Andraca.Models
{
    public class DatoInteres
    {

        
        public int ID{get;private set;}
        public int IdUsuario{get;private set;}
        public int TipoInteres{get;private set;}
        public string Interes{get;private set;}
        public DatoInteres() { }
        public DatoInteres(int ID, int IdUsuariosuario, int TipoIntereses,string Interes)
        {
         this.ID = ID;
         this.IdUsuario = IdUsuario;  
         this.TipoInteres = TipoIntereses;
         this.Interes = Interes;
        }
       
    }
}