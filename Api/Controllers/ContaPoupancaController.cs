using AutoMapper;
using Core_Banco._1__Service.Interface;
using Microsoft.AspNetCore.Mvc;
using SistemaBancario;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaPoupancaController : ControllerBase
    {
        private readonly IContaPoupancaService _service;
        private readonly IMapper _mapper;

        public ContaPoupancaController(IContaPoupancaService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }


        [HttpPost("Adicionar_Conta")]
        public void AdicionarConta(ContaPoupanca conta)
        {
            _service.AdicionarConta(conta);
        }

        [HttpGet("Listar_Conta")]
        public List<ContaPoupanca> ListarConta()
        {
            return _service.ListarConta();
        }

        [HttpPut("Editar_Conta")]
        public void EditarConta(ContaPoupanca c)
        {
            _service.EditarConta(c);
        }

        [HttpDelete("Deletar_Conta")]
        public void DeletarConta(int id)
        {
            _service.DeletarConta(id);
        }
    }
}
