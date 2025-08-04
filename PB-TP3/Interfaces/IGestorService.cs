namespace PB_TP3.Interfaces;

public interface IGestorService
{
    void RealizarLogin(string nome, string senha);
    void CadastrarAdmPedidos(string nome, string senha);
    void CadastrarAdmProdutos(string nome, string senha);
    void CadastrarAdmUsuarios(string nome, string senha);
    void AlterarNomeAdm(string nome, string novoNome);
    void AlterarSenhaAdm(string nome, string novaSenha);
    void ExcluirAdm(string nome);
}