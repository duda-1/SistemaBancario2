using SistemaBancario;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Banco._2__Reposiotry.Interface
{
    public interface IContaPoupancaRepository
    {
        void AdicionarConta(ContaPoupanca conta);
        List<ContaPoupanca> ListarConta();
        void EditarConta(ContaPoupanca conta);
        void DeletarConta(int id);
        ContaPoupanca BuscarPorId(int id);
    }
}
