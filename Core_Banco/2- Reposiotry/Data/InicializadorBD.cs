using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Banco._2__Reposiotry.Data
{
    public static class InicializadorBD
    {
        private const string ConnectionString = "Data Source=SistemaBancario.db";

        public static void Inicializar()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();  

               string commandoSQL = @"   
                 CREATE TABLE IF NOT EXISTS ContaCorrentes(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Titular TEXT NOT NULL,
                 Saldo REAL NOT NULL,
                 LimiteCredito REAL NOT NULL
                );";

                commandoSQL += @"   
                 CREATE TABLE IF NOT EXISTS ContaPoupanças(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Titular INTERGE NOT NULL,
                 Saldo REAL NOT NULL,
                 TaxaJuros REAL NOT NULL
                );";

                connection.Execute(commandoSQL);
            }
        }
    }
}
