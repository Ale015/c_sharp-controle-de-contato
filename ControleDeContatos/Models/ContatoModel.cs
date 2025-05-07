namespace ControleDeContatos.Models;



// Estrutura da Tabela Contatos, usado no BancoContext
public class ContatoModel
{
    //private ContatoModel()
    //{

    //}

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Celular { get; set; }

    //public static ContatoModel Create()
    //{

    //    return new ContatoModel();

    //}

    //public void ChangeCelular()
    //{

    //}

    //public void ChangeEmail() 
    //{ 
        
    //}        
}

//input -> service -> mapeia input prod Model (auto valida) ->  ViewModel 

//public class ContatoViewModel //ContatoDto
//{
//    public string Nome { get; set; }
//    public string Email { get; set; }
//    public string Celular { get; set; }

//    public static ContatoViewModel FromModel(ContatoModel contato)
//    {
//        return new ContatoViewModel
//        {
//            Nome = contato.Nome,
//            Email = contato.Email,
//            Celular = contato.Celular
//        };
//    }
//}


