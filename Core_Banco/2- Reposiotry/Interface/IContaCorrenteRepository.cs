using SistemaBancario;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Banco._2__Reposiotry.Interface
{
    public interface IContaCorrenteRepository
    {
         void AdicionarConta(ContaCorrente conta);
         List<ContaCorrente> ListarConta();
         void EditarConta(ContaCorrente conta);
         void DeletarConta(int id);
         ContaCorrente BuscarPorId(int id);
    }
}
