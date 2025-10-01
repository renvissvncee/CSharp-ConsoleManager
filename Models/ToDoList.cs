using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using ConsoleManager.Models;
namespace ConsoleManager.Models
{
    internal class ToDoList
    {
        private List<ToDoTask> list = new List<ToDoTask>();

        internal string? Title { get; set; }

        private bool _IsSelfCompleting;
        internal int Number { get; set; }
        internal bool IsSelfCompleting
        {
            get => _IsSelfCompleting;
            set
            {
                _IsSelfCompleting = value;
                if (_IsSelfCompleting)
                {
                    list.RemoveAt(t => t.IsDone);
                }
            }
        }
    }
}