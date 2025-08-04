namespace PB_TP3.Interfaces;

public interface IAdmPerfisService
{
    void RealizarLogin(string nome, string senha);
    void ExcluirPerfis(string email);
}