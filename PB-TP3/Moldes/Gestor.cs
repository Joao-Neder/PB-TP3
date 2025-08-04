using PB_TP3.Interfaces;

namespace PB_TP3.Moldes;

public class Gestor : IGestorService
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

    public void CadastrarAdmPedidos(string nome, string senha)
    {
        Console.WriteLine("Cadastro realizado com sucesso!");
    }
    public void CadastrarAdmProdutos(string nome, string senha) 
    {
        Console.WriteLine("Cadastro realizado com sucesso!");
    }
    public void CadastrarAdmUsuarios(string nome, string senha) 
    {
        Console.WriteLine("Cadastro realizado com sucesso!");
    }

    public void AlterarNomeAdm(string nome, string novoNome)
    {
        Console.WriteLine("Nome alterado com sucesso!");
        
    }

    public void AlterarSenhaAdm(string nome, string novaSenha)
    {
        Console.WriteLine("Senha alterada com sucesso!");
    }

    public void ExcluirAdm(string nome)
    {
        Console.WriteLine("Administrador excluídoc com sucesso!");
    }
}