namespace ANS.EProtocolo.Domain.ObjetosValor;

/// <summary>
/// Objeto com informações adicionais que variam em função do assunto do protocolo eletrônico.
/// </summary>
/// <see cref="https://www.ans.gov.br/apis/e-protocolo/#api-Peticao-iniciaProtocolo"/>
public class InformacoesAdicionaisProtocolo
{
    public int NumeroAtendimento { get; set; }
    public string CompetenciaAtendimento { get; set; }
    public string DataFimAtendimento { get; set; }
}
