using Microsoft.Data.SqlClient;
using Dapper;
namespace TP02_Andraca.Models;
static public class BD
{

private static string _connectionString = @"Server=localhost;Database=TP06;Integrated Security=True;TrustServerCertificate=True;";

public static int Login(string contraseña, string email)
{
int num = -1;
using(SqlConnection connection = new SqlConnection(_connectionString))
{
    int num2=0;
    string query = "SELECT ID FROM DATOPERSONAL WHERE EMAIL = @pEmail and contraseña = @pContraseña";
    num2 = connection.QueryFirstOrDefault<int>(query, new { pEmail = email,  pContraseña = contraseña });
    if(num2 > 0)
    {
        num = num2;
    }
}

return(num);
}

public static DatoPersonal GetUsuario(int id)
{
DatoPersonal usuario;
using(SqlConnection connection = new SqlConnection(_connectionString))
{
    string query = "SELECT * FROM DATOPERSONAL WHERE ID = pId";
     usuario = connection.QueryFirstOrDefault<DatoPersonal>(query, new{pId = id});
}
return(usuario);
}

public static List<DatoFamiliar> GetDatoFamiliar(int id)
{
List<DatoFamiliar> datoFamiliar = new List<DatoFamiliar>();
using(SqlConnection connection = new SqlConnection(_connectionString))
{
    string query = "SELECT ID FROM DATOPERSONAL WHERE ID = pId";
    datoFamiliar = connection.Query<DatoFamiliar>(query, new{pId = id}).ToList();
}
return(datoFamiliar);
}

public static List<DatoInteres> GetDatoInteres(int id)
{
List<DatoInteres> datoInteres = new List<DatoInteres>();
    return(datoInteres);
}

}


