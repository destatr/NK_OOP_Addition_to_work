using System;

namespace NK_OOP_Lab3
{
    /// <summary>
    /// Represents a message in a discussion.
    /// </summary>
    public class Message
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public User Sender { get; set; }
        public string Content { get; set; }


        public Discussion Discussion
        {
            get => default;
            set
            {
            }
        }
    }
}
