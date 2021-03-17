using System;

namespace ProjectLibrary
{
    /// <summary>
    /// Класс для отделения средних задач: task, story.
    /// Эти задачи могут быть подзадачами Epic.
    /// </summary>
    [Serializable]
    abstract public class MediumTask : Subtask
    {
        public MediumTask(string name) : base(name)
        {
        }
    }
}
