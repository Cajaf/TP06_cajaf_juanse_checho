using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace TP02_Andraca.Models
{
    public class DatoInteres
    {
        public string Hobbies {get; private set;}
        public string SeriesFavoritas {get; private set;}
        public string GustosEscolares {get; private set;}

        public DatoInteres(string Hobbies, string SeriesFavoritas, string GustosEscolares)
        {
             this.Hobbies = Hobbies;
             this.SeriesFavoritas = SeriesFavoritas;
             this.GustosEscolares = GustosEscolares;
        }
    }
}