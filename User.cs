using System.Collections.Generic;

namespace NK_OOP_Lab3
{
    /// <summary>
    /// Represents a user in the system.
    /// </summary>
    public class User
    {
        // Fields
        private string name; // The name of the user
        private Dictionary<string, string> contactInfo; // The contact information of the user

        // Properties
        /// <summary>
        /// Gets the name of the user.
        /// </summary>
        public string Name { get { return name; } }

        // Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class with the specified name.
        /// </summary>
        /// <param name="name">The name of the user.</param>
        public User(string name)
        {
            this.name = name;
            contactInfo = new Dictionary<string, string>();
        }

        // Methods
        /// <summary>
        /// Adds contact information to the user's profile.
        /// </summary>
        /// <param name="key">The key of the contact information.</param>
        /// <param name="value">The value of the contact information.</param>
        public void AddContact(string key, string value)
        {
            contactInfo[key] = value;
        }

        /// <summary>
        /// Gets the contact information of the user associated with the specified key.
        /// </summary>
        /// <param name="key">The key of the contact information to retrieve.</param>
        /// <returns>The contact information associated with the specified key, or null if the key is not found.</returns>
        public string GetContactInfo(string key)
        {
            return contactInfo.ContainsKey(key) ? contactInfo[key] : null;
        }
    }
}
