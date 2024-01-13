using ANS.EProtocolo.Domain.Enumeradores;
using ANS.EProtocolo.Domain.ObjetosValor;

namespace ANS.EProtocolo.Domain.Dto;

public class ProtocoloDto
{
    public string Codigo { get; set; }
    public string NumeroProcesso { get; set; }
    public string CodOperadora { get; set; }
    public ETipoRegistroProtocolo TipoRegistro { get; set; } = ETipoRegistroProtocolo.Peticao;
    public string TipoProtocolo { get; set; }
    public string Assunto { get; set; }
    public ESituacaoProtocolo Situacao { get; set; } = ESituacaoProtocolo.Andamento;
    public DateTime DataCadastro { get; set; }
    public DateTime DataAtualizacao { get; set; }
    public InformacoesAdicionaisProtocolo? InformacoesAdicionais { get; set; }
    public LinkArquivo Link { get; set; }
}
