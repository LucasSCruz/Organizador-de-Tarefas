using Microsoft.AspNetCore.Mvc;
using OrganizadorTarefas.Aplication.DTOs;

namespace OrganizadorTarefas.UI.Controllers;

[ApiController]
[Route("[controller]")]
public class TarefaController : HomeController
{
    [HttpGet("ObterTarefas")]
    public async Task<ActionResult<TarefaDTO>> ObterTarefas()
    {
        return Ok("Teste");
    }
    
    [HttpGet("ObterTarefa/{Id}")]
    public async Task<ActionResult<TarefaDTO>> ObterTarefa(int Id)
    {
        return Ok("Teste");
    }
    
    [HttpPost("CriarTarefa")]
    public async Task<ActionResult<TarefaDTO>> CriarTarefa([FromBody] TarefaDTO tarefaDTO)
    {
        return Ok("Teste");
    }
    
    [HttpPut("AtualizaTarefa")]
    public async Task<ActionResult<TarefaDTO>> AtualizaTarefa([FromBody] TarefaDTO tarefaDTO)
    {
        return Ok("Teste");
    }
    
    [HttpPut("DeletarTarefa")]
    public async Task<ActionResult<TarefaDTO>> DeletarTarefa([FromBody] TarefaDTO tarefaDTO)
    {
        return Ok("Teste");
    }
}