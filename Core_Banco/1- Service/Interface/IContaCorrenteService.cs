using SistemaBancario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Banco._1__Service.Interface
{
    public interface IContaCorrenteService
    {
        void AdicionarConta(ContaCorrente conta);
        List<ContaCorrente> ListarConta();
        void EditarConta(ContaCorrente editconta);
        public void DeletarConta(int id);
        ContaCorrente BuscarTimePorId(int id);
    }
}
