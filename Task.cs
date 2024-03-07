using System;

namespace NK_OOP_Lab3
{
    /// <summary>
    /// Represents a task in a project.
    /// </summary>
    public class Task
    {
        // Fields
        private static int lastTaskId = 0; // The last assigned task ID
        private int taskId;                // The unique identifier of the task
        private string taskName;           // The name of the task
        private DateTime deadline;         // The deadline of the task

        public int TaskId
        {
            get { return taskId; }
        }

        public string TaskName
        {
            get { return taskName; }
        }

        public DateTime Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }

        /// <summary>
        /// Gets or sets the board associated with the task.
        /// </summary>
        public Board Board
        {
            get => default;
            set
            {
            }
        }


        public Task()
        {
            taskName = "New task";
            lastTaskId++;
            taskId = lastTaskId;
        }

        public Task(string name)
        {
            taskName = name;
            lastTaskId++;
            taskId = lastTaskId;
        }

        public Task(string name, DateTime deadline) : this(name)
        {
            this.deadline = deadline;
        }
    }
}
