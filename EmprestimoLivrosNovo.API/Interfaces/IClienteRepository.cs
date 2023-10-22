using EmprestimoLivrosNovo.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmprestimoLivrosNovo.API.Interfaces
{
    public interface IClienteRepository
    {
        void Incluir(Cliente cliente);
        void Alterar(Cliente cliente);
        void Excluir(Cliente cliente);

        //Retorna um Cliente
        Task<Cliente> SelecionarByPk(int id);

        //Retorna uma lista de Clientes
        Task<IEnumerable<Cliente>> SelecionarTodos();
        Task<bool> SaveAllAsync();
    }
}
