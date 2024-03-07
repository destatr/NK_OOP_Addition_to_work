namespace NK_OOP_Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner("admin");
            Member member = new Member("Alex");
            Board board = new Board(owner);
            TaskManager taskManager = new TaskManager();
            Task task = new Task();

            Console.WriteLine("Add task:");
            task = taskManager.AddTask(board, "Zero");
            task = taskManager.AddTask(board, "One");
            task = taskManager.AddTask(board, "Two");
            Console.WriteLine(taskManager.GetTaskList(board));

            Console.WriteLine("Remove task:");
            taskManager.RemoveTask(board);
            Console.WriteLine(taskManager.GetTaskList(board));

            Console.WriteLine("Add and delete member: ");
            owner.AddMemberToBoard(board, member);
            owner.RemoveMemberFromBoard(board, member);
            
            Console.WriteLine();
            Console.WriteLine("Get task from ID: ");
            taskManager.GetTaskFromID(board, 0);
            taskManager.GetTaskFromID(board, 1);
            taskManager.GetTaskFromID(board, 2);

        }
    }
}
