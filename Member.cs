using System;

namespace NK_OOP_Lab3
{
    /// <summary>
    /// Represents a member of the project.
    /// </summary>
    public class Member : User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Member"/> class with the specified name.
        /// </summary>
        /// <param name="name">The name of the member.</param>
        public Member(string name) : base(name) { }
    }
}
