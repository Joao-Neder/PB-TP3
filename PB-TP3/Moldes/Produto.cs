using PB_TP3.Interfaces;

namespace PB_TP3.Moldes;

public class Produto : IProdutoService
{
    private string _nome;
    private double _preco;
    private int _id;
    
    public string Nome
    {
        get => _nome;
        set => _nome = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Preco
    {
        get => _preco;
        set => _preco = value;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }
    
    public void AdicionarProduto(string nome, double preco, int id) {}
}