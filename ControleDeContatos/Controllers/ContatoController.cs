﻿using ControleDeContatos.Models;
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
        List<ContatoModel> contatos = _contatoRepositorio.BuscarContatos();

        return View(contatos);
    }
    
    public IActionResult Criar()
    {
        return View(new ContatoModel { });
    }


    [HttpPost]
    public IActionResult Criar(ContatoModel contato)
    {

        if (!ModelState.IsValid)
        {        
            return View(contato);
        }

        // Chama o método Adicionar
        _contatoRepositorio.Adicionar(contato);
        // Ao final do Post, redireciona para o Index de Contato
        return RedirectToAction("Index");
    }

    public IActionResult Editar(int id)
    {
        ContatoModel contato = _contatoRepositorio.BuscarPorId(id);
        return View(contato);
    }

    [HttpPost]
    public IActionResult Editar(ContatoModel contato)
    {

        if (!ModelState.IsValid)
        {
            return View(contato);
            

        }

        ContatoModel contatoEditado = _contatoRepositorio.Editar(contato);
        
        return RedirectToAction("Index");

    }

    public IActionResult ApagarConfirmacao(int id)
    {
        ContatoModel contato = _contatoRepositorio.BuscarPorId(id);

        if (contato == null)
        {
            return RedirectToAction("Index");
        }

        return View(contato);
    }

    public IActionResult Apagar(int id)
    {
        ContatoModel contato = _contatoRepositorio.BuscarPorId(id);
        
        // Deveria implementar no Repository mas fiz aqui.
        if(contato == null)
        {
            return RedirectToAction("Index");
        }
        
        
        _contatoRepositorio.Apagar(contato);
        return RedirectToAction("Index");
    }
}
