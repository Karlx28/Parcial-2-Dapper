using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class SuppliersRepository
    {
        public List<Suppliers> ObtenerTodos()
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String SelectAll = "";
                SelectAll = SelectAll + "SELECT [SupplierID] " + "\n";
                SelectAll = SelectAll + "      ,[CompanyName] " + "\n";
                SelectAll = SelectAll + "      ,[ContactName] " + "\n";
                SelectAll = SelectAll + "      ,[ContactTitle] " + "\n";
                SelectAll = SelectAll + "      ,[Address] " + "\n";
                SelectAll = SelectAll + "      ,[City] " + "\n";
                SelectAll = SelectAll + "      ,[Region] " + "\n";
                SelectAll = SelectAll + "      ,[PostalCode] " + "\n";
                SelectAll = SelectAll + "      ,[Country] " + "\n";
                SelectAll = SelectAll + "      ,[Phone] " + "\n";
                SelectAll = SelectAll + "      ,[Fax] " + "\n";
                SelectAll = SelectAll + "      ,[HomePage] " + "\n";
                SelectAll = SelectAll + "  FROM [dbo].[Suppliers]";

                var categoria = conexion.Query<Suppliers>(SelectAll).ToList();
                return categoria;
            }
        }

        public Suppliers ObtenerPorID(string id)
        {
            using (var conexion = DataBase.GetSqlConnection()) {
                
                String selectPorID = "";
                selectPorID = selectPorID + "SELECT [SupplierID] " + "\n";
                selectPorID = selectPorID + "      ,[CompanyName] " + "\n";
                selectPorID = selectPorID + "      ,[ContactName] " + "\n";
                selectPorID = selectPorID + "      ,[ContactTitle] " + "\n";
                selectPorID = selectPorID + "      ,[Address] " + "\n";
                selectPorID = selectPorID + "      ,[City] " + "\n";
                selectPorID = selectPorID + "      ,[Region] " + "\n";
                selectPorID = selectPorID + "      ,[PostalCode] " + "\n";
                selectPorID = selectPorID + "      ,[Country] " + "\n";
                selectPorID = selectPorID + "      ,[Phone] " + "\n";
                selectPorID = selectPorID + "      ,[Fax] " + "\n";
                selectPorID = selectPorID + "      ,[HomePage] " + "\n";
                selectPorID = selectPorID + "  FROM [dbo].[Suppliers] " + "\n";
                selectPorID = selectPorID + "  WHERE SupplierID = @SupplierID";

                var categoria = conexion.QueryFirstOrDefault<Suppliers>(selectPorID, new { SupplierID = id });
                return categoria;
            }
        }

        public int EliminarCategoria(string Id)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {

                String Delete = "";
                Delete = Delete + "DELETE FROM [dbo].[Suppliers] " + "\n";
                Delete = Delete + "      WHERE SupplierID = @SupplierID";

                var eliminadas = conexion.Execute(Delete, new
                {
                    SupplierID = Id
                });
                return eliminadas;

            }
        }

    }
}
