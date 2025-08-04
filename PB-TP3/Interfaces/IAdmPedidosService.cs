namespace PB_TP3.Interfaces;

public interface IAdmPedidosService
{
    void RealizarLogin(string nome, string senha);
    void ExcluirPedidos(int id);
}