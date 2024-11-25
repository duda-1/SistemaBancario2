using Core_Banco._1__Service.Interface;
using Core_Banco._2__Reposiotry.Interface;
using SistemaBancario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Banco._1__Service
{
    public class ContaPoupancaService : IContaPoupancaService
    {
        private readonly IContaPoupancaRepository repository;
        public ContaPoupancaService(IContaPoupancaRepository usiarioRepository)
        {
            repository = usiarioRepository;
        }

        public void AdicionarConta(ContaPoupanca conta)
        {
            repository.AdicionarConta(conta);
        }

        public List<ContaPoupanca> ListarConta()
        {
            return repository.ListarConta();
        }

        public void EditarConta(ContaPoupanca editconta)
        {
            repository.EditarConta(editconta);
        }

        public void DeletarConta(int id)
        {
            repository.DeletarConta(id);
        }

        public ContaPoupanca BuscarTimePorId(int id)
        {
            return repository.BuscarPorId(id);
        }
    }
}
