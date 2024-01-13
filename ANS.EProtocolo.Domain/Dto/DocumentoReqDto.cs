namespace ANS.EProtocolo.Domain.Dto;

public class DocumentoReqDto
{
    public string Hash { get; set; }
    public string NomeArquivo { get; set; }
    public string Assunto { get; set; }
    public byte[] Arquivo { get; set; }
}
