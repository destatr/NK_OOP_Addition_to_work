using System;

namespace NK_OOP_Lab3
{
    /// <summary>
    /// Represents the owner of a project or board.
    /// </summary>
    public class Owner : User
    {
 
        public Owner(string name) : base(name) { }


        public TaskManager TaskManager
        {
            get => default;
            set
            {
            }
        }

        // Methods
        /// <summary>
        /// Adds a member to the specified board if the owner owns the board.
        /// </summary>
        /// <param name="board">The board to add the member to.</param>
        /// <param name="member">The member to add to the board.</param>
        public void AddMemberToBoard(Board board, Member member)
        {
            if (board.Owner == this)
            {
                board.AddMember(member);
                Console.WriteLine($"User {member.Name} has been added to the board!");
            }
            else
            {
                Console.WriteLine("Only the owner can remove users.");
            }
        }

        /// <summary>
        /// Removes a member from the specified board if the owner owns the board.
        /// </summary>
        /// <param name="board">The board to remove the member from.</param>
        /// <param name="member">The member to remove from the board.</param>
        public void RemoveMemberFromBoard(Board board, Member member)
        {
            if (board.Owner == this)
            {
                board.RemoveMember(member);
                Console.WriteLine($"Member {member.Name} has been removed from the board.");

            }
            else
            {
                Console.WriteLine("Only the owner can remove users.");
            }
        }
    }
}
