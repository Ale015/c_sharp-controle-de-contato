using ControleDeContatos.Data;
using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeContatos.Repositorio;

public class ContatoRepositorio : IContatoRepositorio
{

    private readonly BancoContext _bancoContext;

    // Injetar o BancoContext através do construtor -> Permitindo o uso do ORM
    public ContatoRepositorio(BancoContext bancoContext) 
    {
        _bancoContext = bancoContext;
    }

    // Implementação do Contrato
    public ContatoModel Adicionar(ContatoModel contato) 
    {
        // Insert no Banco
        _bancoContext.Contatos.Add(contato);

        // Commitar as mudanças, usa-se o SaveChanges
        _bancoContext.SaveChanges();

        // Retorna ao ser chamado, confirmando a adição
        return contato;

    }
}
