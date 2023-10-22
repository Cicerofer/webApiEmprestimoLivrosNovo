using EmprestimoLivrosNovo.API.Models;
using EmprestimoLivrosNovo.API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using AutoMapper;
using EmprestimoLivrosNovo.API.DTOs;

namespace EmprestimoLivrosNovo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteController(IClienteRepository clienteRepository, IMapper mapper)
        {
            _mapper = mapper;
            _clienteRepository = clienteRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            var clientes = await _clienteRepository.SelecionarTodos();
            var clientesDTO = _mapper.Map<IEnumerable<ClienteDTO>>(clientes);
            return Ok(clientesDTO);
        }

        [HttpPost]
        public async Task<ActionResult> CadastrarCliente(ClienteDTO clienteDTO)
        {
            var cliente = _mapper.Map<Cliente>(clienteDTO);
            _clienteRepository.Incluir(cliente);
            if(await _clienteRepository.SaveAllAsync())
            {
                return Ok("Cliente cadastrado com sucesso!");
            }

            return BadRequest("Ocorreu um erro ao salvar o cliente.");
        }

        [HttpPut]
        public async Task<ActionResult> AlterarCliente(ClienteDTO clienteDTO)
        {
            if(clienteDTO.Id == 0)
            {
                return BadRequest("Não é possivel altear o cliente. è preciso informar o ID.");
            }

            var clienteExiste = await _clienteRepository.SelecionarByPk(clienteDTO.Id);
            if(clienteExiste == null)
            {
                return NotFound("Cliente não encontrado.");
            }

            var cliente = _mapper.Map<Cliente>(clienteDTO);
            _clienteRepository.Alterar(cliente);
            if (await _clienteRepository.SaveAllAsync())
            {
                return Ok("Cliente alterado com sucesso!");
            }

            return BadRequest("Ocorreu um erro ao alterar o cliente.");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> ExcluirCliente(int id)
        {
            var cliente = await _clienteRepository.SelecionarByPk(id);            

            if(cliente == null)
            {
                return NotFound("Cliente não encontrado.");
            }


            _clienteRepository.Excluir(cliente);

            if (await _clienteRepository.SaveAllAsync())
            {
                return Ok("Cliente exluido com sucesso!");
            }

            return BadRequest("Ocorreu um erro ao excluir o cliente");
        }

        [HttpGet("{id}")]

        public async Task<ActionResult> SelecionarCliente(int id)
        {
            var cliente = await _clienteRepository.SelecionarByPk(id);

            if(cliente == null)
            {
                return NotFound("Cliente não encontrado.");
            }

            var clienteDTO = _mapper.Map<ClienteDTO>(cliente);

            return Ok(clienteDTO);        
                
        }

        #region [Token]

        //public async Task<ActionResult<UserDto>>
        //    Login(LoginDto loginDto)
        //{
        //    return new UserDto
        //    {
        //        Username = User.UserName,
        //        token = _tokenService,
        //        CreateToken(user),
        //    };
        //}
        #endregion
    }
}

