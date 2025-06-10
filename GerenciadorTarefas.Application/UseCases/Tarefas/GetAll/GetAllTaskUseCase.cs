using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefas.Application.UseCases.Tarefas.GetAll;
public class GetAllTaskUseCase
{
    public ResponseAllTasksJson Execute() 
    {
        return new ResponseAllTasksJson
        {
            Tasks = new List<ResponseShortTaskJson>
            {
                new ResponseShortTaskJson
                {
                    Id = 1,
                    Name = "Estudar",
                    Description = "Estudar C#",
                    Status = Communication.Enums.Status.Aguardando,
                }
            }
        };
    }
}
