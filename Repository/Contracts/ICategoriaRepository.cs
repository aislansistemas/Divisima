using System.Collections.Generic;
using System.Threading.Tasks;
using divisima.Models;

namespace divisima.Repository.Contracts
{
    public interface ICategoriaRepository
    {
        Task<List<Categoria>> GetAll();
        Task Cadastrar(Categoria categoria);
        Task<Categoria> GetById(int id);
    }
}