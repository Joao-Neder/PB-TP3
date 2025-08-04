using PB_TP3.Interfaces;

namespace PB_TP3.Moldes;

public class Usuario : IUsuarioService
{
    private string _email;
    private string _senha;
    private int _cep;
    private int _numeroDoImovel;
    private string _titularCartao;
    private int _cvvCartao;
    private int _validadeCartao;
    private string _bandeiraCartao;
    
    public string Email
    {
        get => _email;
        set => _email = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Senha
    {
        get => _senha;
        set => _senha = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public int Cep
    {
        get => _cep;
        set => _cep = value;
    }

    public int NumeroDoImovel
    {
        get => _numeroDoImovel;
        set => _numeroDoImovel = value;
    }

    public string TitularCartao
    {
        get => _titularCartao;
        set => _titularCartao = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int CvvCartao
    {
        get => _cvvCartao;
        set => _cvvCartao = value;
    }

    public int ValidadeCartao
    {
        get => _validadeCartao;
        set => _validadeCartao = value;
    }

    public string BandeiraCartao
    {
        get => _bandeiraCartao;
        set => _bandeiraCartao = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public Usuario(string email, string senha, int cep, int numeroDoImovel, string titularCartao, int cvvCartao, int validadeCartao, string bandeiraCartao)
    {
        _email = email;
        _senha = senha;
        _cep = cep;
        _numeroDoImovel = numeroDoImovel;
        _titularCartao = titularCartao;
        _cvvCartao = cvvCartao;
        _validadeCartao = validadeCartao;
        _bandeiraCartao = bandeiraCartao;
    }
    public Usuario()
    {}
    
    public void RealizarCadastro(string email, string senha, int cep, int numeroDoImovel, string titularCartao,
        int cvvCartao, int validadeCartao, string bandeiraCartao)
    {
        Usuario novoUsuario = new Usuario(email, senha, cep, numeroDoImovel, titularCartao, cvvCartao, validadeCartao, bandeiraCartao);
        
        string nomeArquivo = "Usuarios";
        Arquivo arquivo = Arquivo.InstanciarECriarOuAbrirArquivo(nomeArquivo);
        
        string linhaDoUsuario = $"Email: {novoUsuario.Email}, Senha: {novoUsuario.Senha}, CEP: {novoUsuario.Cep}, Número do Imóvel: {novoUsuario.NumeroDoImovel}, Titular do Cartão: {novoUsuario.TitularCartao}, CVV: {novoUsuario.CvvCartao}, Validade: {novoUsuario.ValidadeCartao}, Bandeira: {novoUsuario.BandeiraCartao}";
        
        arquivo.EscreverNoArquivo(linhaDoUsuario);
        Console.WriteLine("Cadastro realizado com sucesso e salvo no arquivo!");
        
        arquivo.FecharArquivo();

        Console.WriteLine("\n--- Lendo o arquivo de usuários ---");
        
        string[] linhasLidas = arquivo.LerTodasAsLinhasDoArquivo();
        foreach (string linha in linhasLidas)
        {
            Console.WriteLine(linha);
        }
    }

    public void RealizarLogin(string email, string senha)
    {
        Console.WriteLine("Login realizado com sucesso!");
    }

    public void RegistrarPedido(int id)
    {
        Console.WriteLine("Pedido registrado com sucesso!");
    }
    
}