using ProjetoEmprestimoAspCore.Models;
using ProjetoEmprestimoAspCore.Repository.Contract;

namespace ProjetoEmprestimoAspCore.Repository
{
    public class LivroRepository : ILivroRepository 
    {
        private readonly string _conexaoMySQL;
        public LivroRepository(IConfiguration conf) { }

        public void Atualizar(Livro livro)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Livro livro)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int Id)
        {
            throw new NotImplementedException();
        }

        public Livro ObterLivros(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Livro> ObterTodosLivros()
        {
            throw new NotImplementedException();
        }
    }
    
    
}
