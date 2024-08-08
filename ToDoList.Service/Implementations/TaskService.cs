using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ToDoList.DAL.Interfaces;
using ToDoList.Domain.Entity;
using ToDoList.Domain.Enum;
using ToDoList.Domain.Response;
using ToDoList.Domain.ViewModel;
using ToDoList.Service.Interfaces;

namespace ToDoList.Service.Implementations
{
    public class TaskService : ITaskService
    {
        private readonly IBaseRepository<TaskEntity> _taskRepository;
        private ILogger<TaskService> _logger;

        public TaskService(IBaseRepository<TaskEntity> taskRepository, ILogger<TaskService> logger)
        {
            _taskRepository = taskRepository;
            _logger = logger;
        }
        public async Task<IBaseResponce<TaskEntity>> Create(CreateTaskViewModel model)
        {
            try
            {
                _logger.LogInformation($"Запрос на создание задачи - {model.Name}");

                var task = _taskRepository.GetAll()
                    .Where(x => x.Created == DateTime.Today)
                    .FirstOrDefaultAsync(x => x.Name == model.Name);
                if (task != null)
                {
                    return new BaseResponse<TaskEntity>() { 
                        Description = "Задача с таким названием уже существует", 
                        StatusCode = StatusCode.TaskIsHasAlready 
                    };
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
