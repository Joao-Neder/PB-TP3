namespace PB_TP3.Interfaces;

public interface IUsuarioService
{
   void RealizarCadastro(string email, string senha, int cep, int numeroDoImovel, string titularCartao, int cvvCartao, int validadeCartao, string bandeiraCartao);
   void RealizarLogin(string email, string senha);
   void RegistrarPedido(int id);
}