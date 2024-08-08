using ToDoList.Domain.Enum;

namespace ToDoList.Domain.ViewModel
{
    public class CreateTaskViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
    }
}
