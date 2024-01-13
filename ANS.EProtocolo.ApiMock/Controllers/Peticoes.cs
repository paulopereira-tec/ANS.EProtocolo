using ANS.EProtocolo.Domain.Dto;
using ANS.EProtocolo.Domain.Enumeradores;
using ANS.EProtocolo.Domain.ObjetosValor;
using Microsoft.AspNetCore.Mvc;

namespace ANS.EProtocolo.ApiMock.Controllers;

[Route("e-protocolo/{versao}/operadoras")]
[ApiController]
public class Peticoes : ControllerBase
{
    /// <summary>
    /// 01. Inicia um protocolo eletrônico de petição.
    /// </summary>
    /// <see cref="https://www.ans.gov.br/apis/e-protocolo/#api-Peticao-iniciaProtocolo"/>
    [HttpPost("{codOperadora}/peticoes/{tipoProtocolo}/{assunto}")]
    public async Task<IActionResult> IniciarProtocolo(
        [FromQuery] string codOperadora, string tipoProtocolo, string assunto,
        [FromBody] IniciarProtocoloDto iniciarProtocolo)
    {
        return StatusCode(StatusCodes.Status201Created, new ProtocoloDto
        {
            Codigo = "",
            NumeroProcesso = "",
            CodOperadora = "",
            TipoRegistro = ETipoRegistroProtocolo.Peticao,
            TipoProtocolo = "",
            Assunto = "",
            Situacao = ESituacaoProtocolo.Andamento,
            DataCadastro = DateTime.Now,
            DataAtualizacao = DateTime.Now,
            InformacoesAdicionais = new InformacoesAdicionaisProtocolo
            {
                NumeroAtendimento = 000,
                CompetenciaAtendimento = "",
                DataFimAtendimento = DateTime.Now.ToString()
            },
            Link = new LinkArquivo
            {
                Params = new ParametrosLinkArquivo
                {
                    Rel = "eventos",
                    Type = "application/json",
                    Title= "Andamento do protocolo"
                },
                Href = "operadoras/999999/peticoes/ressarcimento/impugnacoes/99999998/eventos"
            }
        });
    }

    /// <summary>
    /// 02. Adiciona um documento principal ao protocolo eletrônico de petição.
    /// </summary>
    /// <param name="tipoProtocolo"></param>
    /// <param name="assunto"></param>
    /// <param name="codProtocolo"></param>
    /// <param name="documentoPrincipal"></param>
    /// <returns></returns>
    [HttpPost("{codOperadora}/peticoes/{tipoProtocolo}/{assunto}/{codProtocolo}/documentos/principais")]
    public async Task<IActionResult> AddPrincipalDocument(
        [FromRoute] string tipoProtocolo, string assunto, string codProtocolo,
        [FromBody] DocumentoReqDto documentoPrincipal)
    {
        return StatusCode(StatusCodes.Status201Created, new DocumentoResDto
        {
            Numero = "201799999900000143",
            TipoDocumento = new Domain.ObjetosValor.TipoDocumento
            {
                Id = 2,
                Nome = "Peticao",
                Status = 1,
                DataCadastro = DateTime.Now,
            },
            Assunto = "Impugnação referente ao atendimento 8888888888888 - 09/2015",
            DataDocumento = DateOnly.FromDateTime(DateTime.Now),
            DataCadastro = DateTime.Now,
            DataAtualizacao = DateTime.Now,
            Arquivo = new Domain.ObjetosValor.Arquivo
            {
                Hash = "c680410ab144e959669d165fb7b512ec828eeffb640d222ae038dd6e8961c5ce",
                Nome = "teste.pdf",
                Tamanho = 73962,
                Link = new Domain.ObjetosValor.LinkArquivo
                {
                    Params = new Domain.ObjetosValor.ParametrosLinkArquivo
                    {
                        Rel = "download",
                        Type = "application/octet-stream",
                        Title = "201732630500000143"
                    }
                },
                Href = "operadoras/999999/documentos/201799999900000143"
            }

        });
    }
}
