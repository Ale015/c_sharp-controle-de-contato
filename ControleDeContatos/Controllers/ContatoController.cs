using ControleDeContatos.Models;
using ControleDeContatos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers;

public class ContatoController : Controller
{
    private readonly IContatoRepositorio _contatoRepositorio;
    public ContatoController(IContatoRepositorio contatoRepositorio)
    {
        _contatoRepositorio = contatoRepositorio;
    }

    public IActionResult Index()
    {

        return View();

    }
    
    public IActionResult Criar( )
    {

        return View();

    }
    public IActionResult Editar()
    {

        return View();

    }

    public IActionResult ApagarConfirmacao()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Criar(ContatoModel contato)
    {
        // Chama o método Adicionar
        _contatoRepositorio.Adicionar(contato);
        // Ao final do Post, redireciona para o Index de Contato
        return RedirectToAction("Index");
    }

}
