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
    public class ContaPoupancaRepository : IContaPoupancaRepository
    {
        private readonly string ConnectionString;
        public ContaPoupancaRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void AdicionarConta(ContaPoupanca conta)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<ContaPoupanca>(conta);
        }

        public List<ContaPoupanca> ListarConta()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<ContaPoupanca>().ToList();
        }

        public void EditarConta(ContaPoupanca conta)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<ContaPoupanca>(conta);
        }
        public void DeletarConta(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            ContaPoupanca conta = BuscarPorId(id);
            connection.Delete<ContaPoupanca>(conta);
        }

        public ContaPoupanca BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<ContaPoupanca>(id);
        }
    }
}
