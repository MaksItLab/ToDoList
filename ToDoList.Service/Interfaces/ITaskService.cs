using ToDoList.Domain.Entity;
using ToDoList.Domain.Response;
using ToDoList.Domain.ViewModel;

namespace ToDoList.Service.Interfaces
{
    public interface ITaskService
    {
        Task<IBaseResponce<TaskEntity>> Create(CreateTaskViewModel model);
    }
}
