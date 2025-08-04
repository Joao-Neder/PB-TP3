namespace PB_TP3.Moldes;

//============================================

//1)Importações
//a)Para conseguir usar o encoding
using System.Text;
//============================================

public class Arquivo
{
  //1)Atributos
  //a)Nome do Arquivo
  private string _nomeArquivo;
  //----------------------------//---------------------------
  //b)Caminho do Arquivo
  private string _caminhoArquivo;
  //----------------------------------------------------------------------------
  
  //2)Propriedades públicas
  //a)Nome do Arquivo
  public string NomeArquivo
  {
    get => _nomeArquivo;
    set => _nomeArquivo = value;
  }
  //----------------------------//---------------------------
  //b)Caminho do Arquivo
  public string CaminhoArquivo
  {
    get => _nomeArquivo;
    set => _caminhoArquivo = value;
  }
  //----------------------------------------------------------------------------
  
  //3)Propriedades privadas 
  //a)Para escrita no arquivo
  private StreamWriter Sw { get; set; }
  //----------------------------//---------------------------
  //b)//Para leitura do arquivo
  private StreamReader Sr { get; set; }
  //----------------------------------------------------------------------------
  
  //4)Construtor 
  public Arquivo(string nome)
  {
    NomeArquivo = nome;
    CaminhoArquivo = nome + ".txt";
  }
  //----------------------------------------------------------------------------
  
  //5)Métodos
  //Para intanciar a classe criar/abrir o arquivo
  public static Arquivo InstanciarECriarOuAbrirArquivo(string nomeArquivo)
  {
    //1)Instanciando a classe Arquivo com o nome escolhido
    Arquivo arquivo = new Arquivo(nomeArquivo);
    //----------------------------------------------------------------------------
        
    //2)Criando/Abrindo o arquivo
    arquivo.CriarOuAbrirArquivo();
    //----------------------------------------------------------------------------
    
    //3)Retornando o objeto
    return arquivo;
  }
  //----------------------------//---------------------------
  
  //b)Para criar ou abrir (caso já exista) o arquivo
  public void CriarOuAbrirArquivo()
  {
    //Tentando criar/abrir o arquivo
    try
    {
      Sw = new StreamWriter(CaminhoArquivo, true, Encoding.UTF8);
    }
    //Caso dê erro
    catch (Exception ex)
    {
      //Retornando erro
      throw new Exception($"Erro ao criar ou abrir o arquivo: {ex.Message}");
    }
  }
  //----------------------------//---------------------------
  
  //c)Para fechar o arquivo
  public void FecharArquivo()
  {
    //Tentando fechar o arquivo
    try
    {
      Sw.Close();
    }
     //Caso dê erro
     catch(Exception ex)
     {
       throw new Exception($"Erro ao fechar o arquivo: {ex.Message}");
     }
  }
  //----------------------------//---------------------------
  
  //d)Para escrever algo no arquivo
  public void EscreverNoArquivo(string conteudo)
  {
    //Tentando escrever algo na última linha do arquivo
    try
    {
      Sw.WriteLine(conteudo);
    }
    //Caso dê erro
    catch (Exception ex)
    {
      throw new Exception($"Erro ao criar ou abrir o arquivo: {ex.Message}");
    }
  }
  //----------------------------//---------------------------
  
  //e)Para formar um array com todas as linhas do arquivo
  public string[] LerTodasAsLinhasDoArquivo()
  {
    //Criando um vetor a ser preenchido
    string[] linhas;
    
    //Lendo cada linha do arquivo
    linhas = File.ReadAllLines(CaminhoArquivo, Encoding.UTF8);
    
    //retornando o vetor
    return linhas;
  }
}