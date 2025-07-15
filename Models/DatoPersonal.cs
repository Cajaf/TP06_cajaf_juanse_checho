using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace TP02_Andraca.Models
{
    public class DatoPersonal
    {
        public int Id{get;private set;}
        public string Nombre {get; private set;}
        public string Apellido {get; private set;}
        public string Email {get;private set;}
        public string Contraseña{get;private set;}
        public DateTime FechaNacimiento {get; private set;}
        public string Foto {get; private set;}
        public DatoPersonal(int id,string nombre, string apellido,string email,string contraseña, DateTime fechanacimiento, string foto)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Contraseña=contraseña;
            this.FechaNacimiento = FechaNacimiento;
            this.Foto = foto;
        }
        public int ObtenerEdad()
        {
            int edad;
            edad = DateTime.Today.Year - FechaNacimiento.Year;
            if (DateTime.Today.Month <= FechaNacimiento.Month)
            {
                if (DateTime.Today.Day <= FechaNacimiento.Day)
            {
                edad--;
            }
            }
            return edad;
        }
    

    
    }
    

}