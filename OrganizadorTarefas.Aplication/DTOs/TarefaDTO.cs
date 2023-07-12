namespace OrganizadorTarefas.Aplication.DTOs;

public class TarefaDTO
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string  Descricao { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataModificacao { get; set; }
}