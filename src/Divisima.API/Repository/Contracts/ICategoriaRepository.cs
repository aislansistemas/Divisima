using System.Collections.Generic;
using System.Threading.Tasks;
using divisima.Models;

namespace divisima.Repository.Contracts
{
    public interface ICategoriaRepository
    {
        Task<List<Categoria>> GetAll();
        Task<List<Categoria>> GetAllAtiva(); 
        Task Cadastrar(Categoria categoria);
        Task<Categoria> GetById(long id);
        Task Editar(Categoria categoria);
        Task Inativar(Categoria categoria);
        Task Ativar(Categoria categoria);
    }
}