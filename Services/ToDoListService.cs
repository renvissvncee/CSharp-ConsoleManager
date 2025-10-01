using ConsoleManager.Models;

namespace ConsoleManager.Services
{
    class ToDoListService
    {
        private readonly ToDoList _list;

        internal ToDoListListService(ToDoList list) => _list = list;

        internal void AddToDoTask(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException("Текст задачи не может быть пустым");

            var task = new ToDoTask
            {
                Text = text,
                IsDone = false,
                Number = _list.Count + 1
            };

            _list.Add(task);
        }

        internal void DeleteTask(int number)
        {
            if (number > _list.Count || number <= 0)
                throw new ArgumentOutOfRangeException(nameof(number), "Неверный номер задачи");

            for (int i = number; i < _list.Count; i++)
            {
                _list[i].Number--;
            }
            _list.RemoveAt(number - 1);
        }

        internal void CompleteTask(int number)
        {
            if (number > _list.Count || number <= 0)
                throw new ArgumentOutOfRangeException(nameof(number), "Неверный номер задачи");

            if (_list.IsSelfCompleting)
            {
                DeleteTask(number);
            }
            else
            {
                _list[number - 1].IsDone = true;
            }
        }

        internal void ChangeTask(int number, string newText)
        {
            if (number > _list.Count || number <= 0)
                throw new ArgumentOutOfRangeException(nameof(number), "Неверный номер задачи");
            if (string.IsNullOrWhiteSpace(newText))
                throw new ArgumentException("Текст задачи не может быть пустым");

            _list[number - 1].Text = newText; 
        }

    }
}
