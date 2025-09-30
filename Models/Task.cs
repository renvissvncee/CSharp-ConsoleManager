using System.Dynamic;

namespace ConsoleManager.Models
{
    internal class ToDoTask
    {
        internal string? Text { get; set; }
        internal bool IsDone { get; set; }
        internal int Number { get; set; } // начиная с единицы

        internal void Rename(string newName) => Text = newName;
        internal void Complete() => IsDone = true;
    }
}