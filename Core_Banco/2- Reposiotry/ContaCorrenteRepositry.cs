using Core_Banco._2__Reposiotry.Interface;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using SistemaBancario;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Banco._2__Reposiotry
{
    public class ContaCorrenteRepositry : IContaCorrenteRepository
    {
        private readonly string ConnectionString;
        public ContaCorrenteRepositry(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void AdicionarConta(ContaCorrente conta)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<ContaCorrente>(conta);
        }

        public List<ContaCorrente> ListarConta()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<ContaCorrente>().ToList();
        }

        public void EditarConta(ContaCorrente conta)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<ContaCorrente>(conta);
        }
        public void DeletarConta(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            ContaCorrente conta = BuscarPorId(id);
            connection.Delete<ContaCorrente>(conta);
        }

        public ContaCorrente BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<ContaCorrente>(id);
        }
    }
}
