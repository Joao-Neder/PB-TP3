namespace PB_TP3.Interfaces;

public interface IAdmProdutosService
{
  void RealizarLogin(string nome, string senha);
  void AlterarProduto(int id, string novoNome, double novoPreco);
  void CadastrarProduto(string nome, double preco, int id, string senha);
  void ExcluirProduto(int id);
}