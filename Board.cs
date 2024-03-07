namespace NK_OOP_Lab3
{
    /// <summary>
    /// Represents a board for project management.
    /// </summary>
    public class Board
    {
        // Fields
        private int allTasksAtTheBoard; // Total number of tasks on the board
        private bool isVisibility;      // Visibility flag of the board
        private List<Task> tasks;       // List of tasks on the board
        private List<Member> members;   // List of members of the board
        private Owner owner;            // Owner of the board

        // Properties
        /// <summary>
        /// Gets or sets the total number of tasks on the board.
        /// </summary>
        public int AllTasksAtTheBoard
        {
            get { return allTasksAtTheBoard; }
            set { allTasksAtTheBoard = value; }
        }

        /// <summary>
        /// Gets the visibility status of the board.
        /// </summary>
        public bool Visibility
        {
            get { return isVisibility; }
        }

        /// <summary>
        /// Gets the list of members of the board.
        /// </summary>
        public List<Member> Members
        {
            get { return members; }
        }

        /// <summary>
        /// Gets the owner of the board.
        /// </summary>
        public Owner Owner
        {
            get { return owner; }
        }

        /// <summary>
        /// Gets or sets the list of tasks on the board.
        /// </summary>
        public List<Task> Tasks
        {
            get { return tasks; }
            set { tasks = value; }
        }

        // Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Board"/> class with default values.
        /// </summary>
        public Board()
        {
            allTasksAtTheBoard = 0;
            isVisibility = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Board"/> class with specified visibility and owner.
        /// </summary>
        /// <param name="isVisibility">The visibility status of the board.</param>
        /// <param name="owner">The owner of the board.</param>
        public Board(bool isVisibility, Owner owner)
        {
            allTasksAtTheBoard = 0;
            this.isVisibility = isVisibility;
            tasks = new List<Task>();
            members = new List<Member>();
            this.owner = owner;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Board"/> class with specified owner.
        /// </summary>
        /// <param name="owner">The owner of the board.</param>
        public Board(Owner owner)
        {
            allTasksAtTheBoard = 0;
            tasks = new List<Task>();
            isVisibility = false;
            members = new List<Member>();
            this.owner = owner;
        }

        // Methods
        /// <summary>
        /// Sets the visibility status of the board.
        /// </summary>
        /// <param name="status">The visibility status to set.</param>
        public void SetVisibilityForBoard(bool status)
        {
            if (owner == null)
            {
                Console.WriteLine("Only the owner can set visibility!");
            }
            else isVisibility = status;
        }

        /// <summary>
        /// Adds a member to the board.
        /// </summary>
        /// <param name="newMember">The member to add.</param>
        public void AddMember(Member newMember)
        {
            members.Add(newMember);
        }

        /// <summary>
        /// Removes a member from the board.
        /// </summary>
        /// <param name="member">The member to remove.</param>
        public void RemoveMember(Member member)
        {
            if (members.Contains(member))
            {
                members.Remove(member);
            }
            else
            {
                Console.WriteLine($"Member {member.Name} is not found on the board.");
            }
        }
    }
}
