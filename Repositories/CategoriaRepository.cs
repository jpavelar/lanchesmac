using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;

namespace LanchesMac.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        //Injecao de dependecia
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context) { 
        
            _context = context;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
