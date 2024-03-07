using System;
using System.Text;

namespace NK_OOP_Lab3
{
    /// <summary>
    /// Manages tasks in a project.
    /// </summary>
    public class TaskManager
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskManager"/> class.
        /// </summary>
        public TaskManager() { }

        // Properties
        /// <summary>
        /// Gets or sets the task associated with the task manager.
        /// </summary>
        public Task Task
        {
            get => default;
            set
            {
            }
        }

        // Methods
        /// <summary>
        /// Adds a new task to the specified board.
        /// </summary>
        /// <param name="board">The board to which the task will be added.</param>
        /// <param name="taskName">The name of the new task.</param>
        /// <returns>The newly added task.</returns>
        public Task AddTask(Board board, string taskName)
        {
            if (board.Owner == null)
            {
                return null;
            }

            if (board.Tasks == null)
            {
                board.Tasks = new List<Task>();
            }

            board.AllTasksAtTheBoard++;
            Task newTask = new Task(taskName);
            board.Tasks.Add(newTask);
            return newTask;
        }

        /// <summary>
        /// Removes the last task from the specified board.
        /// </summary>
        /// <param name="board">The board from which the task will be removed.</param>
        public void RemoveTask(Board board)
        {
            if (board.Owner == null)
            {
                Console.WriteLine("Only the owner can remove tasks.");
            }
            else
            {
                if (board.AllTasksAtTheBoard > 0)
                {
                    board.AllTasksAtTheBoard--;
                    board.Tasks.RemoveAt(board.Tasks.Count - 1);
                }
                else
                {
                    Console.WriteLine("There are no tasks!");
                }
            }
        }

        /// <summary>
        /// Gets a formatted list of tasks from the specified board.
        /// </summary>
        /// <param name="board">The board from which to retrieve the task list.</param>
        /// <returns>A formatted string containing the task list.</returns>
        public string GetTaskList(Board board)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var task in board.Tasks)
            {
                stringBuilder.AppendLine($"TASK-ID: {task.TaskId}; TASK-NAME: {task.TaskName}");
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Gets the task with the specified ID from the specified board.
        /// </summary>
        /// <param name="board">The board from which to retrieve the task.</param>
        /// <param name="id">The ID of the task to retrieve.</param>
        public void GetTaskFromID(Board board, int id)
        {
            try
            {
                Task task = board.Tasks[id];
                Console.WriteLine($"Task according to id: {task.TaskName}");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid task ID.");
            }
        }
    }
}
