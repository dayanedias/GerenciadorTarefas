using GerenciadorTarefas.Communication.Requests;
using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefas.Application.UseCases.Tarefas.Create;
public class CreateTaskUseCase
{
    public ResponseCreatedTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseCreatedTaskJson
        {
            Id = 1,
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            Deadline = request.Deadline,
            Status = request.Status,

        };
    }
}
