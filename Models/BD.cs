using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace tp_09{
    public static class BD
    {
        private static string _connectionString= @"Server=A-PHZ2-CIDI-050\SQLEXPRESS; DataBase=AQUARIO; Trusted_Connection=True;";
        
        public static List<Exhibicion> GetExhibiciones()
        {
            List<Exhibicion> Lista = null;
            string SQL = "SELECT * FROM Exhibiciones"; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                Lista = db.Query<Exhibicion>(SQL).ToList(); 
            } 
            return Lista;
        }
        
        public static Reserva GetReservaById(int Id)
        {
            Reserva item = null;
            string SQL = "SELECT * FROM Reservas R INNER JOIN Exhibiciones E ON R.FkExhibicion=E.IdExhibicion "; 
            SQL += " WHERE IdReserva=@pId"; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                item = db.QueryFirstOrDefault<Reserva>(SQL, new { pId = Id }); 
            } 
            return item;
        }

        public static void InsertReserva(Reserva item)
        {
            string SQL = "INSERT INTO Reservas(Nombre, Apellido, DNI, FKExhibicion, Cantidad)";
            SQL += " VALUES (@pNombre, @pApellido, @pDNI, @pFKExhibicion, @pCantidad) "; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(SQL, new {
                    pNombre = item.Nombre,
                    pApellido = item.Apellido,
                    pDNI = item.DNI,
                    pFKExhibicion = item.FKExhibicion,
                    pCantidad = item.Cantidad
                }); 
            }   
        }


    }
}