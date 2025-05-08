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


    // Listar todos os contatos da tabela Contatos
    public List<ContatoModel> BuscarContatos() 
    {
        return _bancoContext.Contatos.ToList();

    }


    // Buscar Contato por Id
    public ContatoModel BuscarPorId(int id) 
    {
       return _bancoContext.Contatos.FirstOrDefault(contato => contato.Id == id);
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



    public ContatoModel Editar(ContatoModel contato)
    {

        ContatoModel contatoDB = BuscarPorId(contato.Id);

        if (contatoDB == null) throw new System.Exception("Houve um erro na atualização do contato!");

        contatoDB.Nome = contato.Nome;
        contatoDB.Email = contato.Email;
        contatoDB.Celular = contato.Celular;

        _bancoContext.Contatos.Update(contatoDB);
        _bancoContext.SaveChanges();
        return contatoDB;
    }



    public void Apagar(ContatoModel contato)
    {

        _bancoContext.Contatos.Remove(contato);
        _bancoContext.SaveChanges();

    }




}
