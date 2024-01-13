namespace ANS.EProtocolo.Domain.ObjetosValor;

public class Arquivo
{
    public string Hash { get; set; }
    public string Nome { get; set; }
    public int Tamanho { get; set; }
    public LinkArquivo Link { get; set; }
    public string Href { get; set; }
}
