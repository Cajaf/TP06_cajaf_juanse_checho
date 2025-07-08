using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace TP02_Andraca.Models
{
    static public class Grupo
    {
        static public Dictionary<int,Integrante> Integrantess{get; private set;}
        public static void crearGrupo()
        {
            
            List<DatoFamiliar> familiares= new List<DatoFamiliar>();
            familiares.Add(new DatoFamiliar("Paula","Wilson","Mama"));
            familiares.Add(new DatoFamiliar("Mateo", "Andraca","Hermano"));
            familiares.Add(new DatoFamiliar("Fernando", "Andraca","Papa"));
            Integrantess.Add(48803376, new Integrante(48803376,new DatoPersonal("Felipe","Andraca",DateTime.Parse("2008/7/16"),"foto.jfif"),familiares,new DatoInteres("Videojuegos","Casa de papel","Programacion")));

        }
    }
    }
