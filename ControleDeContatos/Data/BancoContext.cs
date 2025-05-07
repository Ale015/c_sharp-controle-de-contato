using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeContatos.Data
{
    // Contexto -> ORM / Conexão entre MVC e DB
    public class BancoContext : DbContext
    {

        // Construtor
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        // Propriedade -> Tabela Contatos (Define a estrutura da tabela Contatos). Vira uma Prop do Contexto
        public DbSet<ContatoModel> Contatos { get; set; }


    }
}
