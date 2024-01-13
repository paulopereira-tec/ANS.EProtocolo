using ANS.EProtocolo.Domain.ObjetosValor;

namespace ANS.EProtocolo.Domain.Dto;

public class DocumentoResDto
{
    public string Numero { get; set; }
    public TipoDocumento TipoDocumento { get; set; }
    public string Assunto { get; set; }
    public DateOnly DataDocumento { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateTime DataAtualizacao { get; set; }
    public Arquivo Arquivo { get; set; }
}
