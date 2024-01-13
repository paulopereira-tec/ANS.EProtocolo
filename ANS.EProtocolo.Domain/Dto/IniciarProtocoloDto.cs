using ANS.EProtocolo.Domain.ObjetosValor;

namespace ANS.EProtocolo.Domain.Dto;

public class IniciarProtocoloDto
{
    public string NumeroProcesso { get; set; }
    public InformacoesAdicionaisProtocolo InformacoesAdicionais { get; set; }
}
