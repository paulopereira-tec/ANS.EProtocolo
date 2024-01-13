namespace ANS.EProtocolo.Domain.Enumeradores;

/// <summary>
/// Tipo de registro de Protocolo Eletrônico
/// </summary>
/// <see cref="https://www.ans.gov.br/apis/e-protocolo/#api-Peticao-iniciaProtocolo"/>
public enum ETipoRegistroProtocolo: int
{
    /// <summary>
    /// Petição (Encaminhado pela Operadora para a ANS)
    /// </summary>
    Peticao = 2
}
