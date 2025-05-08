using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models;



// Estrutura da Tabela Contatos, usado no BancoContext
public class ContatoModel
{
    //private ContatoModel()
    //{

    //}

    public int Id { get; set; }


    [Required(ErrorMessage = "O Nome necessita ser informado.")]
    [StringLength(50)]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O Email deve ser informado.")]
    [EmailAddress(ErrorMessage ="Por favor informe um e-mail válido.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Por favor informe um número do telefone")]
    [Phone(ErrorMessage = "O número de celular informado não é válido.")]    
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


