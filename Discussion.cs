using System.Collections.Generic;

namespace NK_OOP_Lab3
{
    /// <summary>
    /// Represents a discussion in the project.
    /// </summary>
    public class Discussion
    {
        // Fields
        private List<Message> messages = new List<Message>(); // List of messages in the discussion

        // Properties
        /// <summary>
        /// Gets or sets the task associated with the discussion.
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
        /// Writes a new message to the discussion.
        /// </summary>
        /// <param name="message">The content of the message to write.</param>
        public void WriteMessage(string message)
        {
            messages.Add(new Message { Content = message });
        }

        /// <summary>
        /// Sends a message to the discussion.
        /// </summary>
        /// <param name="message">The message to send.</param>
        public void SendMessage(Message message)
        {
            // Implementation goes here
        }

        /// <summary>
        /// Changes an existing message in the discussion.
        /// </summary>
        /// <param name="message">The message to change.</param>
        public void ChangeMessage(Message message)
        {
            // Implementation goes here
        }

        /// <summary>
        /// Deletes a message from the discussion.
        /// </summary>
        /// <param name="message">The message to delete.</param>
        public void DeleteMessage(Message message)
        {
            // Implementation goes here
        }
    }
}
