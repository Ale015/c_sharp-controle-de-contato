using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarContatos();

        ContatoModel Adicionar(ContatoModel contato);
        
        ContatoModel BuscarPorId(int id);

        ContatoModel Editar(ContatoModel contato);

        void Apagar(ContatoModel contato);
    }
}
