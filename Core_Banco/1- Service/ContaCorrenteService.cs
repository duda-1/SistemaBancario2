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
    public class ContaCorrenteService : IContaCorrenteService
    {
        private readonly IContaCorrenteRepository repository;
        public ContaCorrenteService(IContaCorrenteRepository usiarioRepository)
        {
            repository = usiarioRepository;
        }


        public void AdicionarConta(ContaCorrente conta)
        {
            repository.AdicionarConta(conta);
        }

        public List<ContaCorrente> ListarConta()
        {
            return repository.ListarConta();
        }

        public void EditarConta(ContaCorrente editconta)
        {
            repository.EditarConta(editconta);
        }

        public void DeletarConta(int id)
        {
            repository.DeletarConta(id);
        }

        public ContaCorrente BuscarTimePorId(int id)
        {
            return repository.BuscarPorId(id);
        }
    }
}
