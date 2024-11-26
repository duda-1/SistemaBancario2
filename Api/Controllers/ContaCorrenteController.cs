using AutoMapper;
using Core_Banco._1__Service.Interface;
using Microsoft.AspNetCore.Mvc;
using SistemaBancario;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaCorrenteController : ControllerBase
    {
        private readonly IContaCorrenteService _service;
        private readonly IMapper _mapper;

        public ContaCorrenteController(IContaCorrenteService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }


        [HttpPost("Adicionar_Conta")]
        public void AdicionarConta(ContaCorrente conta)
        {
            ContaCorrente carrinho = _mapper.Map<ContaCorrente>(conta);
            _service.AdicionarConta(carrinho);
        }

        [HttpGet("Listar_Conta")]
        public List<ContaCorrente> ListarConta()
        {
            return _service.ListarConta();
        }

        [HttpPut("Editar_Conta")]
        public void EditarConta(ContaCorrente c)
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
