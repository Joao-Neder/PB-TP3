using PB_TP3.Interfaces;

namespace PB_TP3.Moldes;

public class AdmPerfis : IAdmPerfisService
{
    private string _nome;
    private string _senha;
    
    public string Nome
    {
        get => _nome;
        set => _nome = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Senha
    {
        get => _senha;
        set => _senha = value ?? throw new ArgumentNullException(nameof(value));
    }

    public void RealizarLogin(string nome, string senha)
    {
        Console.WriteLine("Login realizado com sucesso!");
    }

    public void ExcluirPerfis(string email)
    {
        Console.WriteLine("Perfil excluído com sucesso!");
    }
}