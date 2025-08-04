using PB_TP3.Interfaces;

namespace PB_TP3.Moldes;

public class Usuario : IUsuarioService
{
    private string _email;
    private string _senha;
    private int _cep;
    private int _numeroDoImovel;
    private string _titularCartao;
    private int cvvCartao;
    private int validadeCartao;
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
        get => cvvCartao;
        set => cvvCartao = value;
    }

    public int ValidadeCartao
    {
        get => validadeCartao;
        set => validadeCartao = value;
    }

    public string BandeiraCartao
    {
        get => _bandeiraCartao;
        set => _bandeiraCartao = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public void RealizarCadastro(string email, string senha, int cep, int numeroDoImovel, string titularCartao, string cvvCartao, int validadeCartao, string bandeiraCartao) {}
    public void RealizarLogin(string email, string senha) {}
    public void RegistrarPedido(int id) {}
    
}