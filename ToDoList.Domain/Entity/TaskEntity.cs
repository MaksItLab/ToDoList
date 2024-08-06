using ToDoList.Domain.Enum;

namespace ToDoList.Domain.Entity
{
    /// <summary>
    /// Сущность задачи
    /// </summary>
    public class TaskEntity
    {
        /// <summary>
        /// Уникальный идентификатор задачи 
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Название задачи
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание задачи
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Приоритет задачи
        /// </summary>
        public Priority Priority { get; set; }
    }
}
