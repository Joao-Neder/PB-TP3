using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PB_TP3.Moldes;

namespace PB_TP3.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Usuario usuario = new Usuario();

        // Valores de exemplo para o cadastro
        string email = "joao.neder@email.com";
        string senha = "SenhaSegura123!";
        int cep = 30123456;
        int numeroDoImovel = 123;
        string titularCartao = "Joao P. N. R. de Lima";
        int cvvCartao = 123;
        int validadeCartao = 2028;
        string bandeiraCartao = "Mastercard";

        // Chama o método para realizar o cadastro
        usuario.RealizarCadastro(email, senha, cep, numeroDoImovel, titularCartao, cvvCartao, validadeCartao, bandeiraCartao);
    }
}