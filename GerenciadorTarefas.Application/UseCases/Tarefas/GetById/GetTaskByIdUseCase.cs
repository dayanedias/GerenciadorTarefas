using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefas.Application.UseCases.Tarefas.GetById;
public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson 
        { 
            Id = id,
            Name = "Estudar",
            Description = "Estudar C#",
            Priority = Communication.Enums.Priority.Alta,
            Status = Communication.Enums.Status.Andamento,
            Deadline = new DateTime(year: 2025, month: 06, day: 30),
        };
    }
    
}
