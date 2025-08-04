using PB_TP3.Interfaces;

namespace PB_TP3.Moldes;

public class Pedido : IPedidoService
{
    private int _id;

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public void AdicionarPedido(int id)
    {
        Console.WriteLine("Pedido adicionado com sucesso!");
    }
}