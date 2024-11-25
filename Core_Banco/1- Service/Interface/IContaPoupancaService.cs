using SistemaBancario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Banco._1__Service.Interface
{
    public interface IContaPoupancaService
    {
        void AdicionarConta(ContaPoupanca conta);
        List<ContaPoupanca> ListarConta();
        void EditarConta(ContaPoupanca editconta);
        void DeletarConta(int id);
        ContaPoupanca BuscarTimePorId(int id);
    }
}
