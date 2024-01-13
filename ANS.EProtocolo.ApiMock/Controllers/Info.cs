using Microsoft.AspNetCore.Mvc;

namespace ANS.EProtocolo.ApiMock.Controllers;

[Route("e-protocolo/{versao}/info")]
[ApiController]
public class Info : ControllerBase
{
    /// <summary>
    /// Recupera informações do serviço.
    /// </summary>
    /// <see cref="https://www.ans.gov.br/apis/e-protocolo/#api-Info-getInfo">
    [HttpGet]
    public async Task<IActionResult> GetInfo([FromRoute] string versao)
    {
        if (versao == "v2")
        {
            return Ok(new
            {
                Nome = "e-protocolo",
                Versao = "2.1.0"
            });
        }

        return StatusCode(StatusCodes.Status500InternalServerError, new
        {
            Codigo = 500,
            Mensagem = "Ocorreu um eror",
            DataOcorrencia = DateTime.Now
        });

    }
}
