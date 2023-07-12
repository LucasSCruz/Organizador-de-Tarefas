namespace OrganizadorTarefas.Domain.Entities;

public class Tarefa : Entity
{
    public string Nome { get; set; }
    public string  Descricao { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataModificacao { get; set; }
}