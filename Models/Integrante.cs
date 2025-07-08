using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace TP02_Andraca.Models
{
    public class Integrante
    {
        public int DNI {get; private set;}
        public DatoPersonal DatosPersonales {get; private set;}
        public List<DatoFamiliar>DatosFamiliares {get; private set;}
        public DatoInteres DatosIntereses {get; private set;}

        public Integrante(int DNI,DatoPersonal DatosPersonales,List<DatoFamiliar>DatoFamiliares2, DatoInteres DatosIntereses)
        {
            this.DNI = DNI;
            this.DatosPersonales = DatosPersonales;
            this.DatosFamiliares = DatoFamiliares2;
            this.DatosIntereses = DatosIntereses;
        }
    }
}