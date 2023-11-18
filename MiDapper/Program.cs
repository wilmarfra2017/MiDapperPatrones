
using Dapper;
using MiDapper;
using System.Data.SqlClient;

string connection = @"Data Source= WILMAR-MARTINEZ; Initial Catalog=pruebas;User ID=sa;Password=123456";

using (var db = new SqlConnection(connection))
{
    //insercion
    var sqlInsert = "INSERT INTO persona(nombre, edad) Values(@nombre, @edad)";
    var result = db.Execute(sqlInsert, new { nombre = "Pablo", edad = 30 });

    //actualizar el primer registro
    var sqlUpdate = "UPDATE persona SET edad=@edad WHERE id=@id";
    var resultUpdate = db.Execute(sqlUpdate, new { edad = 60, id = 1 });

    //eliminar registro
    var sqlDelete = "DELETE FROM Personas WHERE id=@id";
    var resultDelete = db.Execute(sqlDelete, new { id = 1 });



    var sql = "SELECT id, nombre, edad FROM persona";
    var lst = db.Query<Persona>(sql);

    foreach (var oElement in lst)
    {
        Console.WriteLine(oElement.nombre + " " + oElement.edad);
    }


    var sqlFindId = "SELECT id, nombre, edad FROM persona WHERE id=@id";
    var oFind = db.QueryFirst<Persona>(sqlFindId, new { id = 1 });
    Console.WriteLine("La personas es: " + oFind.nombre);



}
