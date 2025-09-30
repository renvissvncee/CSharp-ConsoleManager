using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using ConsoleManager.Models;
namespace ConsoleManager.Models
{
    internal class ToDoList
    {
        private List<ToDoTask> list = new List<ToDoTask>();

        private string? Title;
        private bool IsSelfCompleting;

        internal void AddToDoTask(ToDoTask task)
        {
            task.Number = list.Count + 1;
            task.IsDone = false;
            list.Add(task);
        }

        internal void DeleteToDoTask(int number)
        {
            for (int i = number; i < list.Count; i++)
            {
                list[i].Number--;
            }
            list.RemoveAt(number - 1);
        }

        internal void CompleteToDoTask(int number)
        {
            if (IsSelfCompleting)
            {
                this.DeleteToDoTask(number);
            }
            else
            {
                list[number - 1].IsDone = true;
            }
        }

        internal void SetTitle(string title) => Title = title;

        internal string ReturnTitle()
        {
            string? title = Title;
            return title!;
        }

        internal void ChangeToDoTask(int number, string newText)
        {
            list[number - 1].Text = newText;
        }

        internal void SetSelfCompleting() => IsSelfCompleting = true;
    }
}